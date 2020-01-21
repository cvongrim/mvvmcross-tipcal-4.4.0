using System;
namespace TipCalc.Core.Services
{
    public interface ICalculationSerivce
    {
        double TipAmount(double subTotal, int generosity);
    }
}
