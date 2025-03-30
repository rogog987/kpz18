using kpz18;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("Редактор коду (Memento)\n");

        Editor editor = new Editor();
        History history = new History();

        while (true)
        {
            Console.WriteLine("\nМеню:");
            Console.WriteLine("1. Написати код");
            Console.WriteLine("2. Відмінити останню дію (Undo)");
            Console.WriteLine("3. Вихід");
            Console.Write(">> Виберіть опцію: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Write("\nВведіть новий код: ");
                string newCode = Console.ReadLine();

                // Зберігаємо поточний стан перед зміною
                history.Push(editor.Save());

                // Оновлюємо текст редактора
                editor.SetText(newCode);
                editor.Print();
            }
            else if (choice == "2")
            {
                if (history.HasUndo())
                {
                    editor.Restore(history.Pop());
                    Console.WriteLine("\nОстанню зміну відмінено.");
                }
                else
                {
                    Console.WriteLine("\nНемає змін для відміни.");
                }
                editor.Print();
            }
            else if (choice == "3")
            {
                Console.WriteLine("\nВихід...");
                break;
            }
            else
            {
                Console.WriteLine("\nНекоректний вибір. Спробуйте ще раз.");
            }
        }
    }
}