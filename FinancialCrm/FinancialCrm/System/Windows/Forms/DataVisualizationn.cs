

namespace System.Windows.Forms
{
    internal class DataVisualization
    {
        internal class Charting
        {
            internal class ChartArea
            {
                public ChartArea()
                {
                }

                public string Name { get; internal set; }
            }

            internal class Legend
            {
                public string Name { get; internal set; }
            }

            internal class Series
            {
                public string ChartArea { get; internal set; }
                public string Legend { get; internal set; }
                public string Name { get; internal set; }
            }

            internal class Chart
            {
                public object ChartAreas { get; internal set; }
                public object Legends { get; internal set; }
                public Drawing.Point Location { get; internal set; }
                public string Name { get; internal set; }
                public object Series { get; internal set; }
                public Drawing.Size Size { get; internal set; }
                public int TabIndex { get; internal set; }
                public string Text { get; internal set; }
            }
        }
    }
}