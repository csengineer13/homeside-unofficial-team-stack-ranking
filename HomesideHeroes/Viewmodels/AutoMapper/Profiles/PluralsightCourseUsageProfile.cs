using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using HomesideHeroes.Models;
using HomesideHeroes.Models.Utils;

namespace HomesideHeroes.Viewmodels.AutoMapper.Profiles
{
    public class PluralsightCourseUsageProfile : Profile
    {
        public PluralsightCourseUsageProfile()
        {
            CreateMap<List<PluralsightCourseUsage>, CourseUsageByMonth>()
                .AfterMap((src, dest) => dest.labels = ResolveLabels())
                .AfterMap((src, dest) => dest.datasets.AddRange(ResolveDataSets(src, dest.labels)))
                ;


            CreateMap<List<PluralsightCourseUsage>, DataSet>()

                ;
        }

        private static List<DataSet> ResolveDataSets(List<PluralsightCourseUsage> courseUsage, List<string> labels)
        {
            var groupedCourseUsage = courseUsage
                             .GroupBy(x => x.UserId)
                             .ToDictionary(gcu => gcu.Key, gcu => gcu.ToList());

            var lookupCourseUsage = courseUsage
                            .ToLookup(x => x.UserId);

            var response = new List<DataSet>();
            var colorIndex = 0;
            var bgColors = new List<string>
            {
                "rgba(204,0,0,1)",
                "rgba(255,136,0,1)",
                "rgba(153,51,204,1)",
                "rgba(119,179,0,1)",
                "rgba(42,159,214,1)"
            };
            foreach (KeyValuePair<string, List<PluralsightCourseUsage>> aUsersCourseUsage in groupedCourseUsage)
            {
                // Style Options
                var newDataSet = new DataSet()
                {
                    label = aUsersCourseUsage.Value.First().FirstName,
                    backgroundColor = bgColors[colorIndex]
                };

                // We have.. 
                var runningUsageTotal = 0;
                var dataPoints = new List<int>();
                foreach (string label in labels)
                {
                    foreach (PluralsightCourseUsage usage in aUsersCourseUsage.Value)
                    {
                        if (int.Parse(label) == int.Parse(usage.ViewDate.Substring(8)))
                        {
                            runningUsageTotal += int.Parse(usage.UsageInSeconds) / 60;
                        }
                    }

                    dataPoints.Add(runningUsageTotal);
                }

                newDataSet.data = dataPoints;
                response.Add(newDataSet);
                colorIndex++;
            }

            return response;
        }

        private static List<string> ResolveLabels()
        {
            var numDaysInMonth = DateTime.Today.DaysInMonth();
            var labels = new List<string>();
            for (var i = 1; i <= numDaysInMonth; i++)
            {
                labels.Add(i.ToString());
            }

            return labels;
        }

    }
}