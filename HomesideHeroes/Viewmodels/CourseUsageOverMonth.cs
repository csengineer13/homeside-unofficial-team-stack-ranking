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
            borderWidth = 3;
        }

        public string label { get; set; }
        public bool fill { get; set; }

        public string backgroundColor { get; set; }
        public string borderColor => backgroundColor;
        public int borderWidth { get; set; }
        public List<int> data { get; set; } // Our y-axis ;)
    }
}