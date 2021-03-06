using System;
using System.Linq;
using System.Text;

namespace FreeContent
{
    public interface ICommand
    {
        comt Type { get; set; }

        string OriginalForm { get; set; }

        string Name { get; set; }

        string[] Parameters { get; set; }

        comt ParseCommandType(string commandName);

        string ParseName();

        string[] ParseParameters();
    }
}
