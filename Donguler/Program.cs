using System;

namespace Donguler
{
	class Program
	{
		static void Main(string[] args)
		{
			string kurs1 = "Yazılım Geliştiririci Kampı";
			string kurs2 = "Başlangıç temel kursu";
			string kurs3 = "Java kursu";

			//array - dizi 

			string[] kurslar = new string[] { "Yazılım Geliştiririci Kampı", "Başlangıç temel kursu", 
				"Java kursu", "Python", "C++ Kursu" };


			for (int i = 0; i <kurslar.Length; i++)
			{
				Console.WriteLine(kurslar[i]);
			}

			Console.WriteLine("For bitti");

			foreach (string kurs in kurslar)
			{
				Console.WriteLine(kurs);
			}


			Console.WriteLine("sayfa sonu - footer");
		}
	}
}
