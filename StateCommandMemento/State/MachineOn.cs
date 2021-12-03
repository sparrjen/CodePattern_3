using Assignment2.StateCommandMemento.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.StateCommandMemento.State
{
    public class MachineOn : IMachineState
    {
        public void PowerSwitch()
        {
            Console.WriteLine("Turning off.....\n");
        }
    }
}
