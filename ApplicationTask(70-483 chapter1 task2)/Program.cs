using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationTask_70_483_chapter1_task2_
{
    class Program
    {
        static void Main(string[] args)
        {
            //без проверок считаем что пользователь не идиот

            int stCount;

            //сколько карточек студентов будет
            Console.Write("Колличество студентов :");
            if(!Int32.TryParse(Console.ReadLine(),out stCount))
            {
                Console.WriteLine("Неверный ввод по умолчанию будет 1 карточка !! ");
                stCount = 1;
            }

            //Мутим массив 2 мерный типа string [stCount,3] в каждой строке первый элемент имя + 3 оценки
            string[,] studCards = new string[stCount, 4];

            //в цикле запрос данных о студенте

            //пробегаем по студентам
            for (int i = 0,j=0; i < stCount; i++)
            {

                Console.Write("Введите имя студента : ");
                studCards[i, j++] = Console.ReadLine();
                Console.WriteLine("Enter English Marks (Out Of 100) : ");
                studCards[i,j++]= Console.ReadLine();
                Console.WriteLine("Enter Math Marks (Out Of 100) : ");
                studCards[i, j++] = Console.ReadLine();
                Console.WriteLine("Enter Computer Marks (Out Of 100) : ");
                studCards[i, j++] = Console.ReadLine();
                j = 0; //обнуляем второй счетчик
            }


            //for test
           // for (int i = 0; i < 4; i++)
           // {
           //     Console.WriteLine(studCards[0, i]);
           // }


            //Вывод карточек
            Console.WriteLine("*****************Отчетная карта******************");
            //Student Name: Ali Asad, Position: 1, Total: 160/300
            for(int i=0;i<stCount;i++)
            {
                int rez = 0;
                for(int j=1;j<4 ;j++)
                {
                    int mark;
                    if(Int32.TryParse(studCards[i,j],out mark))
                    {
                        rez += mark;
                    }
                    else
                    {
                        //если ввод неверный ставим среднею оценку
                        rez += 50;
                    }
                }
                Console.WriteLine("Имя:{0}  Позиция:{1}  Оценка:{2}/300", studCards[i, 0], i, rez);
            }

        }
    }
}
