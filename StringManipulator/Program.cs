// See https://aka.ms/new-console-template for more information
using StringManipulator;

//Console.WriteLine("Hello, World!");

StringManipulator.StringManipulator stringManipulator = new StringManipulator.StringManipulator();
Console.WriteLine(stringManipulator.ReverseString("Hola"));
Console.WriteLine(stringManipulator.CountWords("Hola cómo estás?"));
//Console.WriteLine(stringManipulator.CountLines("Hola todo bien, y vos", 3));
//Console.WriteLine(stringManipulator.CountLines("Hola todo bien, y vos", 0));