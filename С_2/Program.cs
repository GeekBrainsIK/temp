Console.Clear();
Console.Write("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число C: ");
int numberC = Convert.ToInt32(Console.ReadLine());
int max = 0;
if (numberA >= numberB && numberA >= numberC)
   {max = numberA;}
  else if (numberB >= numberA && numberB >= numberC)
    {max = numberB;}
  else 
    if (numberC >= numberA && numberC >= numberB)
    {max = numberC;}
Console.WriteLine("Максимальное число {0}",max);