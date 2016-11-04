using FileHelpers;

namespace HomesideHeroes.Models
{
    // http://www.filehelpers.net/example/QuickStart/ReadFileDelimited/
    [IgnoreFirst]
    [DelimitedRecord(",")]
    public class PluralsightUsers
    {
        public string UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TeamName { get; set; }
        public string Note { get; set; }
        public string StartDate { get; set; }
    }
}