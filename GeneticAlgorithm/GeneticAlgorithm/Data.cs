using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithm
{
    class Data
    {
        public int length_population;  //особей в популяции
        public int count_variable;     //кол-во переменных на особь
        public int iterations;         //кол-во итераций
        public double delta;           //дельта  
        public int crossover;          //кроссовер
        public int method_parent;      //метод отбора родителей
        public int count_chromosomes;  //количество хромосом при срещивании
        public double possibility_mutation;//вероятность мутации

        public Data()
        {
            length_population = count_variable = iterations = 0;
            delta = 0.0;
            crossover = method_parent = count_chromosomes = 0;
            possibility_mutation = 0.0;
        }
        public Data(Data data)
        {
            this.length_population = data.length_population;
            this.count_variable = data.count_variable;
            this.iterations = data.iterations;
            this.delta = data.delta;
            this.crossover = data.crossover;
            this.method_parent = data.method_parent;
            this.count_chromosomes = data.count_chromosomes;
            this.possibility_mutation = data.possibility_mutation;
        }
    }
}
