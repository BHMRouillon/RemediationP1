﻿using Common.AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common.AbstractFactory.Entities
{
    public class CharlesDeGaulle : IBoat
    {
        public int GetCapacity()
        {
            return 2200;
        }
    }
}
