using Assignment2.StateCommandMemento.Command;
using Assignment2.StateCommandMemento.State;
using System;
using System.Collections.Generic;

namespace Assignment2.StateCommandMemento
{
    internal class SCMMain
    {
        /*
         * Skapa en maskin som kan vara av eller på. !Använd State Pattern!
         * Om man ger den ett kommando när den är av så ska den spara det kommandot och sen köra alla sparade kommandon när den sätts på. !Använd Command Pattern!
         * Kommandot ska vara att skriva ut en sträng text som användaren anger.
         * Det ska också finnas en reset funktion som tar bort alla sparade kommandon och stänger av maskinen. !Använd Memento Pattern!
         */
        public void Run()
        {
            PrintMachine printer = new();        
            var commandManager = new CommandManager(printer);
            MachineMemento machineMemento = printer.CreateMemento();
             
            // Draw Menu

            Console.WriteLine("---------------------");
            Console.WriteLine("      Printer    ");
            Console.WriteLine("---------------------");
            Console.WriteLine("A: PowerSwitch");
            Console.WriteLine("B: Enter word to print");
            Console.WriteLine("C: Reset and turn off");
            Console.WriteLine("X: Quit Program\n");

            while (true)
            {              
                var userInput = Console.ReadKey(true).KeyChar;

                switch (userInput)
                {
                    case 'a' or 'A':
                    printer.PowerSwitch();                       
                            foreach (var word in printer.WordList)
                            {
                                commandManager.Execute(word.Word);
                            }
                        printer.WordList.Clear();
                        break;

                    case 'b' or 'B':
                        Console.WriteLine("Enter word:");
                        var inputWord = Console.ReadLine();
                        commandManager.Execute(inputWord);                     
                        break;

                    case 'c' or 'C':
                        Console.WriteLine("Reset and turn off");
                        machineMemento.Restore();
                        break;

                    case 'x' or 'X':
                        Console.WriteLine("Exiting program");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("That is not a valid choice");
                        break;
                }
            }
        }
    }
}