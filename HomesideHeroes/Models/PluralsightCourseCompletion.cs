using FileHelpers;
using HomesideHeroes.Models.Base;

namespace HomesideHeroes.Models
{
    [IgnoreFirst(1)]
    [DelimitedRecord(",")]
    public class PluralsightCourseCompletion : GenericFilterablePluralsightEntity<PluralsightCourseCompletion>
    {
        public PluralsightCourseCompletion()
            : base("course-completion/") { }

        public string UserId;
        public string FirstName;
        public string LastName;
        public string Email;
        public string TeamName;
        public string Note;
        public string IsOnAccount;
        public string CourseId;

        [FieldQuoted('"', QuoteMode.OptionalForBoth, MultilineMode.AllowForBoth)]
        public string CourseName;

        public string FirstViewDate;
        public string CompletionDate;
        public string CompletionStatus;
    }
}