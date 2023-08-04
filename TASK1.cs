// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.


int [,] makeArray (int userRows, int userColl)
{


int [,] newArray = new int [userRows, userColl];
for (int i = 0; i < userRows; i++)
{
    for (int j = 0; j < userColl; j++)
    {
        newArray[i,j] = new Random().Next(1, 10);
    }
}
return newArray;
}

void printArray (int [,] randArray)

{
    for(int i = 0; i < randArray.GetLength(0); i++)
    {
        for(int j = 0; j < randArray.GetLength(1); j++)
        {
            Console.Write(randArray[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int sortRowArray (int [,] array)
{
int temp;
for(int i = 0; i < array.GetLength(0); i++)
    for (int j = 0; j < array.GetLength(1); j++)
        for (int t = 0; t < array.GetLength(1)-1; t++)
            if(array[i,t] < array[i,t+1])
            {
                temp = array[i, t+1];
                array[i,t+1] = array [i,t];
                array[t,t] = temp;
            }
}

Console.WriteLine("Enter count of rows: ");
int userRows1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter count of Collumns: ");
int userColl1 = Convert.ToInt32(Console.ReadLine());

int [,] result = makeArray(userRows1, userColl1);
printArray(result);

sortRowArray(result);