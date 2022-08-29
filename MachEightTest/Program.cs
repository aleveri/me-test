var param = new int[] { 1, 9, 5, 0, 20, -4, 12, 16, 7 };
var targetSum = 12;

var result = new Dictionary<int, int>();

foreach (int i in param)
{
    int index = Array.IndexOf(param, targetSum - i);

    if (index > -1 && !result.ContainsKey(i) && !result.ContainsKey(param[index]))
    {
        result.Add(i, index);
        result.Add(index, i);
        Console.WriteLine($"{param[index]}, {i}");
    }
}