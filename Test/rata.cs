namespace Test
{
    internal class Rata
    {


        public float Splata(float kwotaResult, float oprocentowanieMiesieczne)
        {
            return kwotaResult + (kwotaResult*(oprocentowanieMiesieczne/100));
        }

        public float Miesiac(float splata,float czasResult,int miesiacId)
        {
            return (splata / czasResult) * miesiacId;
        }

    }
}