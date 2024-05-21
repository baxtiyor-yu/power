namespace AppPow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Helper.DisplayMessage("pow");
            Thread.Sleep(2000);
            new Pow().CalculatePow();
        }
    }
}
