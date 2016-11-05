using System.Collections.Generic;
using System.Configuration;
using System.Net;
using FileHelpers;

namespace HomesideHeroes.Models.Base
{
    public class BasePlurlasightEntity
    {
        protected static readonly string PlanId = ConfigurationManager.AppSettings["PluralsightPlanId"];
        protected static readonly string ApiToken = ConfigurationManager.AppSettings["PluralsightApiToken"];
        protected static readonly string BaseUrl = ConfigurationManager.AppSettings["PluralsightBaseUrl"];

        protected static string ApiResource { get; set; }
    }
}