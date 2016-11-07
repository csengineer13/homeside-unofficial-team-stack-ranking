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
    [RoutePrefix("api/pluralsight")]
    public class PluralsightController : BaseApiController
    {
        [HttpGet]
        [Route("individual/course-usage/current-month")]
        public CourseUsageByMonth Get()
        {
            var courseUsage = new PluralsightCourseUsage().GetAllBetweenDates(DateTime.Today.FirstDayOfMonth(), DateTime.Today.LastDayOfMonth());
            var vm = Mapper.Map<CourseUsageByMonth>(courseUsage.ToList());

            return vm;
        }

        [HttpGet]
        [Route("all/course-completion/recently-completed")]
        public IEnumerable<CourseCompletionRecentlyCompleted> GetRecentlyCompletedCourses()
        {

            var courseCompletion = new PluralsightCourseCompletion().GetAllBetweenDates(DateTime.Today.FirstDayOfYear(), DateTime.Today.LastDayOfYear());
            var result = Mapper.Map<List<CourseCompletionRecentlyCompleted>>(courseCompletion.ToList())
                        .OrderBy(cc => DateTime.Parse(cc.EndDate))
                        .Take(5).ToList();


            return result;
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
