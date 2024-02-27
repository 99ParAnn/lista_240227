
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lista_240227
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//1.Hozz létre egy üres listát.
			List<int> szamok = new List<int>();
			//2.Töltsd fel a listát 1 - től 10 - ig terjedő egész számokkal.
			for (int i = 1; i <= 10; i++)
			{
				szamok.Add(i);
			}//*/

			//4.Alkalmazd ezt a függvényt (SzamNegyzete) minden elemre a listádban, és az eredményeket tárold egy új listában.
			List<int> szamokNegyzete = new List<int>();
			foreach (int szam in szamok)
			{
				szamokNegyzete.Add(SzamNegyzete(szam));
			}
			/*4. fela tesz 
			foreach (int szam in szamokNegyzete)
			{
                Console.WriteLine(szam);
            }//*/


			/*5. fela teszt
			Console.WriteLine(listaElemekOsszege(szamokNegyzete)); //*/

			//következő feladatok teszteléséhez szükséges lista
			List<int> tesztelo = new List<int>();
			/*6. fela teszt 
			tesztelo = CsakParosSzamok(szamokNegyzete); //*/

			/*7. fela teszt
			tesztelo = ListaMindenElemetSzorozza(szamok, 42); //*/

			//min, max, összefésülés, páros-e föggvényekhez használt lista
			List<int> masikSzamok = new List<int>() { -40, 30, 12, -30, 101 };
			/*8. fela teszt
			tesztelo = Osszefesul(masikSzamok, szamokNegyzete);//*/

			/*9. fela teszt
			Console.WriteLine(Maximum(szamok));//*/

			/*10. fela teszt
			Console.WriteLine(Minimum(szamok));//*/

			/*11. feladat teszt
            Console.WriteLine(MindenElemParos(masikSzamok));//*/

			/*12. feladat teszt
			tesztelo = MindenMasodikElem(szamokNegyzete);//*/

			/*13. feladat teszt
			tesztelo = ForditottSorrendben(szamokNegyzete);//*/

            //eredménylisták kiírásához használt snippet
            foreach (int szam in tesztelo)
			{
				Console.WriteLine(szam);
			}//*/

			List<string> szovegLista = new List<string>{"aaaaaaaa", "AAAAA", "-.,.-", "AAA aaa AAA"};
			List<string> szovegKimenetLista = new List<string>();
			//*14. feladat teszt
			/*
			szovegKimenetLista = NagyKezdobetu(szovegLista);
			foreach (string sor in szovegKimenetLista)
			{
                Console.WriteLine(sor);
            }//*/

			//15. feladat tesz
			szovegKimenetLista = OtKarakternelHosszabb(szovegLista);
			foreach (string item in szovegKimenetLista)
			{
                Console.WriteLine(item);
            }
			 
		}



		//15.Írj egy függvényt, ami egy listát kap, és visszaadja azokat az elemeket egy új listában, amelyek hosszabbak 5 karakternél.
		public static List<string> OtKarakternelHosszabb(List<string> bemenet)
		{
			List<string> kimenet = new List<string>();
			foreach (string sor in bemenet)
			{
				if (sor.Length>5)
				{
					kimenet.Add(sor);
				}
			}
			return kimenet;
		}

		//14.Hozz létre egy függvényt, ami egy szöveges listát kap paraméterül(pl.nevek listája), és minden elemet alakítson át úgy, hogy az nagybetűvel kezdődjön,
		//a többi része pedig kisbetű legyen.
		public static List<string> NagyKezdobetu(List<string> bemenet)
		{
			List<string> kimenet = new List<string>();
			foreach (string sor in bemenet)
			{

				kimenet.Add((sor.Substring(0, 1).ToUpper() + sor.Substring(1, sor.Length-1).ToLower()));
			}
			return kimenet; 

		}

		//13.Írj egy függvényt, ami egy listát kap, és visszaad egy új listát, ahol az elemek fordított sorrendben szerepelnek.
		public static List<int> ForditottSorrendben(List<int> bemenet)
		{
			List<int> kimenet = new List<int>();
			for (int i = bemenet.Count-1; i >=0; i--)
			{
				kimenet.Add(bemenet[i]);
			}
			return kimenet;
		}


		//12.Készíts egy függvényt, ami egy listát kap paraméterül, és visszaad egy új listát, amely az eredeti lista minden második elemét tartalmazza.
		public static List<int> MindenMasodikElem(List<int> bemenet)
		{
			List<int> kimenet = new List<int>();
			for (int i = 1; i < bemenet.Count; i+=2)
			{
				kimenet.Add(bemenet[i]);
			}
			return kimenet;
		}

		//11.Írj egy függvényt, ami eldönti egy listáról, hogy minden eleme páros-e.A függvény visszatérési értéke legyen boolean típusú.
		public static bool MindenElemParos(List<int> szamok)
		{
			int indexer = 0;
			while (indexer < szamok.Count && szamok[indexer] %2 ==0)
			{
				indexer++;
            }
			return indexer == szamok.Count;
		}


		//10.Hozz létre egy függvényt, ami egy listát kap paraméterül, és visszaadja a lista legkisebb elemét.
		public static int Minimum(List<int> bemenet)
		{
			int legkisebb = bemenet[0];
			foreach (int szam in bemenet)
			{
				if (szam < legkisebb)
				{
					legkisebb = szam;
				}
			}
			return legkisebb;
		}


		//9.Hozz létre egy függvényt, ami egy listát kap paraméterül, és visszaadja a lista legnagyobb elemét.
		public static int Maximum(List<int> bemenet)
		{
			int legnagyobb = bemenet[0];
			foreach (int szam in bemenet)
			{
				if (szam>legnagyobb)
				{
					legnagyobb = szam;
				}
			}
			return legnagyobb;
		}


