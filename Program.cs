namespace String;
class Program
{
    static void Main(string[] args)
    {

        char [] house = {'H', 'O', 'U', 'S', 'E'};  
        char [,] str = new char[10,10];
        int counter=0; //счётчик элементов в двумерном массиве
        char c; //наш рандомный символ
        Random symbol = new Random();

        int index = new Random().Next(0, str.Length-house.Length); // вычитаем количество элементов 2-д массива и количество элементов одномерного массива (строки), 
                                                                    // чтобы не выйти за заданную область.
        for (int i=0; i<str.GetLength(0); i++)
        {
            for (int j = 0; j<str.GetLength(1); j++)
            {                
                if(counter==index) //сверяем "общий" индекс двумерного с счётчиком количество элементов
                {
                    int houseIndex = 0; //счётчик индекса массива символов
                    
                    while(j<str.GetLength(1) && houseIndex<house.Length) //проверяем области видимости 2-д массива и индекс нашего слова
                    {                  
                        str[i,j] = house[houseIndex];
                        houseIndex++; 
                        j++;
                        
                        if (j==str.GetLength(1))//если индекс j-го элемента выходит за область видимости массива, сбрасываем индекс столбца и прибавляем индекс строки
                        {
                            j=0;
                            i++;
                        }                  
                    }
                }

                c = Convert.ToChar( symbol.Next(32, 126) ); //конвертим число в ASCII Printable Characters. Диапазон с 32 до 126
                str[i, j] = c;
                counter++;                             
            }
        }
    
        for (int i=0; i<str.GetLength(0); i++)
        {
            for (int j = 0; j<str.GetLength(1); j++)
            Console.Write($"{str[i,j]} ");

            Console.Write('\n'); 
        }
    }          
}    

