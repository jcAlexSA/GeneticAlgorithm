using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GeneticAlgorithm
{
    public partial class Form1 : Form
    {
        FileWork fileWork;

        Statistic statistic;

        public static int length_x;                 //количество переменных в особи
        public static int count_chromosoms;         //количество хромосом при кроссинговере
        public static int size_of_population;       //размер популяции
        public static double mutation_probability;  //вероятность мутации
       
        public static int precision_decimal_point;  //точность после запятой

        public static double min, max;              //нижнаяя и верхняя границы для Х

        public Form1()
        {

            InitializeComponent();

            fileWork = new FileWork();

            reading_base_date();

            precision_decimal_point = 3;

            max = 3.14;// Math.PI;
            min = -max;
        }

        public void reading_base_date()
        {
            length_x = Convert.ToInt32(numUpDown_count_X.Value);

            double mutation_probability = 0.0;
            try
            {
                mutation_probability = Convert.ToDouble(tb_Mutation_probability.Text);
            }
            catch (Exception) { mutation_probability = Convert.ToDouble(tb_Mutation_probability.Text.Replace('.', ',')); }

            count_chromosoms = Convert.ToInt32(numUpDown_Count_Chromosome.Value);
            size_of_population = Convert.ToInt32(cb_Size_Population.Text);
        }

        public void print(GA[] population, TextBox textBox_print)
        {
            textBox_print.Clear();
            for (int i = 0; i < population.Length; i++)
            {
                for (int j = 0; j < population[i].x.Length; j++)
                {
                    textBox_print.AppendText("x" + Convert.ToString(j+1) + ": " + Convert.ToString(population[i].x[j]).Substring(0, 5) + "     " + population[i].bit_x[j] + '\n');
                } textBox_print.AppendText("F = " + Convert.ToString(population[i].fitness) + "\n\n");
            }
        }

        public int count_need_bit()//определяем число битов, необходимых для кодирования
                    //одной переменной Хj
        {
            int count_bit = (int) ((max - min) * Math.Pow(10, precision_decimal_point));
            textBox_initial_popup.AppendText(Convert.ToString(count_bit) + '\n');
            int power = 1;
            while(true){
                if ((Math.Pow(2, power) - 1) > count_bit)
                {
                    break;
                }
                power++;
            }
            textBox_initial_popup.AppendText(Convert.ToString(power) + '\n');
            return power;
        }

        public string decTobin(int dec_number)//из 10-ой в 2-ую
        {
            if (dec_number == 0) return "0";
            if (dec_number == 1) return "1";
            if (dec_number % 2 == 0)
                return decTobin(dec_number / 2) + "0";
            else
                return decTobin(dec_number / 2) + "1";
        }

        public int binToDec(string bin_number)//из 2-ой в 10-ую
        {
            int result = 0, pow = 1;
            for (int i = bin_number.Length - 1; i >= 0;  --i, pow <<= 1)
                result += (bin_number[i] - '0') * pow;
            return result;            
        }

        public void generic_x_array(ref GA[] population, int size_fenotip)
        {
            int[] temp_dec_num = new int[population[0].x.Length];
            Random rand = new Random();

            for (int i = 0; i < population.Length; i++)
            {
                for (int j = 0; j < population[i].x.Length; j++)
                {
                    //генерируем случайное число в двоичной системе
                    string bin_number = "";
                    for (int k = 0; k < size_fenotip; k++)
                    {
                        bin_number += (rand.Next() % 2 == 1) ? "1" : "0"; 
                    }
                    population[i].bit_x[j] = bin_number;//записываем в массив

                    //переводим строковое представление двоичного числа в десятичную систему
                    //      и записываем в массив
                    temp_dec_num[j] = binToDec(bin_number);

                    //получаем числа с плавающей точкой
                    population[i].x[j] = min + temp_dec_num[j] * (double)((max - min) / (Math.Pow(2, size_fenotip) - 1));
                }
            }
        }

        public void Initial_GA_object(ref GA[] population, ref int size_fenotip, ref int size_chromosome)
        {
            size_fenotip = count_need_bit();   //определяем кол-во бит, необходимых для кодирования одного Хj
            //кол-во иксов изменяемо. => определяем кол-во бит в хромосоме
            size_chromosome = size_fenotip * length_x;

            generic_x_array(ref population, size_fenotip);

            //приспосабливаемость считаем
            for (int i = 0; i < population.Length; i++)
            {
                population[i].fitness_function();
            }
        }

        public int search_close_pair(int index, GA[] population, string[] convert)      //поиск пары для родителя
        {            
            //ищем максимально похожую особь на обратную 
            int position_best_element = 0;
            int best_equals = 0;
            for (int i = 0; i < population.Length; i++)
            {
                if (i == index) continue;//пропускаем итерацию, в которой находимся на позиции шаблонного элемента, лучшую купию которому ищем
                int temp = 0;
                for (int j = 0; j < population[i].bit_x.Length; j++)
                {
                    for (int len_str = 0; len_str < population[i].bit_x[j].Length; len_str++)
                    {
                        if (convert[j][len_str] == population[i].bit_x[j][len_str])
                        {
                            temp++;
                        }
                    }
                }
                if (temp > best_equals)
                {
                    best_equals = temp;
                    position_best_element = i;
                }
            }
            return position_best_element;
        }

        public void outbreeding(ref int[] index_array, GA[] population)      //аутбридинг
        {
            Random rand = new Random();
            for (int i = 0; i < index_array.Length; i+=2)
            {
                index_array[i] = rand.Next(0, size_of_population);//половину родителей определяем случайно

                //получаем массив двубайтовых чисел, присваиваем ему ОБРАТНЫЙ и ищем максимально похожие строки
                string[] convert = new string[population[index_array[i]].bit_x.Length];
                for (int j = 0; j < population[index_array[i]].bit_x.Length; j++)//копирование массива
                {
                    convert[j] = population[index_array[i]].bit_x[j];
                }

                for (int k = 0; k < convert.Length; k++) //инверсия битовой строки
                {
                    string temp = "";
                    for (int j = 0; j < convert[k].Length; j++)
                    {
                        temp += (convert[k][j] == '0') ? "1" : "0";
                    }
                    convert[k] = temp;
                }

                index_array[i + 1] = search_close_pair(index_array[i], population, convert);//остальную половину ищем максимально непохожей
            }
        }

        public void inbreeding(ref int[] index_array, GA[] population)  //инбридинг
        {
            Random rand = new Random();
            for (int i = 0; i < index_array.Length; i += 2)
            {
                index_array[i] = rand.Next(0, size_of_population); //половину родителей определяем случайно

                string[] copy = new string[population[index_array[i]].bit_x.Length];
                for (int j = 0; j < population[index_array[i]].bit_x.Length; j++)//копирование массива
                {
                    copy[j] = population[index_array[i]].bit_x[j];
                }

                index_array[i + 1] = search_close_pair(index_array[i], population, copy);
            }
        }

        public void panmixia(ref int[] index_array, GA[] population)  //панмиксия (оба родителя выбираются случайно)
        {
            Random rand = new Random();
            for (int i = 0; i < index_array.Length; i++)
            {
                index_array[i] = rand.Next(0, size_of_population); //всех родителей выбираем случайно      
            }
        }

        public void breeding(ref int[] index_array, GA[] population)  //селективный - родителями могут 
                     //быть только те особи, среднее значение фитнес-функции которых больше среднего
        {
            //получаем среднее значение фитнес-функции по популяции
            double average = 0.0;
            for (int i = 0; i < population.Length; i++)
            {
                average += population[i].fitness;
            }
            average /= population.Length;
            
            Random rand = new Random();
            //выбираем случайно особей. если не удовлетворяет условиям, то берем другое число
            for (int i = 0; i < index_array.Length; i++)
            {
                while (true)
                {
                    int position = rand.Next(0, size_of_population);
                    if (population[position].fitness > average)
                    {
                        index_array[i] = position;
                        break;
                    }
                }
            }
        }

        public void searching_parents(ref int[] index_array, GA[]population)//поиск родителей для скрещивания
        {
            if (rb_Breeding.Checked)
            {
                breeding(ref index_array, population);
            }
            else if (rb_Inbreeding.Checked)
            {
                inbreeding(ref index_array, population);
            }
            else if (rb_Outbreeding.Checked)
            {
                outbreeding(ref index_array, population);
            }
            else if (rb_Panmixia.Checked)
            {
                panmixia(ref index_array, population);
            }
        }

        public void mutation(ref string[] merge_chromosome, Random rand)
        {
            for (int i = 0; i < merge_chromosome.Length; i++)
            {
                if (rand.NextDouble() > mutation_probability)
                {
                    int gen = rand.Next(0, merge_chromosome[i].Length);
                    string temp = merge_chromosome[i].Substring(0, gen);
                    temp += (merge_chromosome[i][gen] == '0') ? "1" : "0";
                    temp += merge_chromosome[i].Substring(gen + 1);
                    merge_chromosome[i] = temp;
                }
            }
        }

        public void single_crossing(Random random, ref string[] merge_chromosome, int size_chromosome)
        {
            int cross_point = random.Next(1, size_chromosome);
            for (int i = 0; i < merge_chromosome.Length; i += 2)
            {
                string str1 = merge_chromosome[i];
                string str2 = merge_chromosome[i + 1];

                string temp_part = str1.Substring(cross_point, str1.Length - cross_point);
                str1 = str1.Substring(0, cross_point);
                str1 += str2.Substring(cross_point);
                str2 = str2.Substring(0, cross_point);
                str2 += temp_part;
                merge_chromosome[i] = str1;
                merge_chromosome[i + 1] = str2;
            }
        }

        public void point_to_point_crossing(Random random, ref string[] merge_chromosome, int size_chromosome)
        {
            int cross_point_1, cross_point_2; //объявляем две точки для кроссовера
            cross_point_1 = cross_point_2 = random.Next(1, size_chromosome);
            while (true)
            {
                int temp = random.Next(1, size_chromosome);
                if (temp == cross_point_1) continue;//точки не должны быть равны
                else if (temp < cross_point_1)      //если первая точка больше новой сгенерированной,
                {                                   //то смещаем вправо
                    cross_point_2 = cross_point_1;
                    cross_point_1 = temp;
                    break;
                }
                else if (temp > cross_point_2)      //если вторая меньше новой сгенерированной,
                {                                   //то смещаем влево
                    cross_point_1 = cross_point_2;
                    cross_point_2 = temp;
                    break;
                }
            }

            for (int i = 0; i < merge_chromosome.Length; i += 2)
            {
                string str1 = merge_chromosome[i];
                string str2 = merge_chromosome[i + 1];

                string temp_part = str1.Substring(cross_point_1, cross_point_2 - cross_point_1);
                string end_of_1 = str1.Substring(cross_point_2, str1.Length - cross_point_2); //два конца строк
                string end_of_2 = str2.Substring(cross_point_2, str1.Length - cross_point_2);

                str1 = str1.Substring(0, cross_point_1); //обрезаем первую строку до первой кроссоверной точки
                str1 += str2.Substring(cross_point_1, cross_point_2 - cross_point_1);//добавляем часть второй строки
                str1 += end_of_1; //добавляем конец

                str2 = str2.Substring(0, cross_point_1); //обрезаем вторую строку до первой кроссоверной точки
                str2 += temp_part;  //добавляем часть первой строки
                str2 += end_of_2;   //добавляем конец
                merge_chromosome[i] = str1;
                merge_chromosome[i + 1] = str2;
            }
        }

        public void crossovering(ref GA[] population, int size_fenotip, int size_chromosome)      //скрещивание
        {
            textBox_final_popup.Clear();
            //создаем массив, в котором будут указаны индексы родителей, которые учавствуют в скрещивании
            int[] index_array = new int[count_chromosoms];
            for (int i = 0; i < index_array.Length; i++)
                index_array[i] = 0;

            searching_parents(ref index_array, population);

            Random random = new Random();

            //создаем массив, который будет хранить родителей
            GA[] parent_array = new GA[index_array.Length];
            for (int i = 0; i < parent_array.Length; i++) parent_array[i] = new GA(length_x);
            for (int i = 0; i < parent_array.Length; i++)//копируем массив
            {
                for (int j = 0; j < parent_array[i].x.Length; j++)
                {
                    parent_array[i].x[j] = population[index_array[i]].x[j];
                    parent_array[i].bit_x[j] = population[index_array[i]].bit_x[j];
                }
                parent_array[i].fitness = population[index_array[i]].fitness;
            }


            string[] merge_chromosome = new string[index_array.Length];
            for (int i = 0; i < merge_chromosome.Length; i++)//сливаем всё в одну хромосому для кроссинговера
            {
                for (int j = 0; j < parent_array[i].bit_x.Length; j++)
                {
                    merge_chromosome[i] += parent_array[i].bit_x[j];
                } 
            }
            //скрещивание
            if (rb_single_point.Checked)//одноточечный кроссовер
            {
                single_crossing(random, ref merge_chromosome, size_chromosome);
            }
            else if (rb_point_to_point.Checked)//двухточечный кроссовер
            {
                point_to_point_crossing(random, ref merge_chromosome, size_chromosome);
            }
            
            //мутация
            mutation(ref merge_chromosome, random);

            //переписываем результаты изменения битовых строк обратно родителям
            for (int i = 0; i < parent_array.Length; i++)
            {
                for (int j = 0; j < parent_array[i].bit_x.Length; j++)
                {
                    parent_array[i].bit_x[j] = merge_chromosome[i].Substring(0, size_fenotip);
                    merge_chromosome[i] = merge_chromosome[i].Substring(size_fenotip, merge_chromosome[i].Length - size_fenotip);
                }
            }
            
            //вычисляем для предков новые значения приспосабливаемости

            for (int i = 0; i < parent_array.Length; i++)
            {
                int[] temp_dec = new int[parent_array[0].bit_x.Length];
                for (int j = 0; j < parent_array[i].bit_x.Length; j++)
                {
                    temp_dec[j] = binToDec(parent_array[i].bit_x[j]);
                    parent_array[i].x[j] = min + temp_dec[j] * (double)((max - min) / (Math.Pow(2, size_fenotip) - 1));
                }
                //считаем приспосабливаемость
                parent_array[i].fitness_function();
            }

            int count_changed_chromosom_return = (int) (count_chromosoms / 2); //количество потомков, которые заменят родителей
            int[] pos_best_descendants = new int[count_changed_chromosom_return];//позиции с лучшими потомками, которые будут записаны
            double[] sort_fitness = new double[parent_array.Length];//сортированная последовательность с потомками для отбора лучших
            for (int i = 0; i < parent_array.Length; i++)
                sort_fitness[i] = parent_array[i].fitness;

            //сортируем по убыванию
            for (int i = 0; i < sort_fitness.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (sort_fitness[i] > sort_fitness[j])
                    {
                        double temp = sort_fitness[i];
                        sort_fitness[i] = sort_fitness[j];
                        sort_fitness[j] = temp;
                    }
                }
            }

            for (int i = 0; i < pos_best_descendants.Length; i++)
            {
                for (int k = 0; k < parent_array.Length; k++)
                {
                    if (sort_fitness[i] == parent_array[k].fitness)
                    {
                        pos_best_descendants[i] = k;
                        break;
                    }
                }
            }

            for (int i = 0; i < pos_best_descendants.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (pos_best_descendants[i] < pos_best_descendants[j])
                    {
                        int temp = pos_best_descendants[i];
                        pos_best_descendants[i] = pos_best_descendants[j];
                        pos_best_descendants[j] = temp;
                    }
                }
            }
            for (int i = 0; i < pos_best_descendants.Length; i++)
            {
                population[index_array[pos_best_descendants[i]]] = parent_array[pos_best_descendants[i]];
            }                        
        }

        public bool can_continue(GA[] population, double alpha)
        {
            double diff = 0.0;
            for (int i = 1; i < population.Length; i++)
            {
                diff = Math.Abs(population[i - 1].fitness - population[i].fitness);
                if (diff > alpha)
                {
                    tb_show_delta.AppendText(Convert.ToString(diff) + '\n');
                    return true;
                }
            }
            tb_show_delta.AppendText(Convert.ToString(diff) + '\n');
            return false;
        }

        private void btn_counting_Click(object sender, EventArgs e)
        {
            textBox_final_popup.Clear();
            textBox_initial_popup.Clear();
            tb_show_delta.Clear();
            tb_count_iterations.Clear();
            btn_save_result_counting.Enabled = true;

            int size_fenotip = 0, size_chromosome = 0;
            
            reading_base_date();

            GA[] population;

            if (cb_load_old_popup.Checked)
            {
                if (!fileWork.load_old_population(out population, ref length_x, ref size_of_population))
                {
                    numUpDown_count_X.Value = length_x;
                    cb_Size_Population.Text = Convert.ToString(size_of_population);
   
                    MessageBox.Show(this, "Отсутствуют файлы с данными.\nВыполнение программы продолжится с новой популяцией.", "File not found!");
                    population = new GA[size_of_population];
                    for (int i = 0; i < population.Length; i++)
                    {
                        population[i] = new GA(length_x);
                    }
                    Initial_GA_object(ref population, ref size_fenotip, ref size_chromosome);
                }
                else
                {
                    numUpDown_count_X.Value = length_x;
                    cb_Size_Population.Text = Convert.ToString(size_of_population);
                    size_fenotip = count_need_bit();   //определяем кол-во бит, необходимых для кодирования одного Хj
                    //кол-во иксов изменяемо. => определяем кол-во бит в хромосоме
                    size_chromosome = size_fenotip * length_x;
                }
            }
            else
            {
                population = new GA[size_of_population];
                for (int i = 0; i < population.Length; i++)
                {
                    population[i] = new GA(length_x);
                }
                Initial_GA_object(ref population, ref size_fenotip, ref size_chromosome);
            }

            if (cb_save_new_popup.Checked)
            {
                fileWork.save_new_population(population);

                string directory = @"Statistic\";
                string[] dirs = Directory.GetFiles(@directory);

                foreach (string dir in dirs)
                {
                    string filename = dir;
                    if (File.Exists(dir))
                    {
                        File.Delete(dir);
                    }
                }
            }

            print(population, textBox_initial_popup);
            
            double delta = 0.0;
            try
            {
                delta = Convert.ToDouble(tb_changed_delta.Text);
            }
            catch (Exception) { delta = Convert.ToDouble(tb_changed_delta.Text.Replace('.', ',')); }

            long iteration = 0;

            if (rb_changed_delta.Checked)//если алгоритм действует по изменению дельты
            {
                iteration = 0;
                while (can_continue(population, delta))
                {
                    crossovering(ref population, size_fenotip, size_chromosome);
                    iteration++;
                }
                tb_count_iterations.Text = Convert.ToString(iteration);
            }
            else if (rb_count_epochs.Checked) //если алгоритм действует по кол-ву эпох
            {
                iteration = Convert.ToInt32(tb_count_epoch.Text);
                tb_count_iterations.Text = Convert.ToString(iteration);

                while (iteration >= 0)
                {
                    crossovering(ref population, size_fenotip, size_chromosome);
                    iteration--;
                }
            }

            textBox_final_popup.Clear();

            print(population, textBox_final_popup);
        }

        private void rb_count_epochs_CheckedChanged(object sender, EventArgs e)
        {
            tb_changed_delta.Enabled = false;
            tb_count_epoch.Enabled = true;
        }

        private void rb_changed_delta_CheckedChanged(object sender, EventArgs e)
        {
            tb_changed_delta.Enabled = true;
            tb_count_epoch.Enabled = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_load_old_popup.Checked)
            {
                cb_save_new_popup.Checked = false;
            }
        }

        private void cb_save_new_popup_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_save_new_popup.Checked)
            {
                cb_load_old_popup.Checked = false;
            }
        }

        private void btn_save_result_counting_Click(object sender, EventArgs e)
        {
            int cross = 2;
            if (rb_single_point.Checked)
                cross = 1;
            else if(rb_point_to_point.Checked)
                cross = 2;

            int method = 3;
            if (rb_Panmixia.Checked)
                method = 1;
            else if (rb_Breeding.Checked)
                method = 2;
            else if (rb_Outbreeding.Checked)
                method = 3;
            else if (rb_Inbreeding.Checked)
                method = 4;

            int iteration = Convert.ToInt32(tb_count_iterations.Text);

            double changed_delta = 0.0;
            try
            {
                changed_delta = Convert.ToDouble(tb_changed_delta.Text);
            }
            catch (Exception) { changed_delta = Convert.ToDouble(tb_changed_delta.Text.Replace('.', ',')); }

            double mutation_probability = 0.0;
            try
            {
                mutation_probability = Convert.ToDouble(tb_Mutation_probability.Text);
            }
            catch (Exception) { mutation_probability = Convert.ToDouble(tb_Mutation_probability.Text.Replace('.', ',')); }

            fileWork.save_result_counting(size_of_population, length_x, iteration, changed_delta, cross, method, count_chromosoms, mutation_probability);
            
        }

        private void btn_statistic_Click(object sender, EventArgs e)
        {
            statistic = new Statistic();
            statistic.ShowDialog();
        }

    }
}

