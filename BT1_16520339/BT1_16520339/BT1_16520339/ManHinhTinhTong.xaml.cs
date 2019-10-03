using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BT1_16520339
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ManHinhTinhTong : ContentPage
	{
		public ManHinhTinhTong ()
		{
			InitializeComponent ();
		}

        private void CmdTinhTong_Clicked(object sender, EventArgs e)
        {
            double dSo1 = double.Parse(txtSoa.Text);
            double dSo2 = double.Parse(txtSob.Text);
            double dTong = dSo1 + dSo2;
            txtTong.Text = dTong.ToString();
        }

        private void CmdVeTrangChu_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}