List<int> raceTrack = Console.ReadLine().Split().Select(int.Parse).ToList();

double timeFirstCar = 0;
double timeSecondCar = 0;

for (int i = raceTrack.Count - 1; i > raceTrack.Count / 2; i--)
{
    if (raceTrack[i] == 0)
    {
        timeSecondCar *= 0.8;
    }
    else
    {
        timeSecondCar += raceTrack[i];
    }
        
}

for (int i = 0; i < raceTrack.Count / 2; i++)
{
    if (raceTrack[i] == 0)
    {
        timeFirstCar *= 0.8;
    }
    else
    {
        timeFirstCar += raceTrack[i];
    }

}
timeSecondCar = Math.Round(timeSecondCar, 1);
timeFirstCar = Math.Round(timeFirstCar, 1);
if (timeFirstCar > timeSecondCar)
{
    Console.WriteLine($"The winner is right with total time: {timeSecondCar}");
}
else
{
    Console.WriteLine($"The winner is left with total time: {timeFirstCar}");
}