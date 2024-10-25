using EBookReaderWithStateDesignPattern.Controllers;
using EBookReaderWithStateDesignPattern.Services;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBookReaderWithStateDesignPattern.Presentations
{
    //below class is responsible for displaying console menu and managing user interaction with ebook reader
    public class ConsolePresentation
    {
        public static void RunEBookReader()
        {
            Console.WriteLine("***** Welcome to Ebook Reader program with State design pattern *****\n");

            //instead of writing full type like EBookReaderService you can just write var and computer will understand what type you mean
            //means var makes your code look shorter and more readable it is useful when working with long or complex types
            //create new instance of eBookReaderService which handles ebook readers state and action
            var eBookReaderService = new EBookReaderService();

            //create controller to manage communication between service and console interface
            var eBookReaderController = new EBookReaderController(eBookReaderService);

            bool running = true;

            while (running)
            {
                Console.WriteLine("Ebook reader menu -> ");
                Console.WriteLine("1)Power button");
                Console.WriteLine("2)Start reading");
                Console.WriteLine("3)Stop reading");
                Console.WriteLine("4)Exit");
                Console.Write("Select option -> ");

                var input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.WriteLine(eBookReaderController.PowerButtonPressed());
                        break;
                    case "2":
                        Console.WriteLine(eBookReaderController.StartReadingButtonPressed());
                        break;
                    case "3":
                        Console.WriteLine(eBookReaderController.StopReadingButtonPressed());
                        break;
                    case "4":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("\nInvalid selection try again");
                        break;
                }

                Console.WriteLine();
            }

            Console.WriteLine("Exit ebook reader");
        }

    }
}