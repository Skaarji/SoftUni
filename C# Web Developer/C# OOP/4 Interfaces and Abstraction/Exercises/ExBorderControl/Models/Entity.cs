﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ExBorderControl.Models
{
    public abstract class Entity
    {
        protected Entity(string id)
        {
            Id = id;
        }
        public string Id { get; private set; }
    }
}
