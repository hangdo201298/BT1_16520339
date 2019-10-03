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
	public partial class ManHinhLogin : ContentPage
	{
		public ManHinhLogin ()
		{
			InitializeComponent ();
		}

        private void CmdLogin_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Thông Báo", "Đăng nhập thành công", "OK");
        }
    }
}