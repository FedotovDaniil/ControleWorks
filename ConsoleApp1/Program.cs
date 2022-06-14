string[] enArray = Console.ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
string[] putArray = new string[enArray.Length];


putArray = ColleArray(enArray, putArray);
Console.WriteLine(String.Join(",", putArray));


string[] ColleArray(string[] enArray, string[] putArray)
{
    int i = 0;
    while (i < enArray.Length)
    {
        if (enArray[i].Length <= 3)
        {
            putArray[i] = enArray[i];

        }
        i++;
    }
    return putArray;
}