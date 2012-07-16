using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace OneDayConference.Web.Models
{
    public class Session
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Topic is required")]
        public string Topic { get; set; }

        [Required(ErrorMessage = "Start time is required")]
        [Display(Name="Start Time")]
        [UIHint("TimeDropDownList")]
        [MaxLength(50, "Can not be longer than 50")]
        public string StartTime { get; set; }

        public virtual Speaker Speaker { get; set; }
    }
}