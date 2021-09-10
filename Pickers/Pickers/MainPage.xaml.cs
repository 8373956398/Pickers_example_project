using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Pickers
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void onClick(object sender, EventArgs e)
        {
            var date = dp.Date;
            var time = tp.Time;
            var name = picker.SelectedItem.ToString();
            result.Text = string.Format("Date:{0} \n Time:{1} \n Name:{2}", date, time, name);


        }
    }
}