//8.Készíts egy függvényt, ami két listát kap paraméterül, és összefésüli őket egy új listába úgy, hogy felváltva vegye az elemeket az eredeti listákból
//(pl.az első lista első eleme, a második lista első eleme, stb.).
		//eltérő hosszú listákat is kezel: összefésül amíg tud, aztán csak bepakol
		public static List<int> Osszefesul(List<int> elso, List<int> masodik)
		{
			bool elsoRovidebb = elso.Count < masodik.Count;
			List<int> kimenet = new List<int>();
			int rovidebbListaHossza = elsoRovidebb ? elso.Count : masodik.Count;
			int hosszabbListaHossza = elsoRovidebb ? masodik.Count : elso.Count;
			for (int i = 0; i < rovidebbListaHossza; i++)
			{
				kimenet.Add(elso[i]);
				kimenet.Add(masodik[i]);
			}
			for (int i = rovidebbListaHossza; i < hosszabbListaHossza; i++)
			{
				kimenet.Add(elsoRovidebb ? masodik[i] : elso[i]);
			}
			return kimenet;	
		}


		//7.Írj egy függvényt, ami egy számot és egy listát kap paraméterül, és visszaadja azt a listát, ahol minden elemet megszorzott az adott számmal.

		public static List<int> ListaMindenElemetSzorozza(List<int> bemenetTomb, int szorzo)
		{
			List<int> kimenetTomb = new List<int>();
			foreach (int szam in bemenetTomb)
			{
				kimenetTomb.Add(szam * szorzo);
			}

			return kimenetTomb;
		}


		//6.Hozz létre egy függvényt, ami egy listát kap paraméterként, és visszaadja a páros számokat tartalmazó új listát.
		public static List<int> CsakParosSzamok(List<int> bemenet)
		{
			List<int> kimenet = new List<int>();
			foreach (int szam in bemenet)
			{
				if (szam % 2 == 0)
				{
					kimenet.Add(szam);
				}
			}
			return kimenet;
		}



		//5.Hozz létre egy függvényt, ami egy listát kap paraméterként, és visszaadja a lista elemeinek összegét.
		//probléma: típus?????
		//legyen int, hogy használhassam a meglevő listákra
		public static int listaElemekOsszege(List<int> bemenet)
		{
			int szamlalo = 0;
			foreach (int elem in bemenet)
			{
				szamlalo += elem;
			}
			return szamlalo;
		}



		//3.Írj egy függvényt, ami megkap egy számot, és visszaadja a szám négyzetét.
		public static int SzamNegyzete(int bemenet)
		{
			return bemenet * bemenet; //spórolok a hívási veremmel
		}
	}
}



