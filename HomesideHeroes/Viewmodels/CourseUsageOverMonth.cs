using System;
using System.Collections.Generic;

namespace HomesideHeroes.Viewmodels
{
    public class CourseUsageOverMonth
    {
        public CourseUsageOverMonth()
        {
            labels = new List<string>();
            datasets = new List<DataSet>();
        }

        private DateTime TargetMonth { get; set; }
        private int NumberOfDaysInMonth { get; set; }

        // Chart.JS line chart
        // Our x-axis
        public List<string> labels { get; set; }
        public List<DataSet> datasets { get; set; }
    }

    public class DataSet
    {
        public DataSet()
        {
            //borderCapStyle = "butt";
            //borderJoinStyle = "miter";
            //pointBorderWidth = 1;
            //pointHoverRadius = 5;
            //pointHoverBorderWidth = 2;
            //pointRadius = 1;
            //pointHitRadius = 10;
        }

        public string label { get; set; }
        //public bool fill { get; set; }

        //public double lineTension { get; set; } // Curve of line
        public string backgroundColor { get; set; }
        //public string borderColor { get; set; }
        //public string borderCapStyle { get; set; }
        //public int[] borderDash { get; set; } // Length and spacing of dashes
        //public double borderDashOffset { get; set; } // Offset for line dashes
        //public string borderJoinStyle { get; set; }
        //public string pointBorderColor { get; set; }
        //public string pointBAckgroundColor { get; set; }
        //public int pointBorderWidth { get; set; }
        //public int pointHoverRadius { get; set; }
        //public string pointHoverBackgroundColor { get; set; }
        //public string pointHoverBorderColor { get; set; }
        //public int pointHoverBorderWidth { get; set; }
        //public int pointRadius { get; set; }
        //public int pointHitRadius { get; set; }
        public List<int> data { get; set; } // Our y-axis ;)
        //public bool spanGaps { get; set; }
    }
}