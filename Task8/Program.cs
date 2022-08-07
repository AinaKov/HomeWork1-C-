while (true)
{
    Console.WriteLine("Хотите узнать все четные числа до числа N? Если хотите выйти из программы - напишите end");
    string answer = Console.ReadLine();
    if(answer == "end")
     {    
     break;
     }
    Console.WriteLine("Введите число N");
    int number = Convert.ToInt32(Console.ReadLine());
    int number1 = 2;
         if(number >= 2)
         {
            while (number1 <= number)
             {
                Console.Write(number1 );
                Console.Write(", ");
                number1 = number1 + 2;
             }
         }
         else  
         {
          Console.WriteLine("Таких чисел не сущестует");
         }
     Console.WriteLine(" ");
}