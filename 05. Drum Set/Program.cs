double savings = double.Parse(Console.ReadLine());
List<int> drumSet = Console.ReadLine().Split().Select(int.Parse).ToList();
List<int> currentDrums = drumSet.ToList();

string command = Console.ReadLine();

while (command != "Hit it again, Gabsy!")
{
    int hitPower = int.Parse(command);

    for (int i = 0; i < currentDrums.Count; i++)
    {
        currentDrums[i] -= hitPower;

        if (currentDrums[i] <= 0)
        {
            double repairCost = drumSet[i] * 3;

            if (savings >= repairCost)
            {
                savings -= repairCost;
                currentDrums[i] = drumSet[i];
            }
            else
            {
                currentDrums.RemoveAt(i);
                drumSet.RemoveAt(i);
                i--;
            }
        }
    }

    command = Console.ReadLine();
}

Console.WriteLine(string.Join(" ", currentDrums));
Console.WriteLine($"Gabsy has {savings:f2}lv.");