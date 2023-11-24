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
        public static Tuple<string, int, float, bool, string[]> Main()
        {
            // TODO
            var name = "John";
            var age = 25;
            var weight = 78.4;
            var isHuman = true;
            var friends = new string[] { "Paul", "Sam", "David" };

            return new Tuple<string, int, float, bool, string[]>
                (name, age, (float)weight, isHuman, friends);
        }

        /// <summary>
        /// le caractere à modifier
        /// pour une fonction qui fait du modulo
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public static void ComputeAndDisplay(int a, int b)
        {
            var res = a % b;
            Console.WriteLine(res);
        }

        /// <summary>
        /// Convertir un variable en un autre
        /// de type
        /// </summary>
        /// <returns></returns>
        public static Tuple<int, bool, string> GetConvert()
        {
            var myInt = "17";
            var myBool = "False";
            var myString = 100;

            var myIntConverted = int.Parse(myInt);
            var myBoolConverted = bool.Parse(myBool);
            var myStringConverted = myString.ToString();


            return new Tuple<int, bool, string>
                (myIntConverted, myBoolConverted, myStringConverted);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        public static bool IsPalindrome(string word)
        {

            string? pal = string.Join("", word.Split(' '));
            string first = pal.Substring(0, pal.Length / 2);
            // donnonse l'inverse du mot
            var second = pal.ToCharArray();
            Array.Reverse(second);
            var secondString = new String(second);
            var halfSecondString = secondString.Substring(0, secondString.Length/2);

            return first.Equals(halfSecondString);

        }
    }
}