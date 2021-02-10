using OxyPlot;
using OxyPlot.Series;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Interpres_FrontEnd
{
    public partial class FigureForm : Form
    {
        private readonly double[] values;
        public FigureForm(double[] values)
        {
            this.values = values;
            InitializeComponent();
            graph();
        }

        public FunctionSeries GetFunction()
        {
            FunctionSeries series = new FunctionSeries();

            for (int x = 0; x < values.Length; x++)
            {
                DataPoint data = new DataPoint(x, values[x]);
                series.Points.Add(data);
            }

            return series;
        }

        public void graph()
        {
            PlotModel model = new PlotModel { Title = "MatPlot" };
            model.LegendPosition = LegendPosition.RightBottom;
            model.LegendPlacement = LegendPlacement.Outside;
            model.LegendOrientation = LegendOrientation.Horizontal;

            model.Series.Add(GetFunction());
            var Yaxis = new OxyPlot.Axes.LinearAxis();
            OxyPlot.Axes.LinearAxis XAxis = new OxyPlot.Axes.LinearAxis { Position = OxyPlot.Axes.AxisPosition.Bottom, Minimum = 0, Maximum = values.Length - 1 };
            model.Axes.Add(Yaxis);
            model.Axes.Add(XAxis);
            this.plotView1.Model = model;
        }
    }
}
