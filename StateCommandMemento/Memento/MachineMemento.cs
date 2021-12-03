using Assignment2.StateCommandMemento.Command;
using Assignment2.StateCommandMemento.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.StateCommandMemento
{
    public class MachineMemento
    {
        public PrintMachine Printer { get; set; }
        public List<MachineCommand> WordList { get; set; }

        public MachineMemento(PrintMachine printer, List<MachineCommand> wordList)
        {
            Printer = printer;
            WordList = wordList;
        }


        public void Restore()
        {
            Console.WriteLine("Reseting list and turning off...");
            Printer.WordList.Clear();
            Printer.MachineState = new MachineOff();
           
        }

       
    }
}
