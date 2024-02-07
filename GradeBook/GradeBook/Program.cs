//Program GradeBook

////////////////////////////////////////////////////////////////////////////
//Zakres
//1. Przechowywanie danych ucznia
//2. Możliwosć dodawania ocen
//3. Przechowywanie ocen z poszczególnych przedmiotów
//4. Wyliczanie nagrody lub kary za oceny wg wagi przedmiotu
//5. Wyliczanie średniej ocen
//6. Wyliczanie aktualnej wartości portfela
//7. Przedstawienie danych z portfela
////////////////////////////////////////////////////////////////////////////
///
//using GradeBook;

using GradeBook;
using System;
using System.Runtime.CompilerServices;


Menu.Menu2();

while(true)
{
    Console.WriteLine("Podaj wybór");;
	var inputmenu1 = Console.ReadLine();
	
	
	
	if (inputmenu1 == "q")
	{ 
		break;
	}
	try
	{
		switch (inputmenu1) 
		{
			case "1":
				{ ItemList.ItemList2() ; }
				break;
				case "2":
				{ ItemList.ItemList2() ; } 
				break;
				case "3":
				{ ItemList.ItemList2() ; } 
				break;
		}
	}
	catch (Exception)
	{

		throw;
	}
}


////////////////////////////////////////////////////////////////
