using OSC_Test.Helpers;
using SharpOSC;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace OSC_Test
{
    public partial class MainWindow : Window
    {
        DispatcherTimer dt;
        public MainWindow()
        {
            
            InitializeComponent();
            dt = new DispatcherTimer();
            dt.Interval = TimeSpan.FromSeconds(5);
            dt.Tick += Dt_Tick;
            dt.Start();

        }

        private void Dt_Tick(object sender, EventArgs e)
        {
            OSCSenderHelper.Instance.SendAll();
        }
    }
}
