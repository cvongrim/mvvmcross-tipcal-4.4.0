using System;
namespace TipCalc.Core.Services
{
    public class CalculationService : ICalculationSerivce
    {
        public double TipAmount(double subTotal, int generosity)
        {
            return subTotal * generosity / 100.0;
        }
    }
}
