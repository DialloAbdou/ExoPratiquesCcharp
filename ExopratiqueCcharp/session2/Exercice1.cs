using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExopratiqueCcharp.session2
{
    public class Exercice1
    {
        /// <summary>
        ///  Utilisation de Tuple
        /// </summary>
        /// <returns></returns>
        public static Tuple<string, int, float,bool,string[]> Main()
        {
            // TODO
            var name = "John";
            var age = 25;
            var weight =78.4;
            var isHuman = true;
            var friends =  new string[]{"Paul", "Sam","David"};
            
            return new Tuple<string, int, float,bool,string[]>
                (name, age, (float) weight, isHuman, friends);
        }

        /// <summary>
        /// le caractere à modifier
        /// pour une fonction qui fait du modulo
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
         public  static void ComputeAndDisplay(int a, int b)
         {
           var res = a % b;
           Console.WriteLine(res);
         }
    }
}