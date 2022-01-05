using Domain.Entities;
using Services.Sessions.Entities.UI;
using SessionCollector.Views;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SessionCollector.Forms
{
	public partial class StataForm : Form, IStataView
	{
        public StataForm()
		{
			InitializeComponent();
		}

		public void Go(IEnumerable<ChartItem> lst, string title)
		{
            _render(lst, title);
            BindingSource bs = new BindingSource();
            bs.DataSource = lst;
            dataGridView1.DataSource = bs;
            this.ShowDialog();
		}

		public void SetData(IEnumerable<OSession> lst)
		{
			throw new NotImplementedException();
		}


        //==================================================================

        private void _render(IEnumerable<ChartItem> points, string title)
        {
            chart1.Series.Clear();
            chart1.Titles.Clear();

            // Resolves a problem of displaying charts of other collection when we can not see a chart.
            chart1.ChartAreas[0].RecalculateAxesScale();

            // Set palette
            //this.chart1.Palette = ChartColorPalette.Berry;

            // Set title
            //chart1.Titles.Add($"{title}; Total time: {TimeSpan.FromSeconds(points.Sum(x=>x.Seconds)).ToString(@"hh\:mm")}");

            var total_time = TimeSpan.FromSeconds(points.Sum(x => x.Seconds));
            chart1.Titles.Add($"{title}; Total time: {(int)total_time.TotalHours}:{total_time.Minutes}");

            _CurrentDataPoint.OriginalColor = chart1.PaletteCustomColors[0];

            Series series = this.chart1.Series.Add("oOo");
            series.ChartType = SeriesChartType.Column;

            chart1.ChartAreas[0].AxisX.IntervalAutoMode = IntervalAutoMode.VariableCount;
 
            // Add series.
            foreach (var item in points)
            {
                series.Points.AddXY(item.DayOfMonth, item.Time.TotalMinutes);
            }
        }

		private void chart1_MouseDown(object sender, MouseEventArgs e)
		{
            HitTestResult result = chart1.HitTest(e.X, e.Y);

            if (result.ChartElementType == ChartElementType.DataPoint)
            {
                _CurrentDataPoint.SetHighlightedPonit(chart1.Series[0].Points[result.PointIndex]);
            }
			else
			{
                _CurrentDataPoint.Reset();
            }
        }

        CurrentDataPoint _CurrentDataPoint = new CurrentDataPoint();

        class CurrentDataPoint
		{
            public Color OriginalColor { get; set; }

            readonly Color highlightedColor = Color.Yellow;

            DataPoint highlightedPoint = null;

			public void SetHighlightedPonit(DataPoint p)
			{
                //p.Tag = объект коллекциия, можно показать, какой объект выбран;
                // Переделать, передавать сюда коллекции сессий выбранной директории.
                // чтобы можно было посмореть день.

                Reset();

                highlightedPoint = p;
				highlightedPoint.Color = highlightedColor;
            }

			public void Reset()
			{
                if (highlightedPoint == null) return;

                highlightedPoint.Color = OriginalColor;
				highlightedPoint = null;
            }
		}
	}
}
