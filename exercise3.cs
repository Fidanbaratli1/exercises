//Verilmiş artan sıra ilə düzülmüş ədədlər siyahısındaki n ədədinin yerləşdiyi indexi tapan alqoritm (binary search);
using System.ComponentModel.Design;

int[] arr = { 0, 4, 8, 11, 13, 17, 26, 39,41 };
int minimum = 0;
int maximum = arr.Length-1;
int x=8;
while(minimum < maximum)
{
    int middle=(minimum+maximum)/2;
    if (arr[middle] == x)
    {
        Console.WriteLine(middle);
        break;
    }
    else if (arr[middle] >x)
    {
        maximum = middle - 1;
    }
    else if (arr[middle] < x)
    {
        minimum = middle + 1;
    }
    else
    {
        Console.WriteLine(-1);
    }
}




    
