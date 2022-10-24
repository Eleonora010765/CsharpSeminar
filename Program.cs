// Задачи семинаров по теме "Знакомство с языком прграммирования С#

Console.WriteLine("Решение задач первого семинара с использованием методов\n");

int MaxOfTwo(int one, int two) //задача 2 - максимум из двух чисел
{
    int max = one;
    if (two >= max) max = two;
    return (max);
}

int MaxOfThree(int one, int two, int three) //задача 4 - максимум из трёх чисел
{
    int max = one;
    if (two >= max) max = two;
    if (three >= max) max = three;
    return (max);
}

bool ParityCheck(int num) //задача 6 - проверка чётности
{
    if (num % 2 == 0) return(true);
    return (false);
}

void ParityPrint(int num) //задача 8 - печать чётных чисел до заданного числа
{
    if (num >= -1 && num <=1) return;
    if (num > 0) { int i = 2;
        while (i <= num) {
            Console.Write(" " + i + " ");
            i += 2;
        }
        Console.Write("\n\n");
    }
    else { int i = -2;
        while (i >= num) {
            Console.Write(" " + i + " ");
            i -= 2;
        }
        Console.Write("\n\n");
        return;
    }
}

void SecondPoint(int num) //задача 10 - вывод второй цифры трёхзначного числа
{
    if (num >= 1000 || num <=99) {
        Console.Write("Недопустимое значение\n\n");
        return;
    }
    int rezult = num % 100 / 10;
    Console.Write("Вторая цифра числа " + num + " - " + rezult + "\n\n");
}

void ThirdPoint(int num) //задача 13 - вывод третьей цифры заданного числа
{
    if (num < 100) {
        Console.Write("Недопустимое значение\n\n");
        return;
    }
    int rezult = num;
    while (rezult > 1000) rezult = rezult / 10;
    
    rezult = rezult % 10;
    Console.Write("Третья цифра числа " + num + " - " + rezult + "\n\n");
}

bool DayCheck(int num) //задача 15 - проверка выходного
{
    if (num == 6 || num == 7) return(true);
    return (false);
}


//Решение Задачи 2 - максимум из двух
    Console.Write("Задача 2 - максимум из двух чисел\n");
    
    Console.Write("введите первое число > ");
    int oneNum = Convert.ToInt32(Console.ReadLine());
    
    Console.Write("введите второе число > ");
    int twoNum = Convert.ToInt32(Console.ReadLine());
    
    int rezult = MaxOfTwo(oneNum, twoNum); //вызов метода - если я правильно понимаю
    Console.Write("Максимум из " + oneNum + " и " + twoNum + " равен " + rezult + "\n\n");

//Решение Задачи 4 - максимум из трех
    Console.Write("Задача 4 - максимум из трёх чисел\n");
    
    Console.Write("введите первое число > ");
    oneNum = Convert.ToInt32(Console.ReadLine());
    
    Console.Write("введите второе число > ");
    twoNum = Convert.ToInt32(Console.ReadLine());
    
    Console.Write("введите третье число > ");
    int threeNum = Convert.ToInt32(Console.ReadLine());
      
    rezult = MaxOfThree(oneNum, twoNum, threeNum);  //вызов метода - если я правильно понимаю
    Console.Write("Максимум из " + oneNum + ", " + twoNum + " и " + threeNum + " равен " + rezult + "\n\n");
 
//Решение Задачи 6 - проверка чётности
    Console.Write("Задача 6 - проверка чётности\n");
    
    Console.Write("введите число > ");
    oneNum = Convert.ToInt32(Console.ReadLine());

    //вызов метода - если я правильно понимаю
    if (ParityCheck(oneNum) == true) Console.Write("Число " + oneNum + " чётное\n\n");
    else Console.Write("Число " + oneNum + " нечётное\n\n");
  
//Решение Задачи 8 - вывод чётных до предела
    Console.Write("Задача 8 - вывод чётных до предела\n");
    
    Console.Write("введите число > ");
    oneNum = Convert.ToInt32(Console.ReadLine());

    //вызов метода - если я правильно понимаю
    ParityPrint(oneNum);
   

//Решение Задачи 10 - вывод второй цифры трёхзначного числа
    Console.Write("Задача 10 - вывод второй цифры трёхзначного числа\n");
    
    Console.Write("введите трёхзначное число > ");
    oneNum = Convert.ToInt32(Console.ReadLine());

    //вызов метода - если я правильно понимаю
    SecondPoint(oneNum); 


//Решение Задачи 13 - вывод третьей цифры заданного числа
    Console.Write("Задача 13 - вывод третьей цифры заданного числа\n");
    
    Console.Write("введите любое число больше 99 > ");
    oneNum = Convert.ToInt32(Console.ReadLine());

    //вызов метода - если я правильно понимаю
    ThirdPoint(oneNum); 

//Решение Задачи 15 - проверка выходного
    Console.Write("Задача 15 - проверка выходного\n");
    
    Console.Write("введите номер дня недели > ");
    oneNum = Convert.ToInt32(Console.ReadLine());
    if (oneNum < 1 || oneNum > 7) Console.Write("Недопустимое значение дня недели\n\n");
    else {
        //вызов метода - если я правильно понимаю
        if (DayCheck(oneNum) == true) Console.Write("День " + oneNum + " выходной\n\n");
        else Console.Write("День " + oneNum + " рабочий\n\n");
    }

    
  
 


  
    

  

