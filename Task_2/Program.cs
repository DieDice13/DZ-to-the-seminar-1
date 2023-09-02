int[] nums = new int[3];
Console.Write("Enter first numbers : ");
nums[0] = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second numbers : ");
nums[1] = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter third numbers : ");
nums[2] = Convert.ToInt32(Console.ReadLine());
int max = nums[0];

Console.WriteLine("Работаем со следующим массивом ");
var str = string.Join(" ", nums);
Console.WriteLine(str);

for (int i = 0; i < nums.Length; i++)
{
    if (nums[1] > max)
    {
        max = nums[1];
    }
    else  
    {
        if (nums[2] > max)
        max = nums[2];
    }  
}
Console.WriteLine("The maximum of these numbers : " + max);

  


