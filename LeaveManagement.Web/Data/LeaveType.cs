using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.Web.Data
{
    public class LeaveType : BaseEntity
    {
        [Display(Name = "Leave Type Name")]
        public string Name { get; set; }

        [Display(Name = "Default Number of Days")]
        public int DefaultDays { get; set; }
    }
}
