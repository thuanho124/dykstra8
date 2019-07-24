using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Instructor
    {
        public int ID { get; set; }

        [Required] // make the property a required field
        [Display(Name = "Last Name")] //  change the display for text box to Last Name with space 
        [StringLength(50)]
        public string LastName { get; set; }

        [Required] // make the property a required field
        [Column("FirstName")]
        [Display(Name = "First Name")] //  change the display for text box to First Name with space 
        [StringLength(50)]
        public string FirstMidName { get; set; }

        // datatype attribute used to specify a data type to a specific property
        [DataType(DataType.Date), Display(Name = "Hire Date"), DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime HireDate { get; set; }

        // return full name using 2 other properties
        // no column added to database. For view only
        [Display(Name = "Full Name")]
        public string FullName
        {
            get { return LastName + ", " + FirstMidName; }
        }

        // navigation property CourseAssignments entites related to Instructor entity
        public ICollection<CourseAssignment> CourseAssignments { get; set; }

        // navigation property that only holds a single entity
        public OfficeAssignment OfficeAssignment { get; set; }
    }
}