using System.Text;

string input = Console.ReadLine();

char[] charArray = input.ToCharArray();

List<int> digitListTake = new List<int>();

List<int> digitListSkip = new List<int>();

List<char> charsList = new List<char>();

List<int> numbersList = new List<int>();

List<char> result = new List<char>();

for (int i = 0; i < charArray.Length; i++)
{
    if (char.IsDigit(charArray[i]))
    {
        numbersList.Add(int.Parse(char.ToString(charArray[i])));
    }
    else
    {
        charsList.Add(charArray[i]);
    }
}
for (int i = 0; i < numbersList.Count; i++)
{
    if (i % 2 == 0)
    {
        digitListTake.Add(numbersList[i]);
    }
    else
    {
        digitListSkip.Add(numbersList[i]);
    }
}


while (digitListSkip.Count > 0 && digitListTake.Count > 0)
{
    for (int i = 0; i < digitListTake[0]; i++)
    {
        if (charsList.Count <= digitListTake[0] || charsList.Count <= digitListSkip[0])
        {
            for (int j = i; j < charsList.Count; j++)
            { 
                result.Add(charsList[j]);
            }
            Console.WriteLine(string.Join("", result));
            return;
        }
        result.Add(charsList[i]);
    }

    charsList.RemoveRange(0, digitListTake[0]);
    charsList.RemoveRange(0, digitListSkip[0]);
    digitListSkip.RemoveAt(0);
    digitListTake.RemoveAt(0);
}
Console.WriteLine(string.Join("", result));