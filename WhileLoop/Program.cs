Random rnd = new Random();
int cpuRandom;
int userNum;
bool loopActive = true;

while (loopActive)
{
    cpuRandom = rnd.Next(1, 4);
    Console.WriteLine("Arva number 1 - 3");
    userNum = Int32.Parse(Console.ReadLine());

    if (userNum == cpuRandom)
    {
        Console.WriteLine("Palju õnne, Võitsite!");
        //loopActive = false;
        break;
    }
    else { Console.WriteLine("Proovi uuesti!"); }
}

Console.WriteLine("Kena Päeva!");