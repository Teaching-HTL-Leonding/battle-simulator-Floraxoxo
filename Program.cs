Console.Clear();
Console.WriteLine("In which floor did you enter the elevator? (-20)- 20");
string start = Console.ReadLine()!;
Console.WriteLine("In which floor do ou want to get out of the elevator? (-20)- 20");
string goal = Console.ReadLine()!;
int target_floor = 0;
int floor = 0;

if (start != "g" && start != "G" && start != "ground base")
{
    floor = Int32.Parse(start);
}
if(goal != "g" && goal != "G" && goal != "ground base")
{
   target_floor = Int32.Parse(goal); 
}

int current_floor = floor;
if (current_floor != target_floor)
{
    while (current_floor < target_floor - 1)
    {
        Thread.Sleep(3000);
        current_floor++;
        if (current_floor == 0)
        {
            Console.WriteLine("You are currently in the ground base");
        }
        else
        {
            Console.WriteLine("You are currently in the {0} floor.", current_floor);
        }
    }
    while (current_floor > target_floor + 1)
    {
        Thread.Sleep(3000);
        current_floor--;
        if (current_floor == 0)
        {
            Console.WriteLine("You are currently in the ground base");
        }
        else
        {
            Console.WriteLine("You are currently in the {0} floor.", current_floor);
        }
    }
    Thread.Sleep(3000);
    Console.WriteLine("Congratulation you reached your target floor. Doors are opening!");
}
else if (floor == target_floor)
{
        Console.WriteLine("You are already in the " + goal + " floor. Please try again!");
}
Console.ReadKey();
Console.Clear();