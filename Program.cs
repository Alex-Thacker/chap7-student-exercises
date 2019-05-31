using System;
using System.Collections.Generic;

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
           cats.Language = "meow";

           Exercise fish = new Exercise();
           fish.Name = "fish";
           fish.Language = "bloop";

           Exercise hamster = new Exercise();
           hamster.Name = "hamster";
           hamster.Language = "meep";

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

           Student Steve = new Student();
           Steve.FirstName = "Steve";
           Steve.LastName = "Stevie";
           Steve.SlackHandle = "SteveStevie";
           Steve.Cohort = C29;

           Student Bo = new Student();
           Bo.FirstName = "Bo";
           Bo.LastName = "Body";
           Bo.SlackHandle = "BoBody";
           Bo.Cohort = C30;

           Student Blue = new Student();
           Blue.FirstName = "Blue";
           Blue.LastName = "Yellow";
           Blue.SlackHandle = "BlueYellow";
           Blue.Cohort = C31;

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

            ///////////////Lists
            List <Student> students = new List<Student> () {
                Bill, Steve, Bo, Blue
            };

            List <Exercise> exerciseList = new List<Exercise> () {
                dogs, cats, fish, hamster
            };

            foreach(Student stu in students) {
                Console.WriteLine($"{stu.FirstName} has to do these exercises: ");
                foreach(Exercise con in stu.Exercises){
                    Console.WriteLine(con.Name);
                }
            }
            

        }
    }
}
