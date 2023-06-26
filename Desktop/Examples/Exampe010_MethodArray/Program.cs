int[] array = {1,12,31,41,43,56,41,8};

int  n = array.Length;
int find =41;
int index = 0;
while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}
