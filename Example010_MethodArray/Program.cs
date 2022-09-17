int[] array = {10, 20, 35, 4, 35, 56, 47, 8};

int n = array.Length;
int find = 47;

int index = 0;
while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine (index);
    }
    index++;
}