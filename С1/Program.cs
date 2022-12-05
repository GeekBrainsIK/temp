Console.Clear();
Console.Write("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA == numberB)
   {Console.WriteLine("Число A равно числу B ");}
  else if (numberB > numberA)
    {Console.WriteLine("Число B больше числа A ");}
  else 
    {Console.WriteLine("Число A больше числа B ");}