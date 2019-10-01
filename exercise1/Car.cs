﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise1
{
    class Car
    {
        private string make;

        public string Make
        {
            get { return this.make; }
            set { this.make = value; }
        }

        private string _model;


        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        private int currentSpeed;


        public int CurrentSpeed
        {
            get { return currentSpeed; }
            set { currentSpeed = value; }
        }

        private double engineSize;

        public double EngineSize
        {
            get { return engineSize; }
            set { engineSize = value; }
        }
    }
}
