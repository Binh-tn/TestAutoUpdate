using AutoUpdaterDotNET;
using System;
using System.Windows.Forms;

namespace TestAutoUpdate
{
    internal class Program
    {
        private const string UPDATE_FOLDER = "update";

        static void Main(string[] args)
        {
            //AutoUpdater.Synchronous = false;
            //AutoUpdater.RunUpdateAsAdmin = false;

            AutoUpdater.SetOwner(args);
            //AutoUpdater.Synchronous = true;
            AutoUpdater.DownloadPath = UPDATE_FOLDER;
            AutoUpdater.CheckForUpdateEvent += AutoUpdaterOnCheckForUpdateEvent;

            AutoUpdater.Start("https://binh-tn.github.io/TestAutoUpdate/update.xml");
        }

        private static void AutoUpdaterOnCheckForUpdateEvent(UpdateInfoEventArgs args)
        {
            if (args.IsUpdateAvailable)
            {
                if (AutoUpdater.DownloadUpdate(args))
                {
                    Application.ExitThread();
                }
            }
        }
    }
}
