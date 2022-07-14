//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

void newMass1(){
    int length = new Random().Next(1, 10);
    Console.WriteLine($"массив newMass состоит из {length} чисел");
    int[] newMass = new int[length];
    int P = 0;
    for (int i = 0; i < length; i++)
    {
        newMass[i] = new Random().Next(100, 1000);
        if (newMass[i] % 2 == 0)
        {
            P++;
            Console.Write($"{newMass[i]}, ");
        }
    }
    Console.WriteLine($"четных чисел в массиве newMass - {P}"); 
}
newMass1();
