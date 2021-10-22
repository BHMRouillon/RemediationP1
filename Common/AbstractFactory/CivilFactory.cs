using Common.AbstractFactory.Entities;
using Common.AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common.AbstractFactory
{
    public class CivilFactory : IVehicle
    {
        public IBoat GetBoat()
        {
            return new Titanic();
        }

        public IPlane GetPlane()
        {
            return new Boeing747();
        }
    }
}
