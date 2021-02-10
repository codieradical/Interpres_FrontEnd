using Interpres_FrontEnd.Commands;
using Interpreter;
using Interpreter.IO;
using Interpreter.Tokenizers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interpres_FrontEnd
{
    class InterpresExecutor : IExecutor
    {
        private readonly TokenizerService tokenizerService;
        public InterpresExecutor()
        {
            CommandTokenizer commandTokenizer = new CommandTokenizer();
            commandTokenizer.RegisterCommand(new MatrixPlotCommand());
            commandTokenizer.RegisterCommand(new ClrCommand());
            tokenizerService = new TokenizerService(commandTokenizer);
        }

        public object Execute(Workspace workspace, string input)
        {
            var tokens = tokenizerService.GetTokens(input);
            return new AbstractSyntaxTree(tokens.Select(token => (object)token).ToList(), workspace)?.GetValue();
        }
    }
}
