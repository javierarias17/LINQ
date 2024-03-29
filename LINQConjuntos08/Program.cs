﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQConjuntos08
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> conjunto1 = new List<int> { 2, 4, 6, 8, 9 };
            List<int> conjunto2 = new List<int> { 2, 5, 6, 7, 9 };

            //Excep nos da la diferencia entre dos contenedores
            var expt = (from n1 in conjunto1 select n1).Except(from n2 in conjunto2 select n2);//Aquí importa el orden n1 y n2 != n2 y n1

            Console.WriteLine("----Except----");//R= 4,8
            foreach (int num in expt)
                Console.WriteLine(num);

            //Intersect nos da los comun entre los dos contenedores
            var ints = (from n1 in conjunto1 select n1).Intersect(from n2 in conjunto2 select n2);

            Console.WriteLine("----Intersect----");//R= 2,6,9
            foreach (int num in ints)
                Console.WriteLine(num);

            //Union nos da la union de los dos contenedores sin repeticiones
            var un = (from n1 in conjunto1 select n1).Union(from n2 in conjunto2 select n2);

            Console.WriteLine("----Union----");//R= 2,4,6,8,9,5,7
            foreach (int num in un)
                Console.WriteLine(num);

            //Concat, concatena directamente los contenedores
            var cnt = (from n1 in conjunto1 select n1).Concat(from n2 in conjunto2 select n2);

            Console.WriteLine("----Concat----");
            foreach (int num in cnt)
                Console.WriteLine(num);

            //Distinct, remueve los duplicados
            Console.WriteLine("----Distinct----");
            foreach (int num in cnt.Distinct())
                Console.WriteLine(num);
            Console.WriteLine("-----Distinct no altera la colección cnt---");
            foreach (int num in cnt)
                Console.WriteLine(num);
        }
    }
}
