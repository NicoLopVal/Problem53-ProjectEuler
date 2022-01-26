double answer = 0;

for(double i = 2; i <= 100; i++)
{
    for(double j = 1; j < i; j++)
    {
        if(GetFactorial(i,j)>1000000)
            answer++;
    }
}

Console.WriteLine("There are {0} greater than one - million", answer);


double GetFactorial(double num, double denom)
{
    double numerator = 1;
    double denominator = 1;
    for(double i = num; i > denom; i--)
    {
        numerator *= i;
    }
    for (double i = (num-denom); i > 0; i--)
    {
        denominator *= i;
    }
    return numerator / denominator;
}