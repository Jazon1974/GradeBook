using System.Data;

namespace GradeBook
{
    public class ItemList
    {
        public static void ItemList2()
        {
            Console.Clear();

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

            Console.WriteLine("Podaj wybór");

            var inputmenu2 = Console.ReadLine();
            char itiem;

            switch (inputmenu2)
            {
                case "0":
                    { Menu.Menu2();
                        
                    }
                    break;
                case "1":
                    { Menu.Menu2();
                        itiem = 'M';
                    }
                    break;
                case "2":
                    { Menu.Menu2();
                        itiem = 'L';
                    }
                    break;
                case "3":
                    { Menu.Menu2();
                        itiem = 'A';
                    }
                    break;
                case "4":
                    { Menu.Menu2();
                        itiem = 'H';
                    }
                    break;
                case "5":
                    { Menu.Menu2();
                        itiem = 'B';
                    }
                    break;
                case "6":
                    { Menu.Menu2();
                        itiem = 'W';
                    }
                    break;
                case "7":
                    { Menu.Menu2();
                        itiem = 'M';
                    }
                    break;
                case "8":
                    { Menu.Menu2();
                        itiem = 'P';
                    }
                    break;
                case "9":
                    { Menu.Menu2();
                        itiem = 'T';
                    }
                    break;

            }
        }


    }

}
