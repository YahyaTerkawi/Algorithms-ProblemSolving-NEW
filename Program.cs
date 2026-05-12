class program
{

    static void swap(ref int num1, ref int num2)
    {
        int temp = num1;
        num1 = num2;
        num2 = temp;
    }

    static void SelectionSort(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            int MinIndex = i;

            for(int j = i; j<arr.Length;j++)
            {
                if (arr[j]< arr[MinIndex])
                    MinIndex = j;
            }

            swap(ref arr[MinIndex],ref arr[i]);
        
        }
    }

    static void Main(string[] args)
    {
        int[] arr = {4,6,7,8,324,65,88,0,-1 };

        SelectionSort(arr);

        foreach (int num in arr)
        {
            Console.Write($"   {num}");
        }

        Console.ReadKey();
    }
}