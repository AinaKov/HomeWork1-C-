while (true)
    {
    Console.WriteLine("Хотите узнать какое число больше? Если хотите выйти из программы - напишите no");
    string answer = Console.ReadLine();
    if(answer == "no")
    {
        break;
    }
    Console.WriteLine("Введите первое число");
    int number1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите второе число");
    int number2 = Convert.ToInt32(Console.ReadLine());

    if(number1 > number2)
    {
       Console.WriteLine("Наибольшее число первое");
       Console.WriteLine(number1);
    }
    else
    {
       Console.WriteLine("Наибольшее число второе");
       Console.WriteLine(number2);
    }
    }