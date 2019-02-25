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
        private async void funCargar2()
        {
            pbCargarndo2.Progress = 0;
            //1 parametro cargando
            //2. velocidad
            //
            await pbCargarndo2.ProgressTo(0.8, 500, Easing.BounceIn);
        }
        private void funCargar()
        {
            pbCargarndo1.Progress = 0;
            Task.Run(() => {
                for (int i = 0; i < 10000; i++)
                {
                    pbCargarndo1.Progress = Convert.ToDouble("0." + i.ToString());
                }
            });
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            funCargar();
            funCargar2();
        }
    }
}
