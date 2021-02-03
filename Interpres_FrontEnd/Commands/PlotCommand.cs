using System;
using System.Collections.Generic;
using System.Text;
using Interpreter.IO;
using Interpreter.Tokens.commands;

namespace Interpres_FrontEnd.Commands
{
    class PlotCommand : Command
    {
        public override object Execute(object[] args, Workspace workspace)
        {
            new FigureForm().Show();
            throw new NotImplementedException();
        }

        public override string GetInputString()
        {
            return "plot";
        }
    }
}
