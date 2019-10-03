using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BT1_16520339
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void CmdAbsoluteLayout_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AbsoluteLayout());
        }

        private void CmdGridLayout_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GridLayout());
        }

        private void CmdLogin_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ManHinhLogin());
        }

        private void CmdFlexLayout_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FlexLayout());
        }

        private void CmdScrollView_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Scroll_View());
        }

        private void CmdListview1_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new List_View());
        }

        private void CmdStackLayout_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new StackLayout());
        }

        private void CmdSumScreen_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ManHinhTinhTong());
        }

        private void CmdHelloScreen_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ManHinhChao());
        }

        private void CmdCalculator_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Calculator());
        }
    }
}
