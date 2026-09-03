namespace MyCalculations
{

    public   class Calculation
    {
        // public int Add(int num1, int num2)
        // {
        //     return num1 + num2;
        // }

        // public int Add(int num1, int num2, int num3)
        // {
        //     return num1 + num2 + num3;
        // }

        // public int Add(int num1, int num2, int num3, int num4)
        // {
        //     return num1 + num2 + num3 + num4;
        // }

        public string Add(string name, string lastname)
        {
            return  name  + " " + lastname; 
        }


        //params array
        //1. it can always be the past parameter in a method
        //2. only 1 params parameter in a function 
        //3. params can be used only in a method
        public int Add(int num1, int num2,string name, double sal, params int[] more)
        {
            int result = num1 + num2;
            for(int i = 0; i < more.Length; i++)
            {
                result = result + more[i];
            }
            return result;

        }


    }

    public class HighValueSmartCalculation : Calculation
    {
        
    }



}