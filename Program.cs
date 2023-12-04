/*
Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. 
 При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами
*/



    
        Console.WriteLine("Введите количество элементов массива:");
        int n = Convert.ToInt32(Console.ReadLine());
        
        string[] originalArray = new string[n];
        Console.WriteLine("Введите элементы массива:");

        for (int i = 0; i < n; i++)
        {
            originalArray[i] = Console.ReadLine();
        }

        string[] newArray = FilterArray(originalArray);

        Console.WriteLine("Новый массив:");
        foreach (string element in newArray)
        {
            Console.WriteLine(element);
        }
    

    static string[] FilterArray(string[] originalArray)
    {
        int count = 0;

        foreach (string element in originalArray)
        {
            if (element.Length <= 3)
            {
                count++;
            }
        }

        string[] newArray = new string[count];
        int index = 0;

        foreach (string element in originalArray)
        {
            if (element.Length <= 3)
            {
                newArray[index] = element;
                index++;
            }
        }

        return newArray;
    }
