using Common.AbstractFactory.Entities;
using Common.AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common.AbstractFactory
{
    public class WarFactory : IVehicle
    {
        public IBoat GetBoat()
        {
            return new CharlesDeGaulle();
        }

        public IPlane GetPlane()
        {return new Rafale();
        }
    }
}
