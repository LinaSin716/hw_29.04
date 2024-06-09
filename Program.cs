using System.Runtime.Intrinsics.X86;
using System.Threading.Tasks.Dataflow;
using System.Xml.Linq;

namespace hw_29._04
{
    internal class Program
    {
        static void ToSquare(int a, string el)
        {
            Console.WriteLine("Квадрат из символа " + el + ":\n");
            if (a == 1) Console.WriteLine(el);
            else if (a == 2) Console.WriteLine(el + el + "\n" + el + el);
            else
            {
                for (int i = 0; i < a; i++) Console.Write(el);
                Console.WriteLine();
                for (int i = 0; i < a - 2; i++)
                {
                    Console.Write(el);
                    for(int j =0; j<a-2; j++) Console.Write(" ");
                    Console.WriteLine(el);
                }
                for (int i = 0; i < a; i++) Console.Write(el);
            }
        }

        static bool IsPoli(int num)
        {
            string str_num = num.ToString();
            for (int i = 0; i < str_num.Length/2; i++)
            {
                if (str_num[i] != str_num[str_num.Length - 1 - i]) return false;
            }
            return true;
            
        }

        static List<string> Filtr(List<string> list, List<string> elements)
        {
            int cnt = 0;
            bool f;
            int len = list.Count;
            for(int i = 0; i<len; i++)
            {
                f = false;
                for(int j=0; j<elements.Count; j++)
                {
                    if (list[cnt] == elements[j]) f = true;
                }
                if (f) list.RemoveAt(cnt);
                else cnt++;
            }
            return list;
        }
        static void Main(string[] args)
        {
            // 1
            
            Console.WriteLine("\nНомер 1\n");

            Console.Write("Введите длину стороны: ");
            int a = int.Parse(Console.ReadLine());
            while (a <= 0) 
            { 
                Console.WriteLine("Сторона квадрата должна быть положительной");
                Console.Write("Введите длину стороны: ");
                a = int.Parse(Console.ReadLine());
            }
            Console.Write("\nВведите символ: ");
            string el = Console.ReadLine();
            while (el.Length != 1)
            {
                Console.WriteLine("Нужен 1 символ");
                Console.Write("Введите символ: ");
                el = Console.ReadLine();
            }

            ToSquare(a, el);
            
            // 2
            
            Console.WriteLine("\nНомер 2\n");

            Console.Write("Введите число: ");
            int num = int.Parse(Console.ReadLine());
            if (IsPoli(num)) Console.WriteLine("Это палиндром");
            else Console.WriteLine("Это не палиндром");
            
            // 3
            
            Console.WriteLine("\nНомер 3\n");

            Console.Write("оригинальный массив: ");
            List<string> list = Console.ReadLine().Split(" ").ToList();

            Console.Write("массив для фильтрации: ");
            List<string> elements = Console.ReadLine().Split(" ").ToList();

            list = Filtr(list, elements);
            Console.Write("результат работы метода: ");
            foreach(string str in list) { Console.Write(str + " "); }
            
            // 4
            
            Console.WriteLine("\n\nНомер 4\n");

            Website website = new Website("name", "path", "desc", "ip");
            website.Print();
            website.SetName("name1");
            website.SetPath("path1");
            website.SetDescription("desc1");
            website.SetIpAddress("ip1");
            Console.WriteLine($"\nName: {website.GetName()}\nPath: {website.GetPath()}\n" +
                $"Description: {website.GetDescription()}\nIpAddress: {website.GetIpAddress()}");
            
            // 5
            
            Console.WriteLine("\nНомер 5\n");

            Journal journal = new Journal("name", 2000, "desc", "+125468", "qwer@mail.ru");
            journal.Print();

            journal.SetName("name1");
            journal.SetYear(2001);
            journal.SetDescription("desc1");
            journal.SetNumber("+98765");
            journal.SetEmail("asdf@mail.ru");
            Console.WriteLine($"\nName: {journal.GetName()}\nYear: {journal.GetYear()}\n" +
                $"Description: {journal.GetDescription()}\nNumber: {journal.GetNumber()}\nEmail: {journal.GetEmail()}");
            
            // 6
            Console.WriteLine("\nНомер 6\n");

            Shop shop = new Shop("name", "address", "desc", "+125468", "qwer@mail.ru");
            shop.Print();

            shop.SetName("name1");
            shop.SetAddress("address1");
            shop.SetDescription("desc1");
            shop.SetNumber("+98765");
            shop.SetEmail("asdf@mail.ru");
            Console.WriteLine($"\nName: {shop.GetName()}\nAddress: {shop.GetAddress()}\n" +
                $"Description: {shop.GetDescription()}\nNumber: {shop.GetNumber()}\nEmail: {shop.GetEmail()}");
        }
    }
}