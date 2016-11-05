using System.Collections.Generic;
using System.Net;
using FileHelpers;

namespace HomesideHeroes.Models.Base
{
    public abstract class GenericPluralsightEntity<TPluralsightEntity> : BasePlurlasightEntity
        where TPluralsightEntity : class, new()
    {
        protected GenericPluralsightEntity(string apiResource)
        {
            ApiResource = apiResource;
        }

        protected static string FullApiUrl => BaseUrl + ApiResource + PlanId + "?token=" + ApiToken;

        public ICollection<TPluralsightEntity> GetAllRemote()
        {
            var data = GetCsv(FullApiUrl);
            var engine = new FileHelperEngine<TPluralsightEntity>();
            //engine.ErrorManager.ErrorMode = ErrorMode.IgnoreAndContinue;
            var listPluralsightEntities = engine.ReadString(data);
            return listPluralsightEntities;
        }

        protected static string GetCsv(string url)
        {
            WebClient csvWebClient = new WebClient();
            return csvWebClient.DownloadString(url);
        }
    }
}