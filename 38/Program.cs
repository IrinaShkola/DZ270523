//  Задайте массив вещественных(тип double) чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3,1; 7,2; 22,3; 2,4; 78,5] -> 76,1
Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
double[] aray = new double[size];
FillArrayRandomNumbers(aray);
PrintArray(aray);
double min = aray[0];
double max = aray[0];

for (int z = 0; z < aray.Length; z++)
{
    if (aray[z] > max)
        {
            max = aray[z];
        }
    if (aray[z] < min)
        {
            min = aray[z];
        }
}

Console.WriteLine($"Max = {max}, Min = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

void FillArrayRandomNumbers(double[] aray)
{
    for(int i = 0; i < aray.Length; i++)
        {
            aray[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}
void PrintArray(double[] aray)
{
    
    for(int i = 0; i < aray.Length; i++)
        {
            Console.Write(aray[i] + " ");
        }
    
    Console.WriteLine();
}