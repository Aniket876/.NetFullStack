using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment5_Q6
{
    public class Player
    {
        private string Name;
        private double Runs;
        public Player(string name, double runs)
        {
            this.Name = name;
            this.Runs = runs;
        }
        public string NAME
        {
            set
            {
                this.Name = value;
            }
            get
            {
                return this.Name;
            }
        }
        public double RUNS
        {
            set
            {
                this.Runs = value;
            }
            get
            {
                return this.Runs;
            }
        }
    }
}
