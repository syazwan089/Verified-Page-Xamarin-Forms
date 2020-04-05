using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace OTP
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Entry_Focused(object sender, FocusEventArgs e)
        {
            box1.BorderColor = Color.ForestGreen;
        }

        private void Entry_Focused_1(object sender, FocusEventArgs e)
        {
            box2.BorderColor = Color.ForestGreen;
        }

        private void Entry_Focused_2(object sender, FocusEventArgs e)
        {
            box3.BorderColor = Color.ForestGreen;
        }

        private void Entry_Focused_3(object sender, FocusEventArgs e)
        {
            box4.BorderColor = Color.ForestGreen;
        }

        private void box1_Unfocused(object sender, FocusEventArgs e)
        {
            box1.BorderColor = Color.Gray;
            box2.BorderColor = Color.Gray;
            box3.BorderColor = Color.Gray;
            box4.BorderColor = Color.Gray;
        }
    }
}
