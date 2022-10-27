﻿// Задачи семинаров по теме "Знакомство с языком программирования С#
/*
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
*/  

    
Console.WriteLine("Решение задач урока 3 с использованием методов\n");


bool DefPalindromFiveDigit(int num) //задача 19 - является ли пятизначное число палиндромом
{
    int numForConvert = num;
    
    int dimPalindrom = 2; // длина половины палиндрома нечетной размерности без середины, на будущее 
    int firstFig = 0;
    int secondFig = 0;
    
// цикл делается для того, чтобы можно было модернизировать метод до проверки любых нечетных палиндромов
    for (int i = dimPalindrom; i >= 1; i--) {
       
// определене первой и последней цифры вынесено в отдельные операторы для удобства
        firstFig = (int)(numForConvert / Math.Pow(10, (i * 2)));
        secondFig = numForConvert % 10;
            
        if (firstFig != secondFig) {return (false); }
        else {
            numForConvert = (int)(numForConvert % Math.Pow(10, (i * 2))) / 10;
        }
    }
    return (true);
}
 

// В решении задачи 21 использую олдскульный подход - модифицирую глобальные переменные, 
// что, как понимаю, делает написанный ниже фрагмент не методом, а подпрограммой

int[] coordTmp = {0, 0, 0};

int[] coordFirst = {0, 0, 0};
int[] coordSecond = {0, 0, 0};


bool InputMassConsole() // Считываем строку и выделяем их нее три координаты, иначе - ошибка
{
    int flagCoordinats = 0;  // позиция в массиве вычисленных координат: 0 - X, 1 - Y, 2 - Z для внешнего массива coordTmp[]

    string? arrayText = Console.ReadLine();  // введенная текстом координата
    string comma = ","; 
    arrayText = arrayText + comma;

    int[] arrayNum = new int[(int)(arrayText.Length)]; // введенная текстом координата, переведенная в цифры
    int indexCoordinat = 0; // индекс для создания массива цифр - введенной текстом координаты, переведенная в цифры
    int flagSign = 1;
    int bitDepth = 0;  // разрядность введенного числа - считается при анализе текстовой строки
    int tmp = 0; // переменная для черновых расчетов, всегда обнуляется перед использованием

    for (int i = 0; i < arrayText.Length; i++) {
        
        if (arrayText[i] != ',' && arrayText[i] != ' ') {            
            if (arrayText[i] > '9' && arrayText[i] != '-') return(false);  //если введена не цифра, минус, запятая или пробел - ошибка ввода
            
            if (arrayText[i] == '-') flagSign = -1;
            else {
                arrayNum[indexCoordinat] = arrayText[i] - '0';

                //Console.Write($"IF Ц позиция {indexCoordinat} значение {arrayNum[indexCoordinat]}\n");
                indexCoordinat++; 
                bitDepth++; 
            } 
        } 
        else {
            if (flagCoordinats > 2) return(false); // если введено больше 3 координат - ошибка ввода
            if (arrayText[i] != ' ') {         // при вводе пробела ничего не вычисляется
                if (arrayText[i] == '-') flagSign = -1;  // определяем знак - координата может быть отрицательной
                tmp = 0;
                
                for (int j = 0; j < indexCoordinat; j++) {
                    bitDepth--;
                    //Console.Write($"FOR З позиция {j} значение {arrayNum[j]} степень 10 {bitDepth}\n");
                    tmp = tmp + arrayNum[j] * (int)Math.Pow(10, bitDepth);
                }
             
            tmp = tmp * flagSign;
            coordTmp[flagCoordinats] = tmp;
            //Console.Write($"координата {flagCoordinats} значение {coordTmp[flagCoordinats]}\n");  
            //Console.Write($"координата {flagCoordinats} значение {coordTmp[flagCoordinats]}\n");
            if (flagCoordinats == 2) break; else flagCoordinats++;
            indexCoordinat = 0;
            flagSign = 1;
            bitDepth = 0;
                
            }

        } 
    }
    if (flagCoordinats < 2) return(false); // если введено меньше 3 координат - ошибка ввода
    //Console.Write($" Результат {coordTmp[0]} {coordTmp[1]} {coordTmp[2]}\n");
    return(true);
}
 


double DistPointThreeDimSpace()   // определение расстояния между точками в трехмерном пространстве
{
    int[] vectorArr = {1, 1, 1};
    double vectorLenght = 0;

    for (int i = 0; i <= 2; i++) {
        vectorArr[i] = coordFirst[i] - coordSecond[i];
        //Console.Write(vectorArr[i]);
        vectorLenght = vectorLenght + (int)Math.Pow(vectorArr[i], 2);
    }

    vectorLenght = Math.Sqrt(vectorLenght);
    return vectorLenght;
    
}

// Метод Задачи 23 - вывод кубов да заданного числа

void AllCube(int mCube)  // Выводит кубы чисел от нуля до заданного с учетом знака
{
    int startNum = 1;
    int stepNum = 1;
    
    if (mCube == 0) return;
    Console.Write($"{mCube} -> "); 
    
    if (mCube < 0 ){
        startNum = -1;
        stepNum = -1;
    }
        
    do {
        Console.Write($"{Math.Pow(startNum, 3)}, ");
        startNum = startNum + stepNum;
    }
    while (startNum * stepNum < mCube * stepNum);

    Console.Write($"{Math.Pow(startNum, 3)}\n");
}



/*
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

*/

Console.Write("Задача 19 - является ли пятизначное число палиндромом\n");
    
    bool flag = true;

    Console.Write("Введите целое пятизначное число > ");
    int oneNum = Convert.ToInt32(Console.ReadLine());

    if (oneNum < 10000 || oneNum > 99999) Console.Write("Недопустимое значение ввода\n\n");
    else {
        flag = DefPalindromFiveDigit(oneNum); 
        if (flag) Console.Write($"Число {oneNum} является палиндромом\n\n");
        else Console.Write($"Число {oneNum} не является палиндромом\n\n");
    }


Console.Write("Задача 21 - расстояние между двумя точками в трехмерном пространстве\n\n");

        
    Console.Write("Введите через запятую три координаты первой точки > ");
    bool firstReturn = InputMassConsole();
    bool secondReturn = false;

    if (firstReturn) {
        for (int k = 0; k < 3; k++) {
           coordFirst[k] = coordTmp[k];
        }
        
        Console.Write("Введите через запятую три координаты второй точки > ");
        secondReturn = InputMassConsole();
        
        if (secondReturn) {
            for (int l = 0; l < 3; l++) {
                coordSecond[l] = coordTmp[l];
            }
            double distPoint = DistPointThreeDimSpace();
            Console.Write($"Расстояние {distPoint}\n\n");
        }
       
    
    }


Console.Write("Задача 23 - вывод кубов до заданного числа с учетом знака\n\n");
        
    Console.Write("Введите целое число > ");
    int maxCubeNum = Convert.ToInt32(Console.ReadLine());
    AllCube(maxCubeNum);

    

    
    

    

    



    
  
 


  
    

  

