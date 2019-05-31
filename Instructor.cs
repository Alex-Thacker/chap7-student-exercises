using System;
using System.Collections.Generic;

namespace student_exercises {
    public class Instructor {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SlackHandle { get; set; }
        public Cohort Cohort { get; set; }
        public string Specialty { get; set; }
        public void Assign (Student variable, Exercise exercise, Exercise exercise1) {
            variable.Exercises.Add(exercise);
            variable.Exercises.Add(exercise1);
        }

    }
}

// First name
// Last name
// Slack handle
// The instructor's cohort
// The instructor's specialty (e.g. jokes, snack cakes, dancing, etc.)
// A method to assign an exercise to a student