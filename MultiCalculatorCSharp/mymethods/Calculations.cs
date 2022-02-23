using System;

namespace Calculations;

public class Calculations
{
    public decimal addNums(decimal term1, decimal term2)
    {
        return term1 + term2;
    }
    public decimal subtractNums(decimal minuend, decimal subtrahend)
    {
        return minuend - subtrahend;
    }
    public decimal multiplyNums(decimal factor1, decimal factor2)
    {
        return factor1 * factor2;
    }

    public decimal divideNums(decimal dividend, decimal divisor)
    {
        return dividend / divisor;
    }
    public decimal intExpoNums(decimal expBase, int exponent)
    {
        decimal power = expBase;
        for (int i = 1; i < exponent; i++) power *= expBase;
        return power;
    }
}