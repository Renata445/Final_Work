Console.Clear();

string[] array_1 = new string[5] {"GeekBrains", "Car", "if", "456", "Dark"};
string[] array_2 = new string[array_1.Length];
void SecondArray(string[] array_1, string[] array_2)
{
    int k = 0;
    for (int i = 0; i < array_1.Length; i++)
    {
    if(array_1[i].Length <= 3)
        {
        array_2[k] = array_1[i];
        k++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
SecondArray(array_1, array_2);
PrintArray(array_2);
