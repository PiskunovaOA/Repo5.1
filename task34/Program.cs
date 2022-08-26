//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int[] numbers = new int[5];
FillArray(numbers);
PrintEvenNumber(numbers);
PrintArray(numbers);


void PrintEvenNumber (int[] number)
{
    int count = 0;
    for (int i = 0; i < number.Length; i++)
    {   
        if (number[i] % 2 == 0)
        {
            count += 1;
        }
    }
    Console.WriteLine($" Колличество четных чисел в массиве: {count}");
}

void FillArray(int[] number)
{
for(int i = 0; i < number.Length; i++)
{
number[i] = new Random().Next(100, 1000);
}
}

void PrintArray(int[] number)
{
for(int i = 0; i < number.Length; i++)
{
Console.Write(number[i] + " ");
}
}
