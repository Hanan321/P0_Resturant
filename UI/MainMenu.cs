using System;

namespace UI
{
   public class MainMenu :IMenu
    {
      public void start(){
          Console.WriteLine("Welcome to Hanan's resturants app!");
          Console.WriteLine("[0] Exit.");
          Console.WriteLine("[1] View All Resturants");
          Console.WriteLine("[2] Add a review for a resturant");//insert user info then review
          Console.WriteLine("[3] Show other customers reviews.");

            switch(Console.ReadLine()){
                case "0":

                    break;
                case "1":
                        Console.WriteLine("View All Resturants");//ViewAllResturants()
                    break;
                case "2":
                        Console.WriteLine("Add a review for a resturant");//AddAReview()
                    break;
                case "3":
                        Console.WriteLine("Show other customers reviews.");//ShowOtherCustomersReview()
                    break;
                    default:
                        Console.WriteLine("We don't understand what you are doing!");
                    break;

            }




       }
    }
}
