namespace GradeBook
{
    public class Menu
    {
        public static void Menu2() 
        {
           Console.Clear();

            Console.WriteLine("                         Grade Book");
            Console.WriteLine("=================================================================");
            Console.WriteLine();
            Console.WriteLine($"Grade Book for ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Wybierz kategorie");
            Console.WriteLine();
            Console.WriteLine("1 - Dodawanie ocen");
            Console.WriteLine("2 - Przeglądanie ocen");
            Console.WriteLine("3 - Przeglądanie średniej ocen");
            Console.WriteLine("4 - Przeglądanie wartości portfela");
            Console.WriteLine("q - Zakończenie");
            

        }
        public static void Menu3()
        {
           // Console.Clear();

            Console.WriteLine("                        Lista przedmiotów");
            Console.WriteLine("=================================================================");
            Console.WriteLine();
            Console.WriteLine("Wybierz przeddmiot do którego chcesz dodać ocenę");
            Console.WriteLine();
            Console.WriteLine("1 - matematyka");
            Console.WriteLine("2 - j.polski");
            Console.WriteLine("3 - j.angielski");
            Console.WriteLine("4 - historia");
            Console.WriteLine("5 - biologia");
            Console.WriteLine("6 - w-f");
            Console.WriteLine("7 - muzyka");
            Console.WriteLine("8 - plastyka");
            Console.WriteLine("9 - technika");
            Console.WriteLine("0 - powrót do poprzedniego menu");
        }
    }
}
