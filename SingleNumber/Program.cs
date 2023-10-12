
Console.WriteLine("[2, 2, 1]:");
Console.WriteLine(SingleNumber(new int[] { 4, 1, 2, 1, 2 }));

Console.WriteLine("[4, 1, 2, 1, 2]:");
Console.WriteLine(SingleNumber(new int[] { 4, 1, 2, 1, 2 }));

Console.WriteLine("[1]:");
Console.WriteLine(SingleNumber(new int[] { 1 }));


Console.ReadLine();




//Example 1:

//Input: nums = [2, 2, 1]
//Output: 1
//Example 2:

//Input: nums = [4, 1, 2, 1, 2]
//Output: 4
//Example 3:

//Input: nums = [1]
//Output: 1
 

static int SingleNumber(int[] nums)
{
    int result = 0;

    for (int i = 0; i < nums.Length; i++)
    {
        result ^= nums[i];
    }

    return result;
}