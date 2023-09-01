int num1, num2, num3;

Console.WriteLine("Informe o primeiro numero");

num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe o segundo numero");

num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe o terceiro numero");

num3 = Convert.ToInt32(Console.ReadLine());

if (num1 < num2 && num1 < num3)

{

    if (num2 < num3)

    {

        Console.WriteLine(num1 + " " + num2 + " " + num3);

    }

    else

    {

        Console.WriteLine(num1 + " " + num3 + " " + num2);

    }

}

else

{

    if (num2 < num1 && num2 < num3)

    {

        if (num1 < num3)

        {

            Console.WriteLine(num2 + " " + num1 + " " + num3);

        }

        else

        {

            Console.WriteLine(num2 + " " + num3 + " " + num1);

        }

    }

}
