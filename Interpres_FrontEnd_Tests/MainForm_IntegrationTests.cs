using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Interpres_FrontEnd;
using Moq;
using Interpreter.IO;

namespace Interpres_IntegrationTests
{
    [TestClass]
    public class MainForm_IntegrationTests
    {
        [TestMethod]
        public void MainForm_CanExecuteCommandTest()
        {
            // Arrange
            string command = "test = 1 + 1";
            var mockExecutor = new Mock<IExecutor>();
            mockExecutor.Setup(mock => mock.Execute(It.IsAny<Workspace>(), command)).Returns(2);
            MainForm mainForm = new MainForm((IExecutor)mockExecutor);
            mainForm.ExecuteCommand(command);
            Assert.AreEqual(mainForm.FocusedWorkspace.commandLog.First, "2");
        }
    }
}
