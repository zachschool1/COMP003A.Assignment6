using System;
using System.Collections.Generic;
using System.Text;

namespace COMP003A.Assignment6
{
    internal class Workout
    {
        public string Name;
        public int Reps;
        public bool Weighted;

        public Workout(string name, int reps, bool weighted)
        {
            Name = name;
            Reps = reps;
            Weighted = false;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Exercise Name: {Name}, Reps: {Reps}, Using Weights: {Weighted}");
        }


    }
}
