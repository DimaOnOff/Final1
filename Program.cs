// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с 
// клавиатуры, либо задать на старте выполнения алгоритма. При решении 
// не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

Console.Write("Enter size of array: ");
int n=int.Parse(Console.ReadLine());

string[] array = Enter(n);
Console.WriteLine($"Your array: [{String.Join(" ", array)}]");
Console.WriteLine(" ");

string[] array3 = Check3(n);
Console.WriteLine($"Array <=3: [{String.Join(" ", array3)}]");


string[] Enter(int size)
{
    string[] array = new string[size];
        for (int i = 0; i < size; i++)  
        {
            Console.WriteLine($"Enter {i+1} element of array size {n} : ");
            array [i] = Console.ReadLine();
        }
        return array;
}

string[] Check3(int size)
{
    string[] array3 = new string[size];
    for (int i = 0; i < array3.Length; i++)
    {
        if(array[i].Length <=3) 
        array3[i] = array[i];
    }
    return array3;
}





