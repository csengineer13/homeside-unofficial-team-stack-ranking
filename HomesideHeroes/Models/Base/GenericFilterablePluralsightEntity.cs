using System;
using System.Collections.Generic;
using FileHelpers;
using HomesideHeroes.Models.Utils;

namespace HomesideHeroes.Models.Base
{
    public abstract class GenericFilterablePluralsightEntity<TPluralsightEntity> :
        GenericPluralsightEntity<TPluralsightEntity>
        where TPluralsightEntity : class, new()
    {
        protected GenericFilterablePluralsightEntity(string apiResource)
            : base(apiResource) { }

        //
        [FieldHidden]
        private string _filterStartDate;
        protected string FilterStartDate
        {
            get { return _filterStartDate; }
            private set { _filterStartDate = value; }
        }

        [FieldHidden]
        private string _filterEndDate;
        protected string FilterEndDate
        {
            get { return _filterEndDate; }
            private set { _filterEndDate = value; }
        }


        private void SetFilterStartDate(DateTime startDate)
        {
            this.FilterStartDate = startDate.ToPluralsightDateTime();
        }
        private void SetFilterEndDate(DateTime endDate)
        {
            this.FilterEndDate = endDate.ToPluralsightDateTime();
        }

        //
        private new string FullApiUrl()
        {
            var relativeBaseUrl = BaseUrl + ApiResource + PlanId + "?token=" + ApiToken;

            if (!string.IsNullOrEmpty(this.FilterStartDate))
            {
                relativeBaseUrl += "&startDate=" + this.FilterStartDate;
            }
            if (!string.IsNullOrEmpty(this.FilterEndDate))
            {
                relativeBaseUrl += "&endDate=" + this.FilterEndDate;
            }

            return relativeBaseUrl;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="startDate"></param>
        /// <returns></returns>
        public ICollection<TPluralsightEntity> GetAllAfterStartDate(DateTime startDate)
        {
            this.SetFilterStartDate(startDate);

            var engine = new FileHelperEngine<TPluralsightEntity>();
            var listPluralsightEntities = engine.ReadString(GetCsv(FullApiUrl()));

            return listPluralsightEntities;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="endDate"></param>
        /// <returns></returns>
        public ICollection<TPluralsightEntity> GetAllBeforeEndDate(DateTime endDate)
        {
            this.SetFilterEndDate(endDate);

            var engine = new FileHelperEngine<TPluralsightEntity>();
            var listPluralsightEntities = engine.ReadString(GetCsv(FullApiUrl()));

            return listPluralsightEntities;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <returns></returns>
        public ICollection<TPluralsightEntity> GetAllBetweenDates(DateTime startDate, DateTime endDate)
        {
            this.SetFilterStartDate(startDate);
            this.SetFilterEndDate(endDate);

            var engine = new FileHelperEngine<TPluralsightEntity>();
            var listPluralsightEntities = engine.ReadString(GetCsv(FullApiUrl()));

            return listPluralsightEntities;
        }
    }
}