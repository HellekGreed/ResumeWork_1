string[] GetArray()
{
        Console.Write("Введите желаемую размерность массива(Это должно быть целое число): ");
        int size = Math.Abs(Convert.ToInt32(Console.ReadLine()));
        string[] array = new string[size];
        string str = "";
        Console.WriteLine("Введите желаемые строки(после каждой строки нажмите Enter).");
        for(int i = 0; i < size; i++)
        {
                str = Console.ReadLine();
                array[i] = str;
        }

        return array;
}

string[] GerArrayShortString(string[] array)
{
        int count = 0;
        for(int i = 0; i < array.Length; i++)
        {
                if(array[i].Length < 4)
                {
                        count++;
                }
        }
        string[] resultArray = new string[count];
        count = 0;
        for(int i = 0; i < array.Length; i++)
        {
                if(array[i].Length < 4)
                {
                        resultArray[count] = array[i];
                        count++;
                }
        }
        return resultArray;
}

void PrintArray(string[] array)
{
        if(array.Length == 0)
        {
                Console.WriteLine("Массив пуст.");
        }
        else
        {
                Console.WriteLine("Список строк меньше 3-х символов:");
                foreach(string s in array)
                {   
                        Console.Write($"{s} ");
                }
        }
        
}

string[] array = GetArray();
string[] resultArray = GerArrayShortString(array);
Console.WriteLine();
PrintArray(resultArray);
