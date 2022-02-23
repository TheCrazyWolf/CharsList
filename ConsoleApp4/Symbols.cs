using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Symbols
    {
        /// <summary>
        /// Статичная коллекция с символами
        /// </summary>
        static private List<CharsModel> list = new List<CharsModel>(); 
        
        public Symbols(params char[] chars) 
        {
            // При создании экземпляра можно сразу получить массив букв и передать на обработку
            //Можно сделать пустой конструктуор без входных параметров
            Add(chars);
        }

        /// <summary>
        /// Добавление букв в массив
        /// </summary>
        /// <param name="chars"></param>
        public void Add(params char[] chars) //Массив букв
        {
            //Перебираем коллекцию и проверяем результат есть ли буквы в массиве, если нет, вызываю метод за отвечающий за добавлений
            foreach (var item in chars)
            {
                bool result = Find(item);
                if (!result)
                {
                    AddAfter(item);
                }
            }
        }

        /// <summary>
        /// Поиск букв в массиве
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public bool Find(char a) 
        {
            var element = list.Find(x => x.Char == a); //Ищем элемент в листе

            if (element != null) 
            {
                return true; // Если нашелся элемент
            }

            return false; // Не нашелся
        }


        /// <summary>
        /// Удаление элемента из массива
        /// </summary>
        /// <param name="chars"></param>
        public void Delete(params char[] chars)
        {
            //Перебираем коллекцию на совпадение
            foreach (var item in chars)
            {
                var temp = list.FirstOrDefault(x => x.Char == item); //Поиск

                if (temp != null) //Если нашелся удаляем
                {
                    list.Remove(temp);
                }
            }
        }

        /// <summary>
        /// Метод отвечающий за добавление символов после проверки. Недоступен извне
        /// </summary>
        /// <param name="a"></param>
        protected void AddAfter(char a)
        {
            CharsModel ch = new CharsModel(a); //Создаем экземпляр класса, передаем букву
            list.Add(ch); //Добавляем букву в массив
        }

        /// <summary>
        /// Получаем лист. 
        /// </summary>
        /// <returns></returns>
        public List<CharsModel> GetList()
        {
            return list;
        }


    }
}
