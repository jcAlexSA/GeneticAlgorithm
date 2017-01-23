using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GeneticAlgorithm
{
    class FileWork
    {
        static private string hex_population = "hex_population.txt";
        static private string bin_population = "bin_population.txt";
        static private string fitness_population = "fitness_population.txt";

        public void save_new_population(GA[] population)
        {
            if (File.Exists(hex_population))
                File.Delete(hex_population);

            if (!File.Exists(hex_population))
            {
                using (StreamWriter sw = File.CreateText(hex_population))
                {
                    sw.WriteLine(Convert.ToString(population.Length));
                    sw.WriteLine(Convert.ToString(population[0].x.Length));
                    for (int i = 0; i < population.Length; i++)
                    {
                        for (int j = 0; j < population[i].x.Length; j++)
                        {
                            sw.WriteLine(Convert.ToString(population[i].x[j]));
                        }
                    }
                }
            }

            if (File.Exists(bin_population))
                File.Delete(bin_population);

            if (!File.Exists(bin_population))
            {
                using (StreamWriter sw = File.CreateText(bin_population))
                {
                    sw.WriteLine(Convert.ToString(population.Length));
                    sw.WriteLine(Convert.ToString(population[0].bit_x.Length));
                    for (int i = 0; i < population.Length; i++)
                    {
                        for (int j = 0; j < population[i].bit_x.Length; j++)
                        {
                            sw.WriteLine(Convert.ToString(population[i].bit_x[j]));
                        }
                    }
                }
            }

            if (File.Exists(fitness_population))
                File.Delete(fitness_population);

            if (!File.Exists(fitness_population))
            {
                using (StreamWriter sw = File.CreateText(fitness_population))
                {
                    sw.WriteLine(Convert.ToString(population.Length));
                    for (int i = 0; i < population.Length; i++)
                    {
                        sw.WriteLine(Convert.ToString(population[i].fitness));
                    }
                }
            }
        }

        public bool load_old_population(out GA[] population, ref int count_variable, ref int length_popup)
        {
            if (!File.Exists(hex_population) | !File.Exists(bin_population) | !File.Exists(fitness_population))
            {
                population = null;
                return false;
            }

            using (StreamReader sr = File.OpenText(hex_population))
            {
                string data = "";
                length_popup = Convert.ToInt16(sr.ReadLine());
                count_variable = Convert.ToInt16(sr.ReadLine());
                population = new GA[length_popup];
                for (int i = 0; i < population.Length; i++)
                {
                    population[i] = new GA(count_variable);
                }
                int j = 0;
                bool flag = true;
                while (flag)
                {
                    for (int i = 0; i < count_variable; i++)
                    {
                        data = sr.ReadLine();
                        if (data != null)
                            population[j].x[i] = Convert.ToDouble(data);
                        else
                            flag = false;
                    }
                    j++;
                }
            }

            using (StreamReader sr = File.OpenText(bin_population))
            {
                string data = "";
                length_popup = Convert.ToInt16(sr.ReadLine());
                count_variable = Convert.ToInt16(sr.ReadLine());
                int j = 0;
                bool flag = true;
                while (flag)
                {
                    for (int i = 0; i < count_variable; i++)
                    {
                        data = sr.ReadLine();
                        if (data != null)
                            population[j].bit_x[i] = data;
                        else
                            flag = false;
                    }
                    j++;
                }
            }

            using (StreamReader sr = File.OpenText(fitness_population))
            {
                string data = "";
                length_popup = Convert.ToInt16(sr.ReadLine());
                int j = 0;
                while ((data = sr.ReadLine()) != null)
                {
                    population[j].fitness = Convert.ToDouble(data);
                    j++;
                }
            }
            return true;
        }

        public void save_result_counting(int length_popup, int count_var, int iteration, double delta, int cross, int method_parent
                    , int number_chromosom, double possible_mutation)
        {
            string[] dirs;
            string directory = @"Statistic\";

            dirs = Directory.GetFiles(@directory);

            string fileName = directory + Convert.ToString(dirs.Length+1) + ".txt";

            if (!File.Exists(fileName))
            {
                using (StreamWriter sw = File.CreateText(fileName))
                {
                    sw.WriteLine(Convert.ToString(length_popup));      //особей в популяции
                    sw.WriteLine(Convert.ToString(count_var)); //кол-во переменных на особь
                    sw.WriteLine(Convert.ToString(iteration));              //кол-во итераций
                    sw.WriteLine(Convert.ToString(delta));                  //дельта                    
                    sw.WriteLine(Convert.ToString(cross));                  //кроссовер
                    sw.WriteLine(Convert.ToString(method_parent));          //метод отбора родителей
                    sw.WriteLine(Convert.ToString(number_chromosom));       //количество хромосом при срещивании
                    sw.WriteLine(Convert.ToString(possible_mutation));      //вероятность мутации

                    sw.Close();
                }
            }
        }
    }
}
