// See https://aka.ms/new-console-template for more information

char again = 'y';

static int AddTwoNumbers()
{

    Console.WriteLine("Enter first number");
    int num1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter operator");

    char op = Convert.ToChar(Console.ReadLine()!);


    Console.WriteLine("Enter second number");

    int num2 = Convert.ToInt32(Console.ReadLine());

    if (op == '+')
    {
        return num1 + num2;
    }
    else if (op == '-')
    {
        return num1 - num2;
    }
    else if (op == '/')
    {
        return num1 / num2;
    }
    else if (op == '*')
    {
        return num1 * num2;
    }
    else
    {
        return 0;
    }

}

do
{
    Console.WriteLine($"Result: {AddTwoNumbers()}");

    Console.WriteLine("Do you need to continue?");

    again = Convert.ToChar(Console.ReadLine()!);
} while (again != 'n');