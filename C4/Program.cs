Console.Clear();
Console.Write("Введите начало числового диапазона: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите окончание числового диапазона: ");
int numberB = Convert.ToInt32(Console.ReadLine());
for (int i = numberA; i <= numberB; i++)
{if (i % 2 == 0)
   {Console.WriteLine(i + " ");}
}