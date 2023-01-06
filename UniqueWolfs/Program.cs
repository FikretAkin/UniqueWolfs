static int UniqueWolfs(List<int> arr)
{
    int[] uniqueWolfs = arr.ToArray();

    var sortedUniqueWolfs = uniqueWolfs
        .GroupBy(x => x)
        .OrderBy(x => x.Key)
        .OrderByDescending(x => x.Count())
        .Select(x => x.Key);
    int mostsortedUniqueWolf = sortedUniqueWolfs.First();
    if (sortedUniqueWolfs.Count() > 1 && sortedUniqueWolfs.ElementAt(1) == sortedUniqueWolfs.First())
    {
        mostsortedUniqueWolf = sortedUniqueWolfs.Where(x => x < mostsortedUniqueWolf).Min();
    }
    return mostsortedUniqueWolf;
}
int FirstKey = 0;
#if DEBUG
Console.WriteLine("First Value İnput Sample: 1");
#endif
string FirstValue = Console.ReadLine();
FirstKey = Convert.ToInt32(FirstValue);
#if DEBUG
Console.WriteLine("List Value İnput Sample:  2 3 4 5 4 3 2 1 3 4");
#endif
string TwoValue = Console.ReadLine();

List<int> arrList = TwoValue.Split(' ')
    .Select(n => Convert.ToInt32(n))
    .ToArray()
    .ToList();
if (arrList.Exists(x => x > 5) || arrList.Exists(x => x < 1))
{
    Console.WriteLine("Error Number");
}
else
{
    Console.WriteLine(UniqueWolfs(arrList));
}
