using System.Text;

namespace CA241118
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Berek> lista = new List<Berek>();
            using StreamReader sr = new(path: "..\\..\\..\\src\\berek2020.txt", encoding: Encoding.UTF8);
            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                lista.Add(new(sr.ReadLine()));
            }

            Console.WriteLine($"3. feladat: Dolgozók száma: {lista.Count()} fő");

            var f4 = lista.Average(b => b.Ber);
            Console.WriteLine($"4. feladat: {Math.Round((f4 / 1000), 1)} eFt");

            Console.Write($"5. feladat: Kérem a részleg nevét: ");
            string resz = Console.ReadLine().ToLower();
            //int maxi = 0;
            //bool japvan = false;
            //for (int i = 1; i < lista.Count; i++)
            //{
            //    if (lista[i].Reszleg == resz && lista[i].Ber > lista[maxi].Ber)
            //    {
            //        maxi = i;
            //        japvan = true;
            //    }

            //}
            //if (japvan)
            //{
            //    Console.WriteLine($"6. feladat: A legöbbet kereső dolgozó a megadott részlegen" +
            //        $"\n\tNév: {lista[maxi].Nev}\n\tNem: {(lista[maxi].Neme ? "férfi" : "nő")}\n\tBelépés: {lista[maxi].Belepes}\n\tBér: {lista[maxi].Ber}");
            //}
            //else 
            //{
            //    Console.WriteLine($"6. feladat: A megadott részleg nem létezik a cégnél!");
            //}
            var maxEmployee = lista
            .Where(x => x.Reszleg == resz)
            .OrderByDescending(x => x.Ber)
            .FirstOrDefault();
            if (maxEmployee != null)
            {
                Console.WriteLine($"6. feladat: A legöbbet kereső dolgozó a megadott részlegen" +
                    $"\n\tNév: {maxEmployee.Nev}\n\tNem: {(maxEmployee.Neme ? "férfi" : "nő")}\n\tBelépés: {maxEmployee.Belepes}\n\tBér: {maxEmployee.Ber:000 000} Forint");
            }
            else
            {
                Console.WriteLine($"6. feladat: A megadott részleg nem létezik a cégnél!");
            }

            var f7 = lista.GroupBy(b => b.Reszleg).OrderBy(g => g.Key);
            Console.WriteLine("7. feladat: Statisztika");
            foreach (var f in f7)
            {
                Console.WriteLine($"\t{f.Key} - {f.Count()} Fő");
            }
        }
    }
}
