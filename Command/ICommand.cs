using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    /// <summary>
    /// Represents a command interface that defines an operation to be executed.
    /// </summary>
    public interface ICommand
    {

        /// <summary>
        /// Executes the command operation.
        /// </summary>
        void Execute();
    }
}
