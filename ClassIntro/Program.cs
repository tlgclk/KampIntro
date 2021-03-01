using System;

namespace ClassIntro
{
	class Program
	{
		static void Main(string[] args)
		{
			string adi = "Tolga";
			int yas = 25;
			
			Kurs kurs1 = new Kurs();
			kurs1.Kursadi = "C#";
			kurs1.Egitmen = "Tolga Çelik";
			kurs1.IzlemeOrani = 68;

			Kurs kurs2 = new Kurs();
			kurs2.Kursadi = "Java";
			kurs2.Egitmen = "Kerem Varış";
			kurs2.IzlemeOrani = 64;


			Kurs kurs3 = new Kurs();
			kurs3.Kursadi = "Python";
			kurs3.Egitmen = "Berkay Bilgin";
			kurs3.IzlemeOrani = 90;


			//Console.WriteLine(kurs1.Kursadi + " " + kurs1.Egitmen);

			Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3};

			foreach (var kurs in kurslar)
			{
				Console.WriteLine(kurs.Kursadi + " : " + kurs.Egitmen);
				
			}

		}
	}

	class Kurs
	{
		public string Kursadi { get; set; }

		public string Egitmen { get; set; }

		public int IzlemeOrani { get; set; }
	}
}
