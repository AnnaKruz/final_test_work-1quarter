string[] CreateArray(string[] array, int size)
{
    string[] massiv = new string[size];
    int j = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i].Length < 4) 
        {
            massiv[j] = array[i] ;
            j++;
        }
    }
    return massiv;
}

int CheckNumber(string[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i].Length < 4) 
        {
        sum++;
        }
    }
    return sum;
}

void PrintArray(string[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }    
}

string[] weekDays = new string[] { "Sun", "Monday", "Tue", "Wed", "Thu", "Fri", "Sat" };
int size = CheckNumber(weekDays);

Console.Write("[");
PrintArray(weekDays);
Console.Write("] => [");
PrintArray(CreateArray(weekDays, size));
Console.Write("]");