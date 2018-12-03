using System;
using System.Collections.Generic; using System.Linq; using System.Text; using System.Threading.Tasks;
namespace capstoneProject
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            DisplayOpeningScreen();              DisplayMenu();              DisplayClosingScreen();
        }

        static void DisplayMenu()         {             string menuChoice;             bool exiting = false;              while (!exiting)             {
            DisplayHeader("Main Menu");


            Console.WriteLine("\tA) Display all Courses");             Console.WriteLine("\tB) Display all Homework");
            Console.WriteLine("\tC) Add an Assignment");
            Console.WriteLine("\tD) Delete an Assignment");
            Console.WriteLine("\tE) Archive Current Assignments");
            Console.WriteLine("\tF) View Archive");
                Console.WriteLine("\tQ) Quit");
                Console.Write("Enter Choice:");
            menuChoice = Console.ReadLine(); 
                switch (menuChoice)                 {                     case "A":                     case "a":                         DisplayAllCourses();                         break;                      case "B":                     case "b":                         DisplayHomework();                         break;                      case "C":                     case "c":                         DisplayAddAssignment();                         break;                      case "D":                     case "d":                         DisplayDeleteHomework();                         break;                      case "E":                     case "e":                         DisplayAddToArchive();                         break;                      case "F":                     case "f":                         DisplayViewArchive();                         break;

                    case "Q":
                    case "q":
                        exiting = true;
                        break;
                     default:                         break;                  }              }          }

        //
        //List Making
        //
        List<Courses> courseList = new List<Courses>();



        private static void DisplayAllCourses()
        {
            throw new NotImplementedException();
        }

        private static void DisplayHomework()
        {
            throw new NotImplementedException();
        }

        private static void DisplayAddAssignment()
        {
            throw new NotImplementedException();
        }

        private static void DisplayViewArchive()
        {
            throw new NotImplementedException();
        }

        private static void DisplayDeleteHomework()
        {
            throw new NotImplementedException();
        }

        private static void DisplayAddToArchive()
        {
            throw new NotImplementedException();
        }

        #region InitializeCourses
        //Courses CIT110;
        //CIT110 = InitializeCourseCIT();


        public static Courses InitializeCourseCIT()
        {
            Courses CIT110 = new Courses();

            CIT110.CourseName = "CIT110";
            CIT110.DayOfClass = "Monday" + "Wednesday";

            return CIT110;
        }

        #endregion
        
        #region Basics
        static void DisplayOpeningScreen()         {             Console.Clear();
             Console.WriteLine();             Console.WriteLine("\t\tWelcome to Homework Tracker 5000");             Console.WriteLine();
             DisplayContinuePrompt();          }

        static void DisplayClosingScreen()         {             Console.Clear();
             Console.WriteLine();             Console.WriteLine("\t\tThanks for using Simple Monster Classes.");             Console.WriteLine();             Console.WriteLine("Press any key to exit.");             Console.ReadKey();         }

        static void DisplayContinuePrompt()         {             Console.WriteLine();             Console.WriteLine("Press any key to continue.");             Console.ReadKey();         }

        static void DisplayHeader(string headerTitle)         {             Console.Clear();             Console.WriteLine();             Console.WriteLine("\t\t" + headerTitle);             Console.WriteLine();         }

        #endregion
    }
}
