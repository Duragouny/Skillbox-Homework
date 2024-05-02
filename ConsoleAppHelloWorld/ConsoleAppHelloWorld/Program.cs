using static System.Console; //Убираем необходимость приписывать "Console" перед каждым оператором

namespace ConsoleAppHelloWorld
{
    internal class Program
    {
        /// <summary>
        /// Ого, это что, XML комментарий?
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            WriteLine("Hello, World!!!");

            //Пишем то же самое, но с помощью Write
            Write("Hello, ");
            Write("World");
            Write("!!!");

            WriteLine();
            WriteLine("Нажмите любую кнопку, чтобы выйти из консоли:");
            ReadKey();
        }
    }
}
