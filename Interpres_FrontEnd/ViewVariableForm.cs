using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Interpres_FrontEnd
{
    public partial class ViewVariableForm : Form
    {
        bool cancelled;
        object variable;

        public ViewVariableForm(object variable)
        {
            InitializeComponent();
            this.variable = variable;

            inputBox.Text = variable.ToString();
        }

        public object GetValue()
        {
            if (cancelled) return variable;
            return MainForm.singleton.executor.Execute(MainForm.singleton.FocusedWorkspace, inputBox.Text);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            cancelled = true;
            this.Close();
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
