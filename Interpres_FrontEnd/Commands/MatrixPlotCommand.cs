using System;
using System.Collections.Generic;
using System.Text;
using Interpreter.IO;
using Interpreter.Tokens.commands;
using Interpreter.Extensions;

namespace Interpres_FrontEnd.Commands
{
    class MatrixPlotCommand : Command
    {
        public override object Execute(object[] args, Workspace workspace)
        {
            if (args.Length == 1 && args[0].IsArray())
            {
                object[] argVals = (object[])args[0];
                double[] plotVals = new double[argVals.Length];
                for (int i = 0; i < plotVals.Length; i++)
                {
                    if (argVals[i].IsNumeric())
                        plotVals[i] = Convert.ToDouble(argVals[i]);
                    else
                        throw new ArgumentException("Cannot plot a non numeric value.");
                }
                new FigureForm(plotVals).Show();
            }
            throw new ArgumentException("Argument is non numeric.");
        }

        public override string GetInputString()
        {
            return "matplot";
        }
    }
}
