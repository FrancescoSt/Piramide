
namespace Piramide
{
    public static class Piramide
    {

        public static int Piani(int mattoni)
        {
            int piani = 0;
            int mattoni_usati = 0;
            while (mattoni_usati + (piani + 1) * (piani + 1) <= mattoni)
            {
                piani++;
                mattoni_usati += piani * piani;
            }
            return piani;
        }
        public static int Rimanenti(int mattoni)
        {
            int piani = Piani(mattoni);
            int mattoni_usati = 0;
            for (int i = 1; i <= piani; i++)
            {
                mattoni_usati += i * i;
            }
            return mattoni - mattoni_usati;
        }
    }

}
