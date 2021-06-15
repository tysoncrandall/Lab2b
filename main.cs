using System;

class MainClass {
  public static void Main (string[] args) {
    
    Console.Write("Enter a number: ");
    int num1 = Int32.Parse(Console.ReadLine());

    Console.Write("Enter another number: ");
    int num2 = Int32.Parse(Console.ReadLine());
    
    int sum = (num1 + num2);
    Console.WriteLine("Sum = " + sum);

    int diff = (num1 - num2);
    Console.WriteLine("Diff = " + diff);

    int product = (num1 * num2);
    Console.WriteLine("Product = " + product);

    int quotient = (num1 / num2);
    Console.WriteLine("Quotient = " + quotient);

    int remainder = (num1 % num2);
    Console.WriteLine("Remainder = " + remainder);
  }
}