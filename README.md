# ----------------
![блок-схема к задачи drawio](https://user-images.githubusercontent.com/115629116/206369465-35506870-89c4-4d14-891a-553d3a2cd3ba.png)

// Задача: Написать программу, которая из имеющегося массива строк
// формирует новый массив из строк, длина которых меньше, либо равна 3 символам.

Console.Clear();
// Создаем 2 массива одинакового размера. 1 массив с обьявленными значениями.
string[] firstArray = new string[6] {"23456", "Hello", "-7", "Bye", "5", "-27" };
string[] resultArray = new string[6];
FillingTheArray(firstArray, resultArray);
PrintArray(resultArray);

// Метод для заполнения 2 массива.

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

// Метод печати 2 массива.

void PrintArray(string[] resultArray)
{
    for(var z = 0; z < 6; z++)
    {
        Console.Write($"{resultArray[z]} ");
    }
}
