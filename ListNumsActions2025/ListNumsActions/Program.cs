using System.Collections.Concurrent;

namespace ListNumsActions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            while (true)
            {
                string[] cmd = Console.ReadLine().Split().ToArray();
                string command = cmd[0];
                if (command.ToLower() == "finish")
                {
                    break;
                }
                switch (command)
                {
                    case "ins": int index= int.Parse(cmd[1]);
                        int num = int.Parse(cmd[2]);
                        nums.Insert(index,num);
                        break;
                    case "print":
                        Console.WriteLine(string.Join(" ", nums));
                        break;

                    case "contains":
                        int containsValue = int.Parse(cmd[1]);
                        Console.WriteLine(nums.Contains(containsValue));
                        break;
                    case "del":
                        int toDelete = int.Parse(cmd[1]);
                        nums.Remove(toDelete);
                        break;
                    case "add":
                        int addValue = int.Parse(cmd[1]);
                        int sum = nums.Sum();
                        nums.Add(addValue + sum);
                        break;
                    case "remove":
                        int removeIndex = int.Parse(cmd[1]);
                        if (removeIndex >= 0 && removeIndex < nums.Count)
                        {
                            nums.RemoveAt(removeIndex);
                        }
                        break;
                    case "countl":
                        int countValue = int.Parse(cmd[1]);
                        int count = 0;
                        foreach (var item in nums)
                        {
                            if (item > countValue)
                            {
                                count++;
                            }
                        }
                        Console.WriteLine(count);
                        break;
                    case "countodds":
                        Console.WriteLine(nums.Count(x => x % 2 != 0));
                        break;
                    case "countevens":
                        Console.WriteLine(nums.Count(x => x % 2 == 0));
                        break;
                    case "sumall":
                        Console.WriteLine(nums.Sum());
                        break;
                    default:
                        Console.WriteLine("Невалидна команда.");
                    break;
                }
            }
        }
    }
}
