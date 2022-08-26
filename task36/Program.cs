//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int[] numbers = new int[5];

FillArray(numbers);
PrintOddNumber(numbers);
PrintArray(numbers);


void PrintOddNumber (int[] number)
{
    int sum = 0;
    for (int i = 0; i < number.Length; i++)
    {   
        if (number[i] % 2 == 1)
        {
            sum += number[i];
        }
    }
    Console.WriteLine($" Сумма нечетных чисел в массиве: {sum}");
}

void FillArray(int[] number)
{
for(int i = 0; i < number.Length; i++)
{
number[i] = new Random().Next(1, 100);
}
}

void PrintArray(int[] number)
{
for(int i = 0; i < number.Length; i++)
{
Console.Write(number[i] + " ");
}
}
