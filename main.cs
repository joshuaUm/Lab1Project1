/// Lab No. 1		Project No. 1
/// File Name: main.js
/// @author: Joshua Um
/// Date:  August 30, 2021
///
/// Problem Statement: Ask the user to enter three numbers, calculate the sum, product, and sum / product, then display the results.
/// 
/// 
/// Overall Plan:
/// 1) Print an initial welcoming message to the screen
/// 2) Prompt the user for three integers
/// 3) Calculate the sum of the integers
/// 4) Calculate the product of the integers
/// 5) Calculate the sum / product of the integers
/// 6) Print the results of the 3 calculations 
/// 

using System;

class Program {
  public static void Main (string[] args) {
      // print a message to the screen
            Console.WriteLine("Hello out there.");
            Console.WriteLine("I will add three numbers for you.");
            Console.WriteLine("Enter one number and press enter, then enter second number and press enter, then enter third number then press enter:");

            // declare three integer variables
            int n1, n2, n3, sum, product;
            double division;

            string userInput;
            userInput = Console.ReadLine();
            n1 = Int32.Parse(userInput);
            n2 = Int32.Parse(Console.ReadLine());
            n3 = Int32.Parse(Console.ReadLine());
            // calculate the product of these two numbers
            sum = n1 + n2 + n3;
            product = n1 * n2 * n3;
            division = product / (double) sum;


            // print a message displaying results of calculations
            Console.WriteLine("Sum : " + sum);
            Console.WriteLine("Product : " + product);
            Console.WriteLine("Product / Sum : " + division);

            //Just to pause the screen.
            Console.ReadLine();
  }
}