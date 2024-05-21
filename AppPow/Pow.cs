
using System.Numerics;

namespace AppPow
{
    internal class Pow
    {
        internal void CalculatePow()
        {
            do
            {
                Console.Clear();

                Console.Write("Darajani kiriting: ");

                var daraja = Helper.CheckForNumber("01");

                Console.WriteLine("\n" + TwoPowX(daraja) + "\n");

                Console.Write("Davom etish uchun 'x' ni, chiqish uchun 'y' bosing: ");

            } while (Helper.CheckForYESorNO("xy"));

            Console.Clear();
        }
        public BigInteger TwoPowX(int power)
        {
            return ((BigInteger)1 << power);
        }
    }
}
