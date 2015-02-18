using System;

class BinarySearchAlgo
{
    static void Main()
    {
        Console.WriteLine("Please enter the array's lenght :");
        int n = int.Parse(Console.ReadLine());
        int[] searchedArray = new int[n];
        Console.WriteLine("Please enter array's elements :");
        for (int i = 0; i < n; i++)
        {
            searchedArray[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(searchedArray);
        Console.WriteLine("Please enter the integer you are looking for : ");
        int k = int.Parse(Console.ReadLine());
        int iMin = 0;
        int iMax = searchedArray.Length - 1;
        int mid = 0;
        bool isFound = false;
        while (isFound == false)
        {
            mid = (iMax + iMin) / 2;
            if (searchedArray[mid] < k)
            {
                iMin = mid;
            }
            else if (searchedArray[mid] > k)
            {
                iMax = mid;
            }

            if (searchedArray[mid] == k)
            {
                isFound = true;
            }
        }

        Console.WriteLine("Number is found at index: [{0}] and the number is : {1}", mid, searchedArray[mid]);

    }
}