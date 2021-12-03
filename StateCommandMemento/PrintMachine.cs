using Assignment2.StateCommandMemento.Command;
using Assignment2.StateCommandMemento.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.StateCommandMemento
{
    public class PrintMachine : IMachineState, IMachine
    {
        public IMachineState MachineState { get; set; }
        public List<MachineCommand> WordList { get; set; }

        public PrintMachine()
        {
            MachineState = new MachineOff();
            WordList = new List<MachineCommand>();
        }

     
        public void PowerSwitch()
        {
            MachineState.PowerSwitch();
            if (MachineState is MachineOff)
            {
                MachineState = new MachineOn();
            }
            else
            {
                MachineState = new MachineOff();          
            }
        }

        public void Print(string word)
        {
            Console.WriteLine("\nPrinting...");
            Console.WriteLine($"{word}");
        }

        public MachineMemento CreateMemento()
        {
            return new MachineMemento(this, WordList);
        }

    }
}
