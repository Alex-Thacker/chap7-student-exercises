using System;
using System.Collections.Generic;

namespace student_exercises{
    public class Cohort {
        public string Name { get; set; }
        public List <Student> Students { get; set; } = new List<Student>();
        public Instructor Instructor { get; set; } 

    }
}

// The cohort's name (Evening Cohort 6, Day Cohort 25, etc.)
// The collection of students in the cohort.
// The collection of instructors in the cohort.