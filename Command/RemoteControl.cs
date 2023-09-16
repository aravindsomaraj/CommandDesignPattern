using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class RemoteControl
    {
        private readonly ICommand[] _commands;

        public RemoteControl()
        {
            _commands = new ICommand[4];
        }

        public void SetCommand(int slot, ICommand command)
        {
            _commands[slot] = command;
        }

        public void PressButton(int slot)
        {
            _commands[slot]?.Execute();
        }
    }
}
