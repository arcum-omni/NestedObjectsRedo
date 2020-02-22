﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedObjectsRedo
{
    /// <summary>
    /// Represents an individual student
    /// </summary>
    public class Student
    {
        /// <summary>
        /// Unique identifier for students,
        /// generated by the DB.
        /// </summary>
        public int StudentID { get; set; }

        /// <summary>
        /// First and Last name of the student; ie John Doe.
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// Date student was born, time is ignored.
        /// </summary>
        [DataType(DataType.Date)]
        public DateTime? DateOfBirth { get; set; }
    }
}