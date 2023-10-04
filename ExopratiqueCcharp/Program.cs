// See https://aka.ms/new-console-template for more information
using ExopratiqueCcharp.session2;

Console.WriteLine(" Traitement des différents Exercices");

var t = Exercice1.Main();

Console.WriteLine($"name: {t.Item1}, age : {t.Item2} , weight : {t.Item3}, isHuman: {t.Item4}");

Console.WriteLine("===DisplayCompute===");
Exercice1.ComputeAndDisplay(10,2);
Exercice1.ComputeAndDisplay(21,21);
Exercice1.ComputeAndDisplay(99,3);



