using Assignment2.StateCommandMemento.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.StateCommandMemento.Command
{
    public class CommandManager
    {
        public PrintMachine Printer { get; set; }
        public CommandManager(PrintMachine printer)
        {
            Printer = printer;
        }


        public void Execute(string userWord) // off
        {
            var word = new MachineCommand(Printer, userWord);

            if (Printer.MachineState is MachineOff)
            {
                Printer.WordList.Add(word);
                Console.WriteLine("\nPrinter is off... Saving word until printer is on.");
            }
            else
            {
                word.Execute();
            }
}
    }
}
