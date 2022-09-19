string[] arrayOne = new string[5] {"666", "12", "mewo", "cat", "test111"};
string[] arrayTwo = new string[arrayOne.Length];
void Solution(string[] arrayOne, string[] arrayTwo)
{
    int count = 0;
    for (int i = 0; i < arrayOne.Length; i++)
    {
    if(arrayOne[i].Length <= 3)
        {
        arrayTwo[count] = arrayOne[i];
        count++;
        }
    }
}
void Print(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
Solution(arrayOne, arrayTwo);
Print(arrayTwo);