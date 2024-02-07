using System;
using System.Data;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static System.Formats.Asn1.AsnWriter;

namespace GradeBook
{
    public class ItemList
    {
        public static void ItemList2()
        {
            var employee = new EmployeeInFile("Jacek", "Jaxiewicz");
            var inputmenu2 = "1";
            char itiem;

            while (inputmenu2 != "0")
            {
                Menu.Menu3();
                Console.WriteLine("Podaj wybór przedmiotu");
                inputmenu2 = Console.ReadLine();
                var logic = new Logic("Jacek", "Jaxiewicz");
                switch (inputmenu2)
                {
                    case "0":
                        {
                            Menu.Menu2();
                        }
                        break;
                    case "1":
                        {
                            
                            Console.WriteLine("Podaj ocenę z Matematyki");
                            var inputmenu3 = Console.ReadLine();
                            double.TryParse(inputmenu3, out double score);
                            if (logic.veryficationvalue(score))

                                //try

                                {

                                    itiem = 'M';
                                    logic.ItemScoreAdd(score);
                                    var grade = inputmenu3;
                                    employee.AddGrade(itiem, grade);
                                }
                                //catch (Exception ex)
                                //{
                                //    throw;
                                    
                                //}
                                else
                            {
                                Console.WriteLine("Zakres spoza 1-6");
                            }

                        }
                        break;
                    case "2":
                        {
                            Console.WriteLine("Podaj ocenę z j.polskiego");
                            var inputmenu3 = Console.ReadLine();
                            double.TryParse(inputmenu3, out double score);
                            itiem = 'L';
                            logic.ItemScoreAdd(score);
                            employee.AddGrade(itiem, score);
                        }
                        break;
                    case "3":
                        {
                            Console.WriteLine("Podaj ocenę z j.angielskiego");
                            var inputmenu3 = Console.ReadLine();
                            double.TryParse(inputmenu3, out double score);
                            itiem = 'A';
                            logic.ItemScoreAdd(score);
                            employee.AddGrade(itiem, score);
                        }
                        break;
                    case "4":
                        {
                            Console.WriteLine("Podaj ocenę z historii");
                            var inputmenu3 = Console.ReadLine();
                            double.TryParse(inputmenu3, out double score);
                            itiem = 'H';
                            logic.ItemScoreAdd(score);
                            employee.AddGrade(itiem, score);
                        }
                        break;
                    case "5":
                        {
                            Console.WriteLine("Podaj ocenę z biologii");
                            var inputmenu3 = Console.ReadLine();
                            double.TryParse(inputmenu3, out double score);
                            itiem = 'B';
                            logic.ItemScoreAdd(score);
                            employee.AddGrade(itiem, score);
                        }
                        break;
                    case "6":
                        {
                            Console.WriteLine("Podaj ocenę z w-f");
                            var inputmenu3 = Console.ReadLine();
                            double.TryParse(inputmenu3, out double score);
                            itiem = 'W';
                            logic.ItemScoreAdd(score);
                            employee.AddGrade(itiem, score);
                        }
                        break;
                    case "7":
                        {
                            Console.WriteLine("Podaj ocenę z muzyki");
                            var inputmenu3 = Console.ReadLine();
                            double.TryParse(inputmenu3, out double score);
                            itiem = 'U';
                            logic.ItemScoreAdd(score);
                            employee.AddGrade(itiem, score);
                        }
                        break;
                    case "8":
                        {
                            Console.WriteLine("Podaj ocenę z plastyki");
                            var inputmenu3 = Console.ReadLine();
                            double.TryParse(inputmenu3, out double score);
                            itiem = 'P';
                            logic.ItemScoreAdd(score);
                            employee.AddGrade(itiem, score);
                        }
                        break;
                    case "9":
                        {
                            Console.WriteLine("Podaj ocenę z techniki");
                            var inputmenu3 = Console.ReadLine();
                            double.TryParse(inputmenu3, out double score);
                            itiem = 'T';
                            logic.ItemScoreAdd(score);
                            employee.AddGrade(itiem, score);
                        }
                        break;
                }

                try
                {
                }
                catch (Exception a)
                {
                    System.Console.WriteLine($"Exception: {a.Message}");
                }
            }
        }


    }

}
