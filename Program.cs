using System;
using System.Collections.Generic;
using System.Linq;

namespace student_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            /////////////////////////////////Exercies
           Exercise dogs = new Exercise();
           dogs.Name = "dogs";
           dogs.Language = "bark";

           Exercise cats = new Exercise();
           cats.Name = "cats";
           cats.Language = "JavaScript";

           Exercise fish = new Exercise();
           fish.Name = "fish";
           fish.Language = "bloop";

           Exercise hamster = new Exercise();
           hamster.Name = "hamster";
           hamster.Language = "JavaScript";

            ///////////////////////Cohorts, list student and instructor
           Cohort C29 = new Cohort();
           C29.Name = "C29";

           Cohort C30 = new Cohort();
           C30.Name = "C30";

           Cohort C31 = new Cohort();
           C31.Name = "C31 aka the cool kids, also known as the cool kids club";

            //////////////////////////////Students, add exercise list
           Student Bill = new Student();
           Bill.FirstName = "Bill";
           Bill.LastName = "Bob";
           Bill.SlackHandle = "BillBob";
           Bill.Cohort = C31;

           C31.Students.Add(Bill);

           Student Steve = new Student();
           Steve.FirstName = "Steve";
           Steve.LastName = "Stevie";
           Steve.SlackHandle = "SteveStevie";
           Steve.Cohort = C29;

           C29.Students.Add(Steve);

           Student Bo = new Student();
           Bo.FirstName = "Bo";
           Bo.LastName = "Body";
           Bo.SlackHandle = "BoBody";
           Bo.Cohort = C30;

           C30.Students.Add(Bo);

           Student Blue = new Student();
           Blue.FirstName = "Blue";
           Blue.LastName = "Yellow";
           Blue.SlackHandle = "BlueYellow";
           Blue.Cohort = C31;

           C31.Students.Add(Blue);

           Student NoExercise = new Student();
           Blue.FirstName = "blah";
           Blue.LastName = "blah";
           Blue.SlackHandle = "blah";
           Blue.Cohort = C31;

           C31.Students.Add(NoExercise);

           ///////////Instructors
           Instructor JDog = new Instructor () ;
           JDog.FirstName = "Jisie";
           JDog.LastName = "IDK";
           JDog.SlackHandle = "JDog";
           JDog.Cohort = C31;
           JDog.Specialty = "making bird noises";
           JDog.Assign(Bill, dogs, cats);
           JDog.Assign(Steve, dogs, cats);
           JDog.Assign(Bo, dogs, cats);
           JDog.Assign(Blue, dogs, cats);

           Instructor KMoney = new Instructor () ;
           KMoney.FirstName = "Kristen";
           KMoney.LastName = "IDK";
           KMoney.SlackHandle = "KMoney";
           KMoney.Cohort = C31;
           KMoney.Specialty = "making cupcakes";
           KMoney.Assign(Bill, dogs, cats);
           KMoney.Assign(Steve, dogs, cats);
           KMoney.Assign(Bo, dogs, cats);
           KMoney.Assign(Blue, dogs, cats);

            Instructor SteveNation = new Instructor () ;
           SteveNation.FirstName = "Steve";
           SteveNation.LastName = "Brownlee";
           SteveNation.SlackHandle = "SteveNation";
           SteveNation.Cohort = C30;
           SteveNation.Specialty = "making cupcakes";
           SteveNation.Assign(Bill, dogs, cats);
           SteveNation.Assign(Steve, dogs, cats);
           SteveNation.Assign(Bo, dogs, cats);
           SteveNation.Assign(Blue, dogs, cats);

           Instructor ATown = new Instructor () ;
           ATown.FirstName = "Andy";
           ATown.LastName = "Collins";
           ATown.SlackHandle = "ATown";
           ATown.Cohort = C31;
           ATown.Specialty = "making jokes";
           ATown.Assign(Bill, dogs, cats);
           ATown.Assign(Steve, dogs, cats);
           ATown.Assign(Bo, dogs, cats);
           ATown.Assign(Blue, fish, cats);
           ATown.Assign(Blue, fish, hamster);

            ///////////////Lists
            List <Student> studentList = new List<Student> () {
                Bill, Steve, Bo, Blue, NoExercise
            };

            List <Exercise> exerciseList = new List<Exercise> () {
                dogs, cats, fish, hamster
            };

            List <Cohort> cohortList = new List<Cohort> () {
                C29, C30, C31
            };

            List <Instructor> instructorList = new List<Instructor> () {
                JDog, KMoney, SteveNation, ATown
            };

            ////////Part 1
            List <Exercise> JavaScriptExercise = exerciseList.Where(n => n.Language == "JavaScript").ToList();

            ////////////Part 2 
            List <Student> StudendsInC31 = studentList.Where(n => n.Cohort == C31).ToList();

            ///////////////Part 3
            List <Instructor> InstructorInC31 = instructorList.Where(n => n.Cohort == C31).ToList();

            //////////////////Part 4
            List <Student> SortStudentLastName = studentList.OrderBy(n => n.LastName).ToList();

            ///////////////////Part 5
            List <Student> StudentWithNoExercise = studentList.Where(n => n.Exercises == null).ToList();

            /////////////////////Part 6
            Student MostExercises = studentList.OrderBy(n => n.Exercises.Count).ToList()[0];

            ///////////////////////Part 7
            foreach(Cohort n in cohortList){
                Console.WriteLine(n.Students.Count());
            }







            // foreach(Student stu in students) {
            //     Console.WriteLine($"{stu.FirstName} has to do these exercises: ");
            //     foreach(Exercise con in stu.Exercises){
            //         Console.WriteLine(con.Name);
            //     }
            // }
            

        }
    }
}
