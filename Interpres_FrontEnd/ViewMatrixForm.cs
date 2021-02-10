using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Interpres_FrontEnd
{
    public partial class ViewMatrixForm : Form
    {
        public ViewMatrixForm(object[][] matrix, string name)
        {
            this.Text = "View Matrix: " + name;

            InitializeComponent();

            int height = matrix.GetLength(0);
            int width = matrix[0].GetLength(0);

            this.dataGridView1.ColumnCount = width;

            for (int r = 0; r < height; r++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(this.dataGridView1);

                for (int c = 0; c < width; c++)
                {
                    row.Cells[c].Value = matrix[r][c];
                }

                this.dataGridView1.Rows.Add(row);
            }
        }

        public ViewMatrixForm(object[] matrix, string name)
        {
            this.Text = "View Matrix: " + name;

            InitializeComponent();

            int width = matrix.GetLength(0);

            this.dataGridView1.ColumnCount = width;
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(this.dataGridView1);

            for (int r = 0; r < width; r++)
            {
                row.Cells[r].Value = matrix[r];
            }

            this.dataGridView1.Rows.Add(row);
        }

        public object[] GetValue1D()
        {
            object[] col = new object[dataGridView1.Rows[0].Cells.Count];
            foreach (DataGridViewCell j in dataGridView1.Rows[0].Cells)
            {
                col[j.ColumnIndex] = j.Value;
            }

            return col;
        }

        public object[][] GetValue2D()
        {
            object[][] rows = new object[dataGridView1.RowCount - 1][];
            foreach (DataGridViewRow i in dataGridView1.Rows)
            {
                object[] col = new object[i.Cells.Count];
                if (i.IsNewRow) continue;
                foreach (DataGridViewCell j in i.Cells)
                {
                    col[j.ColumnIndex] = j.Value;
                }
                rows[i.Index] = col;
            }
            return rows;
        }
    }
}
