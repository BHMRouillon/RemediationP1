using Common.AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common.AbstractFactory.Entities
{
    public class Boeing747 : IPlane
    {
        public int GetCapacity()
        {
            return 580;
        }
    }
}
