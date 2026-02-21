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

        public string DisplayInfo()
        {
            if (Name != null)
            {
                return $"Exercise Name: {Name}, Reps: {Reps}, Using Weights: {Weighted}";
            }
            return "no name given";
        }

        public void MoreReps( string name,int reps )
        {
            if (name == Name)
            {
                this.Reps += reps;
            }
            

        }
    }
}
