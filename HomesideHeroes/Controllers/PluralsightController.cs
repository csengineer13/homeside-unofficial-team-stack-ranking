using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using HomesideHeroes.Controllers.Base;
using HomesideHeroes.Models;
using HomesideHeroes.Models.Utils;
using HomesideHeroes.Viewmodels;

namespace HomesideHeroes.Controllers
{
    /// <summary>
    /// Documentation for endpoints found here:
    /// - https://app.pluralsight.com/plans/api/reports/docs
    /// - https://www.pluralsight.com/content/dam/pluralsight/pdfs/integration/2107_OneSheet_PluralsightLMSIntegration.pdf
    /// </summary>
    public class PluralsightController : BaseApiController
    {
        // GET api/values
        public CourseUsageOverMonth Get()
        {
            var users = new PluralsightUsers().GetAllRemote();
            var courseUsage = new PluralsightCourseUsage().GetAllBetweenDates(DateTime.Today.FirstDayOfMonth(), DateTime.Today.LastDayOfMonth());
            var courseCompletion = new PluralsightCourseCompletion().GetAllRemote();

            var vm = Mapper.Map<CourseUsageOverMonth>(courseUsage.ToList());

            // Data points: (day in month #, Total # of hours for month so far at EOD)
            // y-axis; number of hours
            // x-axis; number day in month

            return vm;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }

    }
}
