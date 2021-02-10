using Interpreter.IO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interpres_FrontEnd
{
    public interface IExecutor
    {
        public object Execute(Workspace workspace, string input);
    }
}
