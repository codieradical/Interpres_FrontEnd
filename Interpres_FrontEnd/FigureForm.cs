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

        //your function based on x,y
        //public double getValue(int x, int y)
        //{
        //    if (x >= 0 && x < values.Length)
        //    return values[x];
        //}

        //setting the values to the function
        public FunctionSeries GetFunction()
        {
            //int n = 100;
            FunctionSeries serie = new FunctionSeries();

            for (int x = 0; x < values.Length; x++)
            {
                DataPoint data = new DataPoint(x, values[x]);
                serie.Points.Add(data);
            }

            //for (int x = 0; x < 35; x++)
            //{
            //    for (int y = 0; y < 1400; y++)
            //    {
            //        //adding the points based x,y
            //        DataPoint data = new DataPoint(x, getValue(x, y));

            //        //adding the point to the serie
            //        serie.Points.Add(data);
            //    }
            //}
            //returning the serie
            return serie;
        }

        //setting all the parameters of the model
        public void graph()
        {
            PlotModel model = new PlotModel { Title = "MatPlot" };
            model.LegendPosition = LegendPosition.RightBottom;
            model.LegendPlacement = LegendPlacement.Outside;
            model.LegendOrientation = LegendOrientation.Horizontal;

            model.Series.Add(GetFunction());
            var Yaxis = new OxyPlot.Axes.LinearAxis();
            OxyPlot.Axes.LinearAxis XAxis = new OxyPlot.Axes.LinearAxis { Position = OxyPlot.Axes.AxisPosition.Bottom, Minimum = 0, Maximum = values.Length - 1 };
            //XAxis.Title = "X";
            //Yaxis.Title = "10 * x * x + 11 * x*y*y  + 12*x*y";
            model.Axes.Add(Yaxis);
            model.Axes.Add(XAxis);
            this.plotView1.Model = model;
        }

        //private void btnChart_Click(object sender, EventArgs e)
        //{
        //    // Helpful links
        //    //https://msdn.microsoft.com/en-us/library/dd489237.aspx
        //    //https://stackoverflow.com/questions/9641436/saving-higher-resolution-charts-without-messing-up-the-appearance?utm_medium=organic&utm_source=google_rich_qa&utm_campaign=google_rich_qa

        //    MyChart.Visible = true;
        //    MyChart.Palette = Charting.ChartColorPalette.Bright;

        //    Charting.Title chtTitle = new System.Windows.Forms.DataVisualization.Charting.Title();
        //    System.Drawing.Font chtFont = new System.Drawing.Font("Arial", 16);
        //    chtTitle.Font = chtFont;
        //    chtTitle.Text = "Polynomial Chart Example";
        //    MyChart.Titles.Add(chtTitle);

        //    // Create Series 
        //    MyChart.Series.Clear();
        //    MyChart.Series.Add("Polynomial");
        //    MyChart.Series["Polynomial"].ChartType = Charting.SeriesChartType.Line; ;

        //    // populate Series    
        //    for (int i = 9; i <= 91; i++)
        //    {
        //        double x = 0.1 * Convert.ToDouble(i);
        //        MyChart.Series["Polynomial"].Points.AddXY(x, Poly(x));
        //    }

        //    MyChart.Printing.Print(true);
        //    //MyChart.SaveImage(@"C:\users\peter\documents\poly.jpg", Charting.ChartImageFormat.Jpeg);
        //}

        //double Poly(double x)
        //{
        //    double y = 1.0;
        //    for (double c = 1.0; c < 10.0; c += 1.0) y = y * (x - c);
        //    return y;
        //}
    }
}
