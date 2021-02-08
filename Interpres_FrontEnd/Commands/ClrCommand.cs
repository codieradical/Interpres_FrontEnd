using System;
using System.Collections.Generic;
using System.Text;
using Interpreter.IO;
using Interpreter.Tokens.commands;

namespace Interpres_FrontEnd.Commands
{
    class ClrCommand : Command
    {
        public override object Execute(object[] args, Workspace workspace)
        {
            try
            {
                workspace.commandLog = new LinkedList<string>();
                Interpres.MainForm.singleton.UpdateScrollback();
                Console.Clear();
                return "Success";
            }
            catch (Exception e)
            {
                return "Screen Cleared";

            }
        }

        public override string GetInputString()
        {
            return "clr";
        }
    }
}
