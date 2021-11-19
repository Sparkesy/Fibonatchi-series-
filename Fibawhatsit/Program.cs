using System;

namespace Fibawhatsit {
    class Program {
        static void Main (string[] args) {
            Console.Write("Please enter the Whole number : ");
            int number = int.Parse(Console.ReadLine());
            Fib(0, 1, 1, number);
            Console.ReadKey();
        }
        static void Fib (int firstNumber, int secondNumber, int counter, int number) {
            Console.Write(firstNumber + " ");
            if (counter < number) {
                Fib(secondNumber, firstNumber + secondNumber, counter + 10, number);
            }
        }
    }
}

