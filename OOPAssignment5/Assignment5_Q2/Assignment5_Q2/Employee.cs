﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment5_Q2
{
    class Employee
    {
        private int Id;
        private string Name;
        private double Salary;
        public Employee(int id, string name, double salary)
        {
            this.Id = id;
            this.Name = name;
            this.Salary = salary;
        }
        public int ID
        {
            set
            {
                this.Id = value;
            }
            get
            {
                return this.Id;
            }
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
        public double SALARY
        {
            set
            {
                this.Salary = value;
            }
            get
            {
                return this.Salary;
            }
        }
        public override string ToString()
        {
            return "id: " + this.ID + " name: " + this.NAME + " salary: " + this.SALARY;
        }

    }
}
