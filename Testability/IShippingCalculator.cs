using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testability
{
    public interface IShippingCalculator
    {
        double CalculateShipping(Order order);
    }
}
