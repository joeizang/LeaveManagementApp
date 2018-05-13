using System;
using System.ComponentModel.DataAnnotations;

namespace LeaveManagementApp.Models
{
    public class Leave
    {
        [Key]
        public string LeaveId { get; set; }

        [Required]
        [StringLength(50)]
        public string EndorsedBy { get; set; }

        [Required]
        [StringLength(40)]
        public string ApprovedBy { get; set; }

        [DataType(DataType.DateTime)]
        [Required]
        public DateTime DateAppliedForLeave { get; set; }

        public bool PersonnelCover { get; set; } = false;

        public bool Approved { get; set; }

        public string LeavePurposeDescription { get; set; }

        public LeavePurpose LeavePurpose { get; set; }

        public ApplicationUser Staff { get; set; }

        public string StaffId { get; set; }

        public LeaveType LeaveType { get; set; }

        public string LeaveTypeId { get; set; }
    }
}