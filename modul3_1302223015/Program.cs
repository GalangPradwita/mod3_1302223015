using System.Reflection.Metadata.Ecma335;

namespace modul3_1302223015
{
    internal class Program
    {
    

        public class PosisiKarakterGame
        {
            public enum State {Berdiri, Jongkok, Tengkurap, Terbang}
            public enum Triger {W, S, X }
            public class PerubahanPosisi
            {
                public State sebelum;
                public State setelah;

                public Triger tombol;

                public PerubahanPosisi(State sebelum, State setelah, Triger tombol)
                {
                    this.sebelum = sebelum;
                    this.setelah = setelah;
                    this.tombol = tombol;
                }

            }
            PerubahanPosisi[] list =
            {
                new PerubahanPosisi(State.Berdiri, State.Jongkok, Triger.S),
                new PerubahanPosisi(State.Berdiri, State.Terbang, Triger.W),
                new PerubahanPosisi(State.Jongkok, State.Berdiri, Triger.W),
                new PerubahanPosisi(State.Terbang, State.Berdiri, Triger.S),
            };

            public State sekarang = State.Berdiri;
            public State getAfter(State sebelum, Triger tombol)
            {
                State stateAfter = sebelum;

                for (int i = 0; i < list.Length; i++)
                {
                    State posisiAwal = list[i].sebelum;
                    Triger button = list[i].tombol;

                    if (posisiAwal == sebelum && button == tombol) {
                        stateAfter = list[i].setelah;
                  
                    }
                }
                return stateAfter;
            }
            public void tekanTombol(Triger tombol)
            {
                sekarang = getAfter(sekarang, tombol);
                if (sekarang == State.Jongkok)
                {
                    Console.WriteLine("Posisi Landing");
                }else if (sekarang == State.Terbang)
                {
                    Console.WriteLine("Posisi Take Off");
                }
            }

        }

        
    }
}
