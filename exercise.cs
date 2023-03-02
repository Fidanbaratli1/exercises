using System.ComponentModel.Design;

int[] num1 = { 2, 4,7,12, 15 };
int[] num2 = { 2, 12, 9, 6, 7,8 };
int count = 0;
for (int i = 0; i < num1.Length; i++)
{
    for (int j = 0; j < num2.Length; j++)

        if (num1[i] == num2[j])
        {
            count++;
        }
}
        if (count == num1.Length)
        {
            Console.WriteLine("True");
        }
    
        else
        {
            Console.WriteLine("False");
        }


