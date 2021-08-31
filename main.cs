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