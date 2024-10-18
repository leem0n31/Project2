
    Console.WriteLine("Введите ваше имя");
    string name = Console.ReadLine();
    Console.WriteLine("Ваше имя: " + name);
    Console.WriteLine("Персонаж осматривается и видит вокруг себя следующие возможности");
    Console.WriteLine(' ');
    Console.WriteLine("a. Открыть дверь");
    Console.WriteLine("b. Заглянуть под кровать");
    Console.WriteLine("c. Открыть ящик в углу комнаты");
    Console.WriteLine("d. Открыть вентиляцию");
    Console.WriteLine("e. Взглянуть на тумбочку");
    Console.WriteLine("f. Взглянуть на статую рядом с дверью");
    Console.WriteLine(' ');
    Console.WriteLine("Для того чтобы открыть дверь, игроку необходимо прежде всего открыть ящик, в котором лежит отмычка при помощи ключа от ящика. Ключ от ящика можно получить, активировав статую тремя артефактами");
    Console.WriteLine(' ');
    Console.WriteLine("a. первый артефакт находится под кроватью");
    Console.WriteLine("b. второй артефакт в вентиляции (для того чтобы ее открыть, нужно попробовать ее открыть три раза");
    Console.WriteLine("с. третий артефакт на тумбочке");


    {
        string input;

        while (true)
        {
            input = Console.ReadLine();

            if (input == "b")
            {
                Console.WriteLine(name+",вы активировали первый артефакт! Дальше следует открыть вентиляцию");
                break; 
            }
            else
            {
                Console.WriteLine("Неверное действие. Попробуйте снова.");
            }
        }
    }



{
    string input1;

    while (true)
    {
        input1 = Console.ReadLine();

        if (input1 == "d")
        {
            Console.WriteLine(name+",попробуйте еще раз");
            break;
        }
        else
        {
            Console.WriteLine("Неверное действие. Попробуйте снова.");
        }
    }
}


string input2;

while (true)
{
    input2 = Console.ReadLine();

    if (input2 == "d")
    {
        Console.WriteLine(name+",попробуйте еще раз");
        break;
    }
    else
    {
        Console.WriteLine("Неверное действие. Попробуйте снова.");
    }
}


string input3;

while (true)
{
    input3 = Console.ReadLine();

    if (input3 == "d")
    {
        Console.WriteLine(name + ",вы активировали второй артефакт! Дальше следует взглянуть на тумбочку");
        break;
    }
    else
    {
        Console.WriteLine("Неверное действие. Попробуйте снова.");
    }
}


string input4;

while (true)
{
    input4 = Console.ReadLine();

    if (input4 == "e")
    {
        Console.WriteLine(name + ",вы собрали все артефакты и активировали статую! Вы получаете ключ от ящика");
        break;
    }
    else
    {
        Console.WriteLine("Неверное действие. Попробуйте снова.");
    }
}


string input5;

while (true)
{
    input5 = Console.ReadLine();

    if (input5 == "c")
    {
        Console.WriteLine(name + ",вы успешно открыли ящик и получили отмычку от двери!");
        break;
    }
    else
    {
        Console.WriteLine("Неверное действие. Попробуйте снова.");
    }
}


string input6;

while (true)
{
    input6 = Console.ReadLine();

    if (input6 == "a")
    {
        Console.WriteLine(name + ",вы успешно открыли дверь при помощи отмычки и сбежали. Поздравляю!!!");
        break;
    }
    else
    {
        Console.WriteLine("Неверное действие. Попробуйте снова.");
    }
}
Console.WriteLine(' ');
Console.WriteLine(name + ",вы победили!");
