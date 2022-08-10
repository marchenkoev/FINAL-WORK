int count = 0;
string[] array = new string[] {"2", ":-)", "hello", "world"};
string[] n = new string[array.Length];
void SecondArrayWithIF(string[] array, string[] n)
{
    for (int i = 0; i < array.Length; i=i+1)
    {
    if(array[i].Length <= 3)
        {
        n[count] = array[i];
        count=count+1;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i=i+1)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
SecondArrayWithIF(array, n);
PrintArray(n);