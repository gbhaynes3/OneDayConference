using System.Collections.Generic;

namespace OneDayConference.Web.Models
{
    public class Speaker: Attendee 
    {
        public ICollection<Session> Sessions { get; set; }
    }
}