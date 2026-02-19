namespace _3._osa_C__Kordused__massiivid_ja_klassid._Ülesanded.cs
{
    public class Isik
    {
        public string Nimi;
        public int Vanus;
        public Isik(string nimi, int vanus)
        {
            Nimi = nimi;
            Vanus = vanus;
        }
        public Isik()
        {

        }
        public void Tervita()
        {
            Console.WriteLine($"Tere, minu nimi on {Nimi} ja ma olen {Vanus}");
        }

    }
}
