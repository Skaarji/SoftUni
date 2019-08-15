using System;
using System.Collections.Generic;
using System.Text;

namespace ExBorderControl.Models 
{
    public class Robot : Entity
    {
        public string Model { get; private set; }
        public Robot(string model,string id)
            : base(id)
        {
            Model = model;
        }
    }
}
