using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Student
    {
        public int ID { get; set; }

        
        
        // maximum length = 50. Make sure users dont enter more than 50 characters.
        [StringLength(50, MinimumLength = 1)]
        [Display(Name = "Last Name")] //  change the display for text box to Last Name with space 
        public string LastName { get; set; }

        [Required] // make the property a required field
        // maximum length = 50. Make sure users dont enter more than 50 characters.
        [StringLength(50)]
        // The property FirstName is mapped to FirstName column in Student table. 
        [Column("FirstName")]
        [Display(Name = "First Name")] //  change the display for text box to First Name with space 
        public string FirstName { get; set; }

        [Required] // make the property a required field
        [StringLength(50)]
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }

        [Required] // make the property a required field
        [StringLength(10)]
        [Display(Name = "Year Rank")]
        public string YearRank { get; set; }

        // make sure users input grade from 0.0 to 4.0. Nothing more 4.0 or less than 0.0
        [Range(0,4)]
        [Display(Name = "GPA")]
        public float AverageGrade { get; set; }

        // datatype attribute used to specify a datatype
        [DataType(DataType.Date)]
        // Format the date to yyyy-MM-dd (year-month-day)
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Enrollment  Date")]
        public DateTime EnrollmentDate { get; set; }

        // return full name using 2 other properties
        // no column added to database. For view only
        public string FullName
        {
            get
            {
                return LastName + ", " + FirstName;
            }
        }

         
              

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
