
public class Solution
{
    public bool Flowerbed(List<int> flowerbed, int n)
    {
        flowerbed.Insert(0, 0);
        flowerbed.Add(0);

        int start = 0;
        int end = 3;

        while (n > 0 && end < flowerbed.Count)
        { 
            List<int> subflower = flowerbed.GetRange(start, end - start);
            if (!subflower.Contains(1))
            {
                n--;
                flowerbed[(end + start) / 2] = 1; 
            }
            start++;
            end++;
        }

        return n == 0;
    }

    public static void Main(string[] args)
    {
        Solution sol = new Solution();
        Console.WriteLine(sol.Flowerbed(new List<int>() { 1, 0, 0, 0, 1 }, 1)); // true
        Console.WriteLine(sol.Flowerbed(new List<int>() { 1, 0, 0, 0, 1 }, 2)); // false
        Console.WriteLine(sol.Flowerbed(new List<int>() { 0, 0, 1, 0, 1 }, 1)); // treu
        Console.WriteLine(sol.Flowerbed(new List<int>() { 1, 0, 1, 0, 0, 1 }, 1)); // false
    }
}