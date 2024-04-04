using System;

class Program
{
    static void Main(string[] args)
    {
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("Оберіть завдання:");
            Console.WriteLine("1. Обчислити площу кільця");
            Console.WriteLine("2. Перевірити чи всі цифри тризначного числа однакові");
            Console.WriteLine("3. Перевірити чи точка знаходиться в області");
            Console.WriteLine("4. Вивести можливі імена за статтю");
            Console.WriteLine("5. Обчислити квадрат частки двох дійсних чисел");
            Console.WriteLine("6. Перевірити рівняння");
            Console.WriteLine("7. Вийти");

            char choice = Console.ReadKey().KeyChar;
            Console.WriteLine();

            switch (choice)
            {
                case '1':
                    CalculateRingAreaTask();
                    break;
                case '2':
                    CheckDigitsTask();
                    break;
                case '3':
                    CheckPointInRegionTask();
                    break;
                case '4':
                    DisplayNamesByGender();
                    break;
                case '5':
                    CalculateSquareOfQuotientTask();
                    break;
                case '6':
                    CheckEquation();
                    break;
                case '7':
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Неправильний вибір. Спробуйте ще раз.");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void CalculateRingAreaTask()
    {
        Console.WriteLine("Введіть внутрішній радіус кільця (r1): ");
        double r1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введіть зовнішній радіус кільця (r2): ");
        double r2 = Convert.ToDouble(Console.ReadLine());

        double area = CalculateRingArea(r1, r2);
        Console.WriteLine($"Площа кільця з внутрішнім радіусом {r1} і зовнішнім радіусом {r2} дорівнює {area}");
    }

    static double CalculateRingArea(double r1, double r2)
    {
        double area1 = Math.PI * r2 * r2; // Площа зовнішнього кола
        double area2 = Math.PI * r1 * r1; // Площа внутрішнього кола
        double area = area1 - area2; // Площа кільця
        return area;
    }

    static void CheckDigitsTask()
    {
        Console.WriteLine("Введіть тризначне число:");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number >= 100 && number <= 999)
        {
            int digit1 = number / 100; // Отримати першу цифру
            int digit2 = (number / 10) % 10; // Отримати другу цифру
            int digit3 = number % 10; // Отримати третю цифру

            if (digit1 == digit2 && digit2 == digit3)
            {
                Console.WriteLine("Усі цифри числа однакові.");
            }
            else
            {
                Console.WriteLine("Цифри числа різні.");
            }
        }
        else
        {
            Console.WriteLine("Введене число не є тризначним.");
        }
    }

    static void CheckPointInRegionTask()
    {
        Console.WriteLine("Введіть координати точки (x, y):");
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());

        bool isInsideX = x >= 0 && x <= 12;
        bool isInsideY = y >= 0 && y <= x;

        if (isInsideX && isInsideY)
        {
            Console.WriteLine("Так");
        }
        else if (!isInsideX && !isInsideY)
        {
            Console.WriteLine("Ні");
        }
        else
        {
            Console.WriteLine("На межі");
        }
    }

    static void DisplayNamesByGender()
    {
        Console.WriteLine("Введіть стать (м - чоловік, ж - жінка):");
        char gender = Console.ReadLine()[0];

        if (gender == 'м' || gender == 'ж')
        {
            if (gender == 'м')
            {
                DisplayMaleNames();
            }
            else
            {
                DisplayFemaleNames();
            }
        }
        else
        {
            Console.WriteLine("Некоректний ввід статі.");
        }
    }

    static void DisplayMaleNames()
    {
        Console.WriteLine("Можливі чоловічі імена:");
        Console.WriteLine("Олег");
        Console.WriteLine("Іван");
        Console.WriteLine("Петро");
        // Додайте інші чоловічі імена за необхідності
    }

    static void DisplayFemaleNames()
    {
        Console.WriteLine("Можливі жіночі імена:");
        Console.WriteLine("Ольга");
        Console.WriteLine("Ірина");
        Console.WriteLine("Марія");
        // Додайте інші жіночі імена за необхідності
    }

    static void CalculateSquareOfQuotientTask()
    {
        Console.WriteLine("Введіть перше число:");
        double number1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введіть друге число:");
        double number2 = Convert.ToDouble(Console.ReadLine());

        double result = SquareOfQuotient(number1, number2);
        Console.WriteLine($"Квадрат частки {number1} і {number2} дорівнює {result}");
    }

    static double SquareOfQuotient(double a, double b)
    {
        if (b == 0)
        {
            Console.WriteLine("Помилка: Друге число не може бути нулем.");
            return double.NaN;
        }

        double quotient = a / b;
        double square = quotient * quotient;
        return square;
    }

    static void CheckEquation()
    {
        Console.WriteLine("Введіть значення x: ");
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine("Введіть значення y: ");
        double y = double.Parse(Console.ReadLine());

        if (!IsRealNumber(x))
        {
            Console.WriteLine("x має бути дійсним числом!");
            return;
        }
        if (!IsRealNumber(y))
        {
            Console.WriteLine("y має бути дійсним числом!");
            return;
        }

        double leftSide = (x + y) / (x * y);
        double rightSide = 1 / (x * x + 1);

        if (Math.Abs(leftSide - rightSide) < double.Epsilon)
        {
            Console.WriteLine("Рівняння задовольняється при x = {0} і y = {1}", x, y);
        }
        else
        {
            Console.WriteLine("Рівняння не задовольняється при x = {0} і y = {1}", x, y);
        }
    }

    static bool IsRealNumber(double value)
    {
        return !double.IsNaN(value) && !double.IsInfinity(value);
    }
}