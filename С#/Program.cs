void PrintArray(string[] matrix)
{
    for (int i = 0; i < matrix.Length; i++)
    {
        if (matrix[i] == null) return;
        Console.Write($"{matrix[i]} ");
    }
}


string[] GetNewArray(string[] arr)
{
    string[] newArr = new string[arr.Length];
    int pos = 0;

    for (int i = 0; i < arr.Length; i++)
        if (arr[i].Length <= 3)
        {
            newArr[pos] = arr[i];
            pos++;
        }
    return newArr;

}


Console.WriteLine("Введите количество элементов:");
int size = Convert.ToInt32(Console.ReadLine());

string[] array = new string[size];
for (int i = 0; i < size; i++)
{
    Console.WriteLine($"Введите {i + 1} элемент массива:");
    array[i] = Console.ReadLine();
}

string[] newArray = GetNewArray(array);
PrintArray(newArray);