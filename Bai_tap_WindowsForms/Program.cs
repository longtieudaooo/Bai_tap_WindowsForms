using System;
using System.Windows.Forms;

namespace Bai_tap_WindowsForms
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

           
            Application.Run(new FormAppointment());//     // Chụp cho Bài 1
             //Application.Run(new FormLabCheckout());  // Chụp cho Bài 2
             //Application.Run(new FormRepairTracker()); // Chụp cho Bài 3
        }
    }
}