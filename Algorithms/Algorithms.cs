using System;

namespace DeveloperSample.Algorithms
{
    public static class Algorithms
    {
        public static int GetFactorial(int n) => throw new NotImplementedException();

        public static string FormatSeparators(params string[] items) => throw new NotImplementedException();
    }
    public static int GetFactorial(int n)
    {
        double result =1;
        try
        {
            
            while(n !=1)
            {
                result= result*n;
                n= n-1;
            }
        }
        catch(Exception ex)
        {
            throw  new NotImplementedException();
        }
        return result;
    }
    
}
