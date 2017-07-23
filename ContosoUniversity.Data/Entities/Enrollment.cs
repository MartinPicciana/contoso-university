﻿using ContosoUniversity.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.Data.Entities
{
    public class Enrollment : BaseEntity
    {
        public long CourseID { get; set; }
        public long StudentID { get; set; }

        [DisplayFormat(NullDisplayText = "No Grade")]
        public Grade? Grade { get; set; }
        public Course Course { get; set; }
        public Student Student { get; set; }
    }
}
