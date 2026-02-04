/* Problem Statement

Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

Rules:

Each input has exactly one solution

You may not use the same element twice

You can return the answer in any order

*/


class Program
{
    public void Main()
    {
        Console.WriteLine($"Array length: ");
        int qntd = int.Parse(Console.ReadLine());

        int [] array = new int [qntd]; 

        for(int i = 0; i < array.length; i++)
        {
            Console.WriteLine($"Index {i + 1}/{qntd}: ");
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine($"Target: ");
        int target = int.Parse(Console.ReadLine());
        int cont = 0;
        int [] ArrayTargets = new int [target]; 

        do
        {
            for(int i = 0; i < array.lenght; i++)
            {
                if(array[i] + cont <= target)
                {
                    cont += array[i];
                    ArrayTargets[i] = array[i];
                }
            }
        } while (cont != target);

        for(int i = 0; i < ArrayTargets.lenght; i++)
        {
            Console.WriteLine($"Index: {i} + ");
        }
        
        Console.WriteLine($"Target: {target}");
    }
} 