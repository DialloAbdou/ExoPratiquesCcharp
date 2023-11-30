// See https://aka.ms/new-console-template for more information
using ExopratiqueCcharp.session2;

//Console.WriteLine(" Traitement des différents Exercices");

//var t = Exercice1.Main();

//Console.WriteLine($"name: {t.Item1}, age : {t.Item2} , weight : {t.Item3}, isHuman: {t.Item4}");

//Console.WriteLine("===DisplayCompute===");
//Exercice1.ComputeAndDisplay(10,2);
//Exercice1.ComputeAndDisplay(21,21);
//Exercice1.ComputeAndDisplay(99,3);

//Console.WriteLine("== Convertir une variable à un autre type ==");

//Tuple<int,bool, string> conv = Exercice1.GetConvert();
//Console.WriteLine($" myIntConvert :  {conv.Item1}, myBoolConverted : {conv.Item2}, myStringConvert: {conv.Item3}");
// var conv = Exercice1.GetConvert();
//var word = "robert trebor";
//var estpalindrom =  Exercice1.IsPalindrome(word);
//Console.WriteLine(estpalindrom);

//var tab = new int[] { 1, 2, 3, 1, 1, 1, 2, 5 };

// var disc =Exercice1.StoreAndCount(tab);

//Exercice1.lireDisct(disc);

//var tabsTrie = new int[] { -3, 6, 8, 10, 12, 14 };
var date1 = new DateTime(2008, 5, 1, 8, 30, 52);
Console.WriteLine(Exercice1.ToShortDate(date1));

Console.WriteLine(Exercice1.ToFrenchFullDate(date1));
//var estTrouve = Exercice1.Exists(tabsTrie, 14);
//Console.WriteLine(estTrouve);

