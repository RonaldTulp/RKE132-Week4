int i = 0;
int sum = 0;

for(i = 1; i < 11; i++)
{
    Console.WriteLine($"i = {i}");
    Console.WriteLine($"Current total: {sum}");
    sum += i;
}

Console.WriteLine($"Final total: {sum}");