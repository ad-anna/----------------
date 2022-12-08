// Задача: Написать программу, которая из имеющегося массива строк
// формирует новый массив из строк, длина которых меньше, либо равна 3 символам.

Console.Clear();
string[] firstArray = new string[6] {"23456", "Hello", "-7", "Bye", "5", "-27" };
string[] resultArray = new string[6];
FillingTheArray(firstArray, resultArray);
PrintArray(resultArray);

void FillingTheArray(string[] firstArray, string[] resultArray)
{
    var z = 0;
    for(var i = 0; i < 6; i++)
    {
        if(firstArray[i].Length <= 3)
        {
            resultArray[z] = firstArray[i];
            z++;
        }
    }
}

void PrintArray(string[] resultArray)
{
    for(var z = 0; z < 6; z++)
    {
        Console.Write($"{resultArray[z]} ");
    }
}