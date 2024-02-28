/*
Author: Tarun Peela
Date: 2/28/2024
Comments: This C# Console Application code demonstrates the
          Bubble Sort Algorithms. No input is required for the 
          script. It will execute without 
          input against two pre-populated arrays. 
 */

int[] bubble_sort_numbers = { 5,72,3,14,7,1 };


Console.WriteLine("original array: ");
for (int i = 0; i < bubble_sort_numbers.Length; i++)
{
    Console.Write("  " + bubble_sort_numbers[i]);
}

Console.WriteLine("");
Console.WriteLine(" after the execution : ");
Bubble_Sort(bubble_sort_numbers);
for (int i = 0; i < bubble_sort_numbers.Length; i++)
{
    Console.Write("  " + bubble_sort_numbers[i]);
}
Console.WriteLine("");
Console.WriteLine("Press any key to exit the program ...");
Console.ReadKey(true);


static void Bubble_Sort(int[] bs_arr)
{
    for (int i = 0; i < bs_arr.Length - 1; i++)
    {
        for (int x = 0; x < bs_arr.Length - i - 1; x++)
        {
           
            if (bs_arr[x] > bs_arr[x + 1])
            {
               
                int temp = bs_arr[x];
                bs_arr[x] = bs_arr[x + 1];
                bs_arr[x + 1] = temp;
            } 
        } 
    } 
}