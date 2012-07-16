using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace OneDayConference.Web.Models
{
    [Bind(Include = "Id, Name, IsAttending")]
    public partial class Attendee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsAttending { get; set; }
    }
}