while (true)
{
   Console.WriteLine("Давайте узнаем - четное ли число? напишите end, если хотите выйти из программы");
   string answer = Console.ReadLine();
      if(answer == "end")
       {    
       break;
       }
   Console.WriteLine("Введите число");
   int number1 = Convert.ToInt32(Console.ReadLine());
    if(number1 % 2 == 0)
    {
    Console.WriteLine("Число четное"); 
    }
    else
    {
    Console.WriteLine("Число нечетное");
    }
}