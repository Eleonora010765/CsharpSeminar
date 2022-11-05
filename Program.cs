// Задачи семинаров по теме "Знакомство с языком программирования С#
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


// Методы к уроку 4

// "Метод Задачи 25 - возведение в степень, где основание и степень вводятся вручную\n\n"

bool NumToGivenDegree()  // Выводит кубы чисел от нуля до заданного с учетом знака
{
    int tmpNum = 0;
    int tmpDegree = 0;
    string? flagContinue = "y";
    do {
        Console.Write("Введите основание A (любое целое число, кроме нуля) > ");
        tmpNum = Convert.ToInt32(Console.ReadLine()); 
        if (tmpNum == 0) return(false);

        Console.Write("Введите степень B (натуральное число) > ");
        tmpDegree = Convert.ToInt32(Console.ReadLine());
        if (tmpDegree < 0) return(false);
        Console.Write($"{tmpNum} в степени {tmpDegree} равно {Math.Pow(tmpNum, tmpDegree)}. Продолжить? y/n > ");
        flagContinue = Console.ReadLine();
    } while (flagContinue == "y");
    return(true);
}


// Метод Задачи 27 - подсчет суммы цифр введенного целого числа
        
int SumOfDigit(int argNum)  
{
    int argRez = 0;
    int tmpNum = argNum;
    
    do {
        argRez = argRez + (tmpNum % 10);
        tmpNum = tmpNum / 10;
    } while ((tmpNum * 10) > 10);
    return(argRez);
}


// "Метод Задачи 29 - создание массива заданной размерности и вывод его на экран

void CreateArrayOnDisplay(int numElem)  
{
    int[] tmpArray = new int[numElem];
    Random tmpRand = new Random();

    Console.Write($"Массив из {numElem} элементов > ");

    for (int n = 0; n < numElem-1; n++) {
        tmpArray[n] = tmpRand.Next(0, 100);
        Console.Write($"{tmpArray[n]}, ");
    }
    tmpArray[numElem-1] = tmpRand.Next(0, 100); // присвоение значения последнему элементу вынесено для красивого вывода - отсутсвие запятой и перевод строки
    Console.Write($"{tmpArray[numElem-1]}\n\n");
}
*/
/*
// Методы к уроку 5

// "Методы Задачи 34 - 1) заполнение массива заданной размерности, 2) подсчёт четных чисел в массиве\n\n"

void ArrayThreeDigit(int dimThDigit, int[] arrThDigit)  // заполнение массива заданной размерности трёхзначными числаим
{
    Random tmpRand = new Random();

    for (int n = 0; n < dimThDigit; n++) {
        arrThDigit[n] = tmpRand.Next(100, 999);
    }
}

int DimensionOfEvenNum(int dimThDigit, int[] arrThDigit)    // подсчёт четных чисел в массиве целых
{
    int countEvenNum = 0;
    
    for (int n = 0; n < dimThDigit; n++) if (arrThDigit[n] % 2 == 0) countEvenNum++;
    
    return(countEvenNum);
}


// Метод Задачи 38 - определение максимума в массиве
        
int MaxTask38(int dimDigit, int[] arrDigit)  
{
    int maxRez = arrDigit[0];

    if (dimDigit == 1) return(maxRez);
    
    for (int n = 1; n < dimDigit; n++) if (arrDigit[n] > maxRez)  maxRez = arrDigit[n];
    
    return(maxRez);
}


// "Метод Задачи 38 - определение минимума в массиве

int MinTask38(int dimDigit, int[] arrDigit)   
{
    int minRez = arrDigit[0];

    if (dimDigit == 1) return(minRez);
    
    for (int n = 1; n < dimDigit; n++) if (arrDigit[n] < minRez) minRez = arrDigit[n];
    
    return(minRez);
}
*/

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



Console.Write("Задача 19 - является ли пятизначное число палиндромом\n");
    
    bool flag = true;

    Console.Write("Введите целое пятизначное число > ");
    int oneNum = Convert.ToInt32(Console.ReadLine());

    if (oneNum < 10000 || oneNum > 99999) { Console.Write("Недопустимое значение ввода\n\n");
    else {
        flag = DefPalindromFiveDigit(oneNum); 
        if (flag) Console.Write($"Число {oneNum} является палиндромом\n\n\n");
        else Console.Write($"Число {oneNum} не является палиндромом\n\n\n");
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
            Console.Write($"Расстояние {distPoint}\n\n\n");
        } else Console.Write("Ошибка ввода\n\n\n");
    }  
    else Console.Write("Ошибка ввода\n\n\n");

Console.Write("Задача 23 - вывод кубов до заданного числа с учетом знака\n\n");
        
    Console.Write("Введите целое число > ");
    int maxCubeNum = Convert.ToInt32(Console.ReadLine());
    AllCube(maxCubeNum);



// Задачи урока 4


Console.Write("Задача 25 - обращение к методу возведения в степень, где основание и степень вводятся вручную\n\n");
Console.Write("Предупреждение! Поскольку мы не работали с представлением чисел float, используется тип int\n\n");
        
    Console.Write("Вызвать метод возведения целого заданного в натуралную заданную степень? y/n > ");
    string? flagExit = Console.ReadLine();
    bool rezExp = false;

// только при ответе y вызываем метод возведения в степень bool NumToGivenDegree()? весь ввод-вывод внутри метода
    if (flagExit == "y") {
        rezExp = NumToGivenDegree();
        if (!rezExp) Console.Write("Ошибка ввода\n\n\n");
    }


Console.Write("Задача 27 - обращение к методу подсчета суммы цифр введенного целого числа\n\n");
        
    Console.Write("Введите целое число больше нуля > ");
    int tmpInt = Convert.ToInt32(Console.ReadLine()); 

    int rezSum = SumOfDigit(tmpInt);
    Console.Write($"Сумма цифр числа {tmpInt} -> {rezSum} \n\n\n");


     
Console.Write("Задача 29 - обращение к методу создания массива заданной размерности и вывода его на экран\n\n");
Console.Write("Чтобы не загромождать вывод, числа генерируем в пределах 100\n\n");
        
    Console.Write("Введите размерность массива > ");
    int dimensOfArray = Convert.ToInt32(Console.ReadLine()); 

    CreateArrayOnDisplay(dimensOfArray);     
*/ 

/*
// Задачи урока 5


Console.Write("Задача 34 - заполнение массива заданной размерности случайными трехзначными числами, подсчёт четных чисел в этом массиве\n\n");
//Console.Write("Предупреждение! Поскольку мы не работали с представлением чисел float, используется тип int\n\n");
    

    Console.Write("Введите размерность массива > ");
    int dimOfThreeArray = Convert.ToInt32(Console.ReadLine());
    int[] arrayOfThreeDigit = new int[dimOfThreeArray];

    int numOfEvenNum = 0;

    ArrayThreeDigit(dimOfThreeArray, arrayOfThreeDigit);  // заполнение массива выделено в отдельную функцию в учебных целях
    numOfEvenNum = DimensionOfEvenNum(dimOfThreeArray, arrayOfThreeDigit);
    
    Console.Write($"В массиве из {dimOfThreeArray} элементов > ");
    for (int n = 0; n < dimOfThreeArray-1; n++) Console.Write($"{arrayOfThreeDigit[n]}, ");
    Console.Write($"{arrayOfThreeDigit[dimOfThreeArray-1]} содержится {numOfEvenNum} четных элементов \n\n\n"); 

     
Console.Write("Задача 36 - заполнение массива случайными числами, подсчет суммы элементов нечётных позиций\n\n");
Console.Write("Чтобы не загромождать вывод, числа генерируем в пределах модуля 100\n\n");
Console.Write("Просто для разнообразия не вызываем методы, все делаем прямо здесь\n\n");
        
    Console.Write("Введите размерность массива > ");
    int dimensOfArrayTask36 = Convert.ToInt32(Console.ReadLine()); 
    int[] arrayOfTask36 = new int[dimensOfArrayTask36];

    Random numRandTask36 = new Random();

    int rezultTask36 = 0;

    Console.Write($"Сумма чисел на нечетных позициях массива из {dimensOfArrayTask36} элементов > ");

    for (int n = 0; n < dimensOfArrayTask36; n++) {
        arrayOfTask36[n] = numRandTask36.Next(-100, 100); 
        Console.Write($"{arrayOfTask36[n]}  ");
        if (n % 2 == 0) rezultTask36 = rezultTask36 + arrayOfTask36[n];
    }

    Console.Write($"составляет {rezultTask36}\n\n\n");
  

     
Console.Write("Задача 38 - заполнение массива вещественными числами, подсчет разницы между min и max\n\n");
Console.Write("Чтобы не загромождать вывод, числа генерируем в пределах 100\n\n");
Console.Write("Для корректного решения задачи не хватает знаний о генераторе случайных чисел типа float\n\n");
        
    Console.Write("Введите размерность массива > ");
    int dimensOfArrayTask38 = Convert.ToInt32(Console.ReadLine()); 
    int[] arrayOfTask38 = new int[dimensOfArrayTask38];

    Random numRandTask38 = new Random();
    
    Console.Write($"Разница между минимальным и максимальным элементом массива из {dimensOfArrayTask38} элементов > ");

    for (int n = 0; n < dimensOfArrayTask38; n++) {
        arrayOfTask38[n] = numRandTask38.Next(0, 100); 
        Console.Write($"{arrayOfTask38[n]}  ");
        
    }
    
    Console.Write($" > составляет {MaxTask38(dimensOfArrayTask38, arrayOfTask38) - MinTask38(dimensOfArrayTask38, arrayOfTask38)}\n\n\n");

*/
/* разобралась с типами чисел и их выводом, и с массивами
Random m = new Random();
//m.NextDouble();
double i = Math.Round(m.NextDouble()*10, 2);
Console.Write($"i = {Math.Round(i, 1)}  ");


int[] array1 = {1, 2, 3};
int[] array2 = {3, 4, 5};
int[] array3 = array1.Concat(array2).ToArray();
Console.WriteLine(String.Join(",", array3));
    
*/

