// Задача: Написать программу, которая из имеющегося массива строк
// формирует новый массив из строк, длина которых меньше, либо равна 3 символам.

Console.Clear();
string[] firstArray = new string[6] {"234", "Hello", "-7", "Goodbye", "5", "-27" };
string[] resultArray = new string[6];
FillingTheArray(firstArray, resultArray);

void FillingTheArray(string[] firstArray, string[] resultArray)
{
    var z = 0;
    for(var i = 0; i < 6; i++)
    {
        if(firstArray[i].Length <= 3)
        {
            resultArray[z] = firstArray[i];
        }
    }
}