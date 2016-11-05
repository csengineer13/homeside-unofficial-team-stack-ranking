using System;
using System.Collections.Generic;

namespace HomesideHeroes.Viewmodels
{
    public class CourseUsageOverMonth
    {
        public CourseUsageOverMonth()
        {
            Labels = new List<string>();
            DataSets = new List<DataSet>();
        }

        private DateTime TargetMonth { get; set; }
        private int NumberOfDaysInMonth { get; set; }

        // Chart.JS line chart
        // Our x-axis
        public List<string> Labels { get; set; }
        public List<DataSet> DataSets { get; set; }
    }

    public class DataSet
    {
        public DataSet()
        {
            BorderCapStyle = "butt";
            BorderJoinStyle = "miter";
            PointBorderWidth = 1;
            PointHoverRadius = 5;
            PointHoverBorderWidth = 2;
            PointRadius = 1;
            PointHitRadius = 10;
        }

        public string Label { get; set; }
        public bool Fill { get; set; }
        public double LineTension { get; set; } // Curve of line
        public string BackgroundColor { get; set; }
        public string BorderColor { get; set; }
        public string BorderCapStyle { get; set; }
        public int[] BorderDash { get; set; } // Length and spacing of dashes
        public double BorderDashOffset { get; set; } // Offset for line dashes
        public string BorderJoinStyle { get; set; }
        public string PointBorderColor { get; set; }
        public string PointBAckgroundColor { get; set; }
        public int PointBorderWidth { get; set; }
        public int PointHoverRadius { get; set; }
        public string PointHoverBackgroundColor { get; set; }
        public string PointHoverBorderColor { get; set; }
        public int PointHoverBorderWidth { get; set; }
        public int PointRadius { get; set; }
        public int PointHitRadius { get; set; }
        public List<int> Data { get; set; } // Our y-axis ;)
        public bool SpanGaps { get; set; }
    }
}