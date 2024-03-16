using System.Reflection.Metadata.Ecma335;

namespace modul3_1302223015
{
    internal class Program
    {
        public class KodeBuah
        {
            public enum NamaBuah { Apel, Aprikot, Alpukat, Pisang, Paprika, Blackberry, Ceri, Kelapa, Jagung, Kurma, Durian, Anggur, Melon, Semangka }

            public static string getKodeBuah( NamaBuah namabuah ){
                string[] kodebuah = { "A00", "B00",  "C00",  "D00",  "E00 ",  "F00",  "G00",  "H00",  "I00",  "J00",  "K00",  "L00",  "M00",  "N00",  "O00" };
                return kodebuah[(int)namabuah];

            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine(KodeBuah.getKodeBuah(KodeBuah.NamaBuah.Apel));
        }
    }
}
