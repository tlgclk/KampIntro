using System;

namespace KampIntro
{
	class Program
	{
		static void Main(string[] args)
		{
			//type safety - tip güvenliği
			//Do not repeat yourself 


			string kategoriEtiketi = "Katergori";
			int ogrenciSayisi = 32000;
			double faizOrani = 1.45;
			bool sistemeGirisYapmisMi = true;
			double dolarDun = 7.45;
			double dolarBugun = 7.45;


			if (dolarDun > dolarBugun) 
			{
				Console.WriteLine("Azalış Butonu");
			}
			else if (dolarDun < dolarBugun) 
			{
				Console.WriteLine("Artış Butonu");	
			}
			else
			{
				Console.WriteLine("Değişmedi Butonu");
			}


			if (sistemeGirisYapmisMi == true)
			{
				Console.WriteLine("Ayarlar butonu");
			}
			else
			{
				Console.WriteLine("Giriş yap butonu");
			}
			Console.WriteLine(kategoriEtiketi);
		}
	}
}
