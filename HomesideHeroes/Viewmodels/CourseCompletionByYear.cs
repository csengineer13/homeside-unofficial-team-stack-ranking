using System;
using System.Collections.Generic;

namespace HomesideHeroes.Viewmodels
{
    public class CourseCompletionByYear
    {
        public CourseCompletionByYear()
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
}