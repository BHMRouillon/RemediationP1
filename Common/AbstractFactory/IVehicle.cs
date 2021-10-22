using Common.AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common.AbstractFactory
{
    public interface IVehicle
    {
        IPlane GetPlane();
        IBoat GetBoat();
    }
}
