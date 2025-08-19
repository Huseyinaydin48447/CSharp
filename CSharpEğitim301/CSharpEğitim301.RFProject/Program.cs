using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSharpEgitimKampi301.EFProject; // <-- burayı ekleyin

namespace CSharpEğitim301.RFProject
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmStatistics()); // Artık Form1 tanınacak
        }
    }
}
