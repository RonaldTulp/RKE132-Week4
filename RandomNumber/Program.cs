Random rnd = new Random();
int myRandomNum;
int i;
int randomSum = 0;

for (i = 0; i < 10; i++)
{
    myRandomNum = rnd.Next(0, 11); //0 - 10
    randomSum = randomSum + myRandomNum;
    Console.WriteLine($"My random number is: {myRandomNum}");
}

Console.WriteLine($"Random sum total: {randomSum}");  