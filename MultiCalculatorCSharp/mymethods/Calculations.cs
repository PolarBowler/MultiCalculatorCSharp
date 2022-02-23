using System;

namespace Calculations;

public class calc
{
    public static decimal addNums(decimal term1, decimal term2)
    {
        return term1 + term2;
    }
    public static decimal subtractNums(decimal minuend, decimal subtrahend)
    {
        return minuend - subtrahend;
    }
    public static decimal multiplyNums(decimal factor1, decimal factor2)
    {
        return factor1 * factor2;
    }

    public static decimal divideNums(decimal dividend, decimal divisor)
    {
        return dividend / divisor;
    }
    public static decimal intExpoNums(decimal expBase, int exponent)
    {
        decimal power = expBase;
        for (int i = 1; i < exponent; i++) power *= expBase;
        return power;
    }
}