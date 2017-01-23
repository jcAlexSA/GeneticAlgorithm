using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithm
{
    public class GA
    {
        public int length;      //количество переменных в уравнении
        public double[] x;      //массив с переменными 
        public string[] bit_x;  //массив с битовым представлением переменных
        public double fitness;  //приспособленность данной особи (иксов)

        public GA(int length)
        {
            this.length = length;
            x = new double[length];
            bit_x = new string[length];
            for (int i = 0; i < x.Length; i++)
            {
                x[i] = 0; 
                bit_x[i] = "00";
            }
        }
        
        public void fitness_function()
        {
            fitness = 0.0;
            for (int i = 0; i < x.Length; i++)
            {
                fitness += Math.Sin(x[i]) * Math.Pow( Math.Sin( (i * Math.Pow(x[i], 2)) / Math.PI ) , 2);
            }
            fitness = -fitness;
        }
    }
}
