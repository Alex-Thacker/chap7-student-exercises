using System;
using System.Collections.Generic;

namespace student_exercises{
    public class Student : NSSPerson {
        public List <Exercise> Exercises { get; set; } = new List<Exercise> ();
    }
}

// First name
// Last name
// Slack handle
// The student's cohort
// The collection of exercises that the student is currently working on