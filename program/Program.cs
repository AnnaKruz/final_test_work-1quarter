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

string[] weekDays = new string[] { "Sun", "Monday", "Tue", "Wed", "Thu", "Fri", "Sat" };
int size = CheckNumber(weekDays);
Console.WriteLine($"[{string.Join(", " , weekDays)}] => [{string.Join(", " , CreateArray(weekDays, size))}]");