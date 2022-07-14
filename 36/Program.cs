//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
       

void newMass2(){    
    int length = new Random().Next(1, 10);
    Console.WriteLine($"массив newMass состоит из {length} чисел");
    int[] newMass = new int[length];
    int P = 0;
    for (int i = 0; i < length; i++)
    {
        newMass[i] = new Random().Next(100, 1000);
        if (i % 2 == 1)
        {
            P = newMass[i] + P;
            Console.WriteLine($"{newMass[i]} на позиции {i}");
        }
    }
    Console.WriteLine($"сумма чисел нечетных индексов в массиве newMass - {P}");    
}       
newMass2();
