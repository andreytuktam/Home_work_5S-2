//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

void newMass3(){
    int length = new Random().Next(1, 10);
    Console.WriteLine($"массив newMass состоит из {length} чисел");
    double[] newMass = new double[length];
    double Pmax = newMass[0];
    double Pmin = newMass[0];
    for (int i = 0; i < length; i++)
    {
        newMass[i] = new Random().Next(100, 1000);
    }
        for (int j = 0; j < length; j++){

            if (newMass[j] > Pmax)
            {
                Pmax = newMass[j];
            } 
            else 
            {  
                Pmin = newMass[j];
            }        
        }
Console.WriteLine($"{Pmax} - максимальное число");
Console.WriteLine($"{Pmin} - минимальное число");
Console.WriteLine($"{Pmax - Pmin} - разница максимального и минимального чисел массива");
}
newMass3();
