// Задача: Написать программу, которая из имеющегося массива строк 
// формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.


string[] family = new String[7] { "Я", "мама", "папа", "сын", "собака", "", "иЯ"}; ;

for (int i = 0; i < family.Length; i++)
{
    Console.WriteLine(family[i]);
}

System.Console.WriteLine();
System.Console.WriteLine();

string[] newFamily = new String[7];

for (int i = 0; i < family.Length; i++)
{
    if (family[i].Length <= 3)
    {
        newFamily [i] = family[i];
        Console.WriteLine(newFamily[i]);
        }
}





