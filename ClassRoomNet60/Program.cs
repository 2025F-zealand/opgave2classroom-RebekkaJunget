// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography.X509Certificates;

namespace ClassRoomNet60
{
    public class Program
    {
        static void Main(string[]args)
        {
            KlasseRum klasseRum = new KlasseRum();
            klasseRum.KlasseNavn = "3B";
            klasseRum.SemesterStart = new System.DateTime(2022,9,1);
            klasseRum.KlasseListe.Add(new Studerende("Rebekka", 2, 14));
            klasseRum.KlasseListe.Add(new Studerende("Cecilia", 3, 5));
            klasseRum.KlasseListe.Add(new Studerende("Sara", 4, 20));
        }
    }
}