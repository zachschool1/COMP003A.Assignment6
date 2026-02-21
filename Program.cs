namespace COMP003A.Assignment6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //theme B Fitness Tracker
            bool running = true;
            Workout set1 = new Workout("Sit Ups", 20, false);
            do
            {
                Console.WriteLine("Pick an option: ");
                Console.WriteLine("1. Display Information");
                Console.WriteLine("2. Add Reps");
                //i would add another option to add a new workout, or add it to the add reps function but i dont want to do that at the moment.
                Console.WriteLine("3. Exit Program");

                string input = Console.ReadLine();

               
                switch (input)
                {
                    case "1":
                        Console.WriteLine("Display info");
                        
                        Console.WriteLine(set1.DisplayInfo());
                        break;
                    case "2":
                        Console.WriteLine("Which execise are you updating?");
                        string exersizeName = Console.ReadLine();
                        
                        Console.WriteLine("How many reps?");
                        string repsInput = Console.ReadLine();
                        int reps = int.Parse(repsInput);
                        
                        set1.MoreReps(exersizeName, reps);
                        string info = set1.DisplayInfo();
                        Console.WriteLine($"Updated info: \n{info}");

                        break;
                    case "3":
                        Console.WriteLine("Exiting Program");
                        running = false;
                        break;
                    case "secret":
                        Console.WriteLine("you found the super secret one!");
                        break;
                    default:
                        Console.WriteLine("Please choose one of the 3 options.");
                        break;
                }
            } while (running);




            
        }
    }
}
