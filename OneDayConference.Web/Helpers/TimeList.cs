using System.Collections;
using System.Collections.Generic;

namespace OneDayConference.Web.Helpers
{
    public class TimeList
    {
        static readonly IList<string> times = new List<string>
            {
                {"8:00 AM"},
                {"9:00 AM"},
                {"10:00 AM"},
                {"11:00 AM"},
                {"1:00 PM"},
                {"2:00 PM"},
                {"3:00 PM"},
                {"4:00 PM"},
                {"5:00 PM"}
            };

        public static IEnumerable<string> Times
        {
            get { return times; }
        }
    }
}
