using System;
using System.Collections.Generic;

namespace student_exercises{
    public class Student {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SlackHandle { get; set; }
        public Cohort Cohort { get; set; }
        public List <Exercise> Exercises { get; set; } = new List<Exercise> ();
    }
}

// First name
// Last name
// Slack handle
// The student's cohort
// The collection of exercises that the student is currently working on