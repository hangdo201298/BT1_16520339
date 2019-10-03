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
	public partial class ManHinhChao : ContentPage
	{
		public ManHinhChao ()
		{
			InitializeComponent ();
		}

        private void CmdChao_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Thông Báo", "Chào bạn " + txtHoTen.Text, "Thoát");
        }
    }
}