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
    public partial class Statistic : Form
    {
        static int count_files;
        static string[] dirs;

        static List<Data> list_data;    
        
        public Statistic()
        {
            InitializeComponent();

            list_data = new List<Data>(0);

            string directory = @"Statistic\";
            dirs = Directory.GetFiles(@directory);
            count_files = dirs.Length;

            foreach (string dir in dirs)
            {
                string filename = dir;
                read_files(filename);
            }

            pictureBox_statistic.Invalidate();
        }

        public void read_files(string filename)
        {
            using (StreamReader sr = File.OpenText(filename))
            {
                Data temp_data = new Data();

                temp_data.length_population = Convert.ToInt32(sr.ReadLine());
                temp_data.count_variable = Convert.ToInt32(sr.ReadLine());
                temp_data.iterations = Convert.ToInt32(sr.ReadLine());
                temp_data.delta = Convert.ToDouble(sr.ReadLine());
                temp_data.crossover = Convert.ToInt32(sr.ReadLine());
                temp_data.method_parent = Convert.ToInt32(sr.ReadLine());
                temp_data.count_chromosomes = Convert.ToInt32(sr.ReadLine());
                temp_data.possibility_mutation = Convert.ToDouble(sr.ReadLine());

                list_data.Add(temp_data);

                tb_individuals_in_popup.Text = Convert.ToString(temp_data.length_population);
                tb_variable_in_population.Text = Convert.ToString(temp_data.count_variable);
            }
        }

        private void pictureBox_statistic_Paint(object sender, PaintEventArgs e)
        {

            Point baseLine = new Point(10, pictureBox_statistic.Height - 20);
            SolidBrush brush = new SolidBrush(Color.Red);

            double scale = pictureBox_statistic.Height / 100.0;

            int step = baseLine.X;

            int max = 0;
            foreach (Data data in list_data)
                if (max < data.iterations)
                    max = data.iterations;
           
            for(int i = 0; i < list_data.Count; i++){
                int height = (list_data[i].iterations * (pictureBox_statistic.Height - 80)) / max;
                e.Graphics.FillRectangle(brush, new Rectangle(step, pictureBox_statistic.Height - height, 30, height));

                Data data = list_data[i];

                int temp_height = height + 10;

                e.Graphics.DrawString("Итер.: " + Convert.ToString(data.iterations), new Font("Times New Roman", 6), Brushes.Black, new PointF(step, pictureBox_statistic.Height - temp_height));
                temp_height += 10;
                e.Graphics.DrawString("Дельта: " + Convert.ToString(data.delta), new Font("Times New Roman", 6), Brushes.Black, new PointF(step, pictureBox_statistic.Height - temp_height));
                temp_height += 10;

                string cross = "";
                if (data.crossover == 1)
                    cross = "одноточ.";
                else if (data.crossover == 2)
                    cross = "двуточ.";

                e.Graphics.DrawString("Крос. " + Convert.ToString(data.crossover), new Font("Times New Roman", 6), Brushes.Black, new PointF(step, pictureBox_statistic.Height - temp_height));
                temp_height += 10;
                string method = "";
                if (data.method_parent == 1)
                    method = "Панмикс.";
                else if (data.method_parent == 2)
                    method = "Селект.";
                else if (data.method_parent == 3)
                    method = "Аутбрид.";
                else if (data.method_parent == 4)
                    method = "Инбрид.";

                e.Graphics.DrawString(method, new Font("Times New Roman", 6), Brushes.Black, new PointF(step, pictureBox_statistic.Height - temp_height));
                temp_height += 10;
                e.Graphics.DrawString("Хром. " + Convert.ToString(data.count_chromosomes), new Font("Times New Roman", 6), Brushes.Black, new PointF(step, pictureBox_statistic.Height - temp_height));
                temp_height += 10;
                e.Graphics.DrawString("Мутац. " + Convert.ToString(data.possibility_mutation), new Font("Times New Roman", 6), Brushes.Black, new PointF(step, pictureBox_statistic.Height - temp_height));
                
                step += 40;
            }
                       
            brush.Dispose();

        }

        private void Statistic_Resize(object sender, EventArgs e)
        {
            pictureBox_statistic.Invalidate();
        }       
    }
}
