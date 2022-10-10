string[] GetArray()
{
        Console.Write("Введите желаемую размерность массива(Это должно быть целое число): ");
        int size = Math.Abs(Convert.ToInt32(Console.ReadLine()));
        string[] array = new string[size];

        Console.WriteLine("Введите желаемые строки(после каждой строки нажмите Enter).");
        for(int i = 0; i < size; i++)
        {
                str = Console.ReadLine();
                array[i] = str;
        }

        return array;
}

