int GetIntFromConsole(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine() ?? "");
}

string[] GetStringArray(int size)
{
    var result = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите элемент массива №{i + 1}: ");
        result[i] = Console.ReadLine() ?? "";

    }
    return result;
}

int GetCountDesiredRows(string[] originArray, int desiredLenght)
{
    int len = originArray.Length;
    int sizeResultArray = 0;
    for (int i = 0; i < len; i++)
    {
        if (originArray[i].Length <= desiredLenght)
            sizeResultArray++;
    }
    return sizeResultArray;
}

string[] GetDesiredArray(string[] originArray, int desiredLenght)
{
    int sizeResultArray = GetCountDesiredRows(originArray, desiredLenght);
    string[] resultArray = new string[sizeResultArray];
    int len = originArray.Length;
    int currentIndex = 0;
    for (int i = 0; i < len; i++)
    {
        if (originArray[i].Length <= desiredLenght)
            resultArray[currentIndex++] = originArray[i];
    }
    return resultArray;
}

void PrintArray(string[] printeredArray, string message = "Сформированный массив:")
{
    Console.WriteLine(message);
    int len = printeredArray.Length;
    for (int i = 0; i < len; i++)
    {
        Console.Write(printeredArray[i]);
        if (i < len - 1)
            Console.Write(" ");
    }
}

int n = GetIntFromConsole("Введите размер массива");
var originArray = GetStringArray(n);
int desiredLenght = 3;
var resultArray = GetDesiredArray(originArray, desiredLenght);
PrintArray(resultArray);