using FileHelpers;
using HomesideHeroes.Models.Base;

namespace HomesideHeroes.Models
{
    // http://www.filehelpers.net/example/QuickStart/ReadFileDelimited/
    [IgnoreFirst(1)]
    [DelimitedRecord(",")]
    public class PluralsightUsers : GenericPluralsightEntity<PluralsightUsers>
    {
        public PluralsightUsers()
            : base("users/"){ }

        public string UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string TeamName { get; set; }
        public string Note { get; set; }
        public string StartDate { get; set; }
    }
}