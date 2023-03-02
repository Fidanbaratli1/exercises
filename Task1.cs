//Verilmiş ədədlər siyahısını artan sıra ilə düzülmüş ədədlər halına gətirən alqoritm.
using System;

int[] numbers = { 12, 3, 1, 6 };

for(int i = 0; i < numbers.Length; i++)
{
    for (int j=i+1; j < numbers.Length; j++)
    {
        if (numbers[j] < numbers[i])
        {
            
         int temp = numbers[i];
            numbers[i] = numbers[j];
            numbers[j] = temp;
            Console.WriteLine(numbers);
        }
    }
   
} 



}




    


