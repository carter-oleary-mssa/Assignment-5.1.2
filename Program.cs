int n = 1234;
Console.WriteLine($"The sum of the digits of {n} is {SumDigits(n)}");

int SumDigits(int n)
{
    int sum = 0;
    while(n > 0)
    {
        sum += n % 10;
        n /= 10;
    }
    return sum;
}