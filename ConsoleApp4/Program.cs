using System;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Создаем экземпляр класса символы и передаем первоначальные символы
            Symbols symbols = new Symbols('a','a','b');
            
            //Вызываем собственный метод для добавления знаков
            symbols.Add('a', 't', 'q', 'b', 'y', 'o');
            symbols.Add('щ', 'g', 'а', 'и', 'й', 'ы');
            
            
            var temp = symbols.GetList(); //получаем лист
            foreach (var item in temp)
            {
                Console.WriteLine(item.Char); //Выводим каждый элемент массива
            }

            symbols.Delete('ы', 'й'); //Удаляем

            temp = symbols.GetList(); //Выгружаем актуальный массив убеждаемся что этого элемента нет
            foreach (var item in temp)
            {
                Console.WriteLine(item.Char);
            }


            Console.ReadKey();

        }
    }
}
