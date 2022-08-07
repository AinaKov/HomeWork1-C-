while (true)
    {
    Console.WriteLine("Хотите узнать какое из трех чисел больше? Если хотите выйти из программы - напишите no");
    string answer = Console.ReadLine();
    if(answer == "no")
    {
        break;
    }
    Console.WriteLine("Введите первое число");
    int number1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите второе число");
    int number2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите третье число");
    int number3 = Convert.ToInt32(Console.ReadLine());

    if(number1 > number2 & number1 > number3)
       { 
        Console.WriteLine("Наибольшее число первое");
        Console.WriteLine(number1);
       }
    else if(number2 > number1 & number2 > number3)
         { 
         Console.WriteLine("Наибольшее число второе");
         Console.WriteLine(number2);
         } 
    else if(number3 > number1 & number3 > number2)
         { 
         Console.WriteLine("Наибольшее число третье");
         Console.WriteLine(number3);
         } 
    }