// Методы к уроку 6

// Метод задачи 41 - ввод заданного количества целых чисел через запятую, возврат массива этих чисел 
// Переработан из метода задачи 21

int[] InputMassConsole() // Считываем строку и выделяем их нее целые числа 
{

    int[] arrayTmp = {0};
    int[] arrayInput = {};

    string? arrayText = Console.ReadLine();  // введенные числа
    string comma = ","; 
    arrayText = arrayText + comma;  // добавляем запятую, чтобы не выделять анализ "конец строки"
    
    int flagSign = 1; // множитель знака числа - при вводе '-' присваивается -1 
    
    int tmp = 0; // переменная для черновых расчетов, всегда обнуляется перед использованием

    for (int i = 0; i < arrayText.Length; i++) {
        
        if (arrayText[i] != ',' && arrayText[i] != ' ') {            
            if (arrayText[i] > '9' && arrayText[i] != '-') {    //если введена не цифра, минус, запятая или пробел - учитывает только ранее введенные цифры
                Console.Write($"ошибка ввода {arrayText[i]}\n");
                return(arrayInput);  
            }
            if (arrayText[i] == '-') flagSign = -1;  // определяем знак - число может быть отрицательным  
            else tmp = tmp * 10 + (arrayText[i] - '0');                
        } 
        else {
            if (arrayText[i] != ' ') {    // при вводе пробела ничего не вычисляется
            tmp = tmp * flagSign;         // учитываем знак '-', если есть  
            arrayTmp[0] = tmp;            // добавляем выделенное число в массив 
            arrayInput = arrayInput.Concat(arrayTmp).ToArray();
            
            flagSign = 1;   //  обнуляем знак и величину для ввода следующего числа
            tmp = 0;
            }

        } 
    }
    
    return(arrayInput);
}

// Метод задачи 41 - подсчет количества положительных чисел в массиве, возврат количества этих чисел 
int DitermineGreatNullArray(int[] arrayToCheckNull)
{
    int retNumGreatedNull = 0;

    for (int i = 0; i < arrayToCheckNull.Length; i++) if (arrayToCheckNull[i] > 0) retNumGreatedNull++;
    return(retNumGreatedNull);
}


Console.Write("Задача 41 - ввести с клавиатуры числа, вычислить, сколько из них больше 0\n\n");

    int[] arrayRowNum = {};

    Console.Write("Введите несколько целых чисел через запятую > ");
    arrayRowNum = InputMassConsole();

    int numGreatedNull = DitermineGreatNullArray(arrayRowNum);
    
    Console.WriteLine($"Количество чисел больше 0 > {numGreatedNull}\n\n\n");


double[] DiterminepointIntersection(double[] equatArray)
{
    double[] coordRet = {0, 0};

    coordRet[0] = (double)( (equatArray[3]-equatArray[1])/(equatArray[0]-equatArray[2]) );
    coordRet[1] = (double)( (equatArray[0] * ( (equatArray[3]-equatArray[1]) / (equatArray[0]-equatArray[2]) ) )+ equatArray[1] );
    return(coordRet);
}


Console.Write("Задача 43 - Вычислить точку пересечения прямых, заданных уравнением прямой\n\n");
Console.Write("Принимаем, что коэффициенты и постоянные - целые числа\n\n");

    double[] equationsLine = {0.0, 0.0, .0, .0}; 

    Console.Write("Уравнение первой прямой: введите целый коэффициент > ");
    int tmp1 = Convert.ToInt32(Console.ReadLine()); 
    equationsLine[0] = (double)tmp1;
    Console.Write("                         введите целую постоянную  > ");
    int tmp2 = Convert.ToInt32(Console.ReadLine()); 
    equationsLine[1] = (double)tmp2;
    Console.Write("Уравнение второй прямой: введите целый коэффициент > ");
    int tmp3 = Convert.ToInt32(Console.ReadLine()); 
    equationsLine[2] = (double)tmp3;
    Console.Write("                         введите целую постоянную  > ");
    int tmp4 = Convert.ToInt32(Console.ReadLine()); 
    equationsLine[3] = (double)tmp4;
    
    double[] pointIntersection;
    if (equationsLine[0] == equationsLine[2] && equationsLine[1] == equationsLine[3]) Console.WriteLine($"Прямые совпадают \n\n");
    else if (equationsLine[0] == equationsLine[2]) Console.WriteLine($"Прямые параллельны \n\n");
        else {
            pointIntersection = DiterminepointIntersection(equationsLine);
            Console.WriteLine($"Координаты точки пересечения > X = {pointIntersection[0]}, Y = {pointIntersection[1]}\n\n");
        }













    
    

    

    



    
  
 


  
    

  

