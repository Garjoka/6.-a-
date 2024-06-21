using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("Enter the first set of numbers separated by space: ");
        HashSet<int> set1 = new HashSet<int>(Console.ReadLine().Split(' ').Select(int.Parse));
        Console.Write("Enter the second set of numbers separated by space: ");
        HashSet<int> set2 = new HashSet<int>(Console.ReadLine().Split(' ').Select(int.Parse));

        HashSet<int> intersection = new HashSet<int>(set1);
        intersection.IntersectWith(set2);

        HashSet<int> union = new HashSet<int>(set1);
        union.UnionWith(set2);

        HashSet<int> difference = new HashSet<int>(set1);
        difference.ExceptWith(set2);

        int totalSum = set1.Sum() + set2.Sum();

        Console.WriteLine($"Intersection: {string.Join(", ", intersection)}");
        Console.WriteLine($"Union: {string.Join(", ", union)}");
        Console.WriteLine($"Difference: {string.Join(", ", difference)}");
        Console.WriteLine($"Sum: {totalSum}");
    }
}
