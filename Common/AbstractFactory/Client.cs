using Common.AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common.AbstractFactory
{
    public class Client
    {
        IBoat boat;
        IPlane plane;

        public Client(IVehicle factory)
        {
            boat = factory.GetBoat();
            plane = factory.GetPlane();
        }

        public int GetPlaneCapacity()
        {
            return plane.GetCapacity();
        }

        public int GetBoatCapacity()
        {
            return boat.GetCapacity();
        }
    }
}
