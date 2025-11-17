List<int> firstList = Console.ReadLine().Split().Select(int.Parse).ToList();
List<int> secondList = Console.ReadLine().Split().Select(int.Parse).ToList();
List<int> mixedList = new List<int>();

int minCount = Math.Min(firstList.Count, secondList.Count);
for (int i = 0; i < minCount; i++)
{
    mixedList.Add(firstList[i]);
    mixedList.Add(secondList[secondList.Count - 1 - i]);
}

int lowRange = 0;
int highRange = 0;

if (firstList.Count > secondList.Count)
{
    int remaining1 = firstList[firstList.Count - 2];
    int remaining2 = firstList[firstList.Count - 1];
    highRange = Math.Max(remaining1, remaining2);
    lowRange = Math.Min(remaining1, remaining2);
}
else
{
    int remaining1 = secondList[0];
    int remaining2 = secondList[1];
    highRange = Math.Max(remaining1, remaining2);
    lowRange = Math.Min(remaining1, remaining2);
}

List<int> result = mixedList.Where(x => x > lowRange && x < highRange).ToList();
result.Sort();

Console.WriteLine(string.Join(" ", result));