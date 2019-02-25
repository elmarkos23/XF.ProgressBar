using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XF.ProgressBar
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void funCargar()
        {
            pbCargarndo.Progress = 0;
            Task.Run(() => {
                for (int i = 0; i < 1000; i++)
                {
                    Thread.Sleep(5);
                    pbCargarndo.Progress = Convert.ToDouble("00." + i.ToString());
                    pbCargarndo.Progress = i;
                }
            });
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            funCargar();
        }
    }
}
