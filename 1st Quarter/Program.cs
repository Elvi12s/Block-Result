
// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]git rm -r --cached
// [“Russia”, “Denmark”, “Kazan”] → []

Console.WriteLine("Введите количество элементов массива: ");
int M = Convert.ToInt32(Console.ReadLine());
string[] array = new string[M];
  for (int i = 0; i < array.Length; i++)
  {
    Console.WriteLine($"Введите элемент №{i+1} массива:");
    array[i] = Convert.ToString(Console.ReadLine());
  }

Console.WriteLine();
for (int i = 0; i < array.Length; i++)
{
  if (array[i].Length < 4)  Console.Write($"{array[i]}  ");
  else array[i]= String.Empty;
}
Console.WriteLine();
