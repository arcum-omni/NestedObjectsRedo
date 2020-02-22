using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedObjectsRedo
{
    /// <summary>
    /// Represents a single university course
    /// </summary>
    public class Course
    {
        /// <summary>
        /// Unique course ID assigned to the course
        /// </summary>
        public int CourseID { get; set; }

        /// <summary>
        /// Title of the course,
        /// ie. Programming Fundamentals
        /// </summary>
        public string CourseTitle { get; set; }

        /// <summary>
        /// Text description of Course,
        /// HTML Elements should not be allowed.
        /// </summary>
        public string CourseDescription { get; set; }

        /// <summary>
        /// The number of credits earned for completing the course
        /// </summary>
        public byte CreditHours { get; set; }
    }
}
