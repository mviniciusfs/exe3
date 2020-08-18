using System;

class MainClass {
  public static void Main (string[] args) 
  {
    Console.WriteLine ("Digite dois números: ");
    int n1 = int.Parse(Console.ReadLine());
    int n2 = int.Parse(Console.ReadLine());

    Console.WriteLine("Soma é: " + (n1 + n2));
  }
}