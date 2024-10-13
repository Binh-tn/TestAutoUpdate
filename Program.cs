using AutoUpdaterDotNET;

namespace TestAutoUpdate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AutoUpdater.Start("https://binh-tn.github.io/TestAutoUpdate/update.xml");
        }
    }
}
