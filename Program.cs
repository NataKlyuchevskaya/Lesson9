void Zadacha64() 
{ 
    //Задайте значения M и N. Напишите программу, которая выведет все   
    //натуральные числа кратные 3-ём в промежутке от M до N. 

    Console.WriteLine("Введите первое число: "); 
    int m = Convert.ToInt32(Console.ReadLine()); 
    Console.WriteLine("Введите второе число: "); 
    int n = Convert.ToInt32(Console.ReadLine()); 
 
    int number = 3; 
 
    Console.Write("Ответ: "); 
    for (int i = m; i <= n; i++) 
    { 
        if (i % number == 0) 
        { 
            Console.Write(i + " "); 
        } 
    } 
} 
 
 
 
void Zadacha66() 
{ 
    //Задайте значения M и N. Напишите программу, которая найдёт сумму  
    //натуральных элементов в промежутке от M до N. 
 
    Console.WriteLine("Введите первое число: "); 
    int m = Convert.ToInt32(Console.ReadLine()); 
    Console.WriteLine("Введите второе число: "); 
    int n = Convert.ToInt32(Console.ReadLine()); 
    int OTVET = SumNaturalNumbers(m, n); 
    Console.Write("Сумма натуральных элементов равна: ");
    Console.WriteLine(OTVET); 
 
    int SumNaturalNumbers(int firstNumber, int lastNumber, int answer = 0) 
    { 
        answer += firstNumber; 
        if (firstNumber == lastNumber) 
        { 
            return answer; 
        } 
        else 
        { 
            return SumNaturalNumbers(++firstNumber, lastNumber, answer); 
        } 
    } 
} 
 
 
 
 
//Напишите программу вычисления функции Аккермана с помощью  
//рекурсии. Даны два неотрицательных числа m и n.   m = 2, n = 3 -> A(m,n) = 9 
 
void ZadachaAkkerman() 
{ 
    Console.WriteLine("Введите первое число: "); 
    double m = Convert.ToDouble(Console.ReadLine()); 
    Console.WriteLine("Введите второе число: "); 
    double n = Convert.ToDouble(Console.ReadLine()); 
    double answer = Akkerman(m, n); 
    Console.WriteLine($"Ответ: {answer}");  
} 

double Akkerman(double m, double n) 
{ 
    if (m == 0) 
    { 
        double result = n + 1; 
        return result; 
    } 
    else if (m > 0 && n == 0) 
    { 
        return Akkerman(m - 1, 1); 
    } 
    else 
    { 
        return Akkerman(m - 1, Akkerman(m, n - 1)); 
    } 
} 
 
//Zadacha64(); 
//Zadacha66(); 
ZadachaAkkerman();