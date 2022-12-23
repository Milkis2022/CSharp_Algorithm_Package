public static class MathAlgorithm
{
    public static int Gcd(int num1, int num2)
    {   
        while(num2 > 0){
            int temp = num1;
            num1 = num2;
            num2 = temp % num2;
        }
        return num1;
    }
    public static int Lcm(int num1, int num2)
    {   
        int multiply = num1 * num2;
        
        return multiply / Gcd(num1, num2);
    }
}
