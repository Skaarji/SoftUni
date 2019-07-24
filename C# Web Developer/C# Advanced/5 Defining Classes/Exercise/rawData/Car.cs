using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Car
    {
        public string Model { get; set; }

        public Engine Engine { get; set; }

        public Cargo Cargo { get; set; }

        public Tire[] TireSet { get; set; }

        public Car()
        {

        }
        public Car(string model, Engine engine, Cargo cargo, Tire[] tireSet)
        {
            Model = model;
            Engine = engine;
            Cargo = cargo;
            TireSet = tireSet;
        }

    }
}
