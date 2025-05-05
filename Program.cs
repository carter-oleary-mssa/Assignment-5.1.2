int n = 1234;
Console.WriteLine($"The sum of the digits of {n} is {SumDigits(n)}");

int SumDigits(int n)
{
    string s = n.ToString();
    int sum = 0;
    foreach (char c in s)
        sum += Convert.ToInt32(c) - 48;
    return sum;
}