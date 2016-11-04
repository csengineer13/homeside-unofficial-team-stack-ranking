using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FileHelpers;
using HomesideHeroes.Models;

namespace HomesideHeroes.Controllers
{
    /// <summary>
    /// SUPER TIGHTLY COUPLED PLURALSIGHT CONTROLLER!!!!
    /// </summary>
    public class PluralsightController : ApiController
    {
        private static string BaseUrl = "https://app.pluralsight.com/plans/api/reports/v1/";
        private static string PlanId = "homeside-financial-e8c8a";
        private static string ApiToken = "72dff25d-a736-420c-b4ff-ebbb0d932533";

        // GET api/values
        public PluralsightUsers[] Get()
        {
            //var someReturn = SplitCSV("https://app.pluralsight.com/plans/api/reports/v1/course-usage/" + PlanId + "?token=" + ApiToken);

            var data = GetCSV(BaseUrl + "users/" + PlanId + "?token=" + ApiToken);

            var engine = new FileHelperEngine<PluralsightUsers>();
            var users = engine.ReadString(data);

            return users;
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

        private static string GetCSV(string url)
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();

            StreamReader sr = new StreamReader(resp.GetResponseStream());
            string results = sr.ReadToEnd();
            sr.Close();

            return results;
        }

        private static List<string> SplitCSV(string url)
        {
            List<string> splitted = new List<string>();
            string fileList = GetCSV(url);
            string[] tempStr;

            tempStr = fileList.Split(',');

            foreach (string item in tempStr)
            {
                if (!string.IsNullOrWhiteSpace(item))
                {
                    splitted.Add(item);
                }
            }

            return splitted;
        }
    }
}
