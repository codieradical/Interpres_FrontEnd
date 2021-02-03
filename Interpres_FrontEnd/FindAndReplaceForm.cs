using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Interpres
{
    public partial class FindAndReplaceForm : Form
    {
        public string Find
        {
            get { return findBox.Text; }
            private set { findBox.Text = value; }
        }
        public string Replace
        {
            get { return replaceBox.Text; }
            private set { replaceBox.Text = value; }
        }

        private bool replacing = false;

        public FindAndReplaceForm()
        {
            replacing = false;
            InitializeComponent();
        }

        private void ReplaceAllButton_Click(object sender, EventArgs e)
        {
            replacing = true;
            this.Close();
        }

        private void FindAndReplaceForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!replacing)
            {
                Find = "";
                Replace = "";
            }
        }
    }
}
