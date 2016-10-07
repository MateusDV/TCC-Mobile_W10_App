using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// O modelo do item de página em branco está documentado em http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Albert_Alves
{
    /// <summary>
    /// Uma página vazia que pode ser usada isoladamente ou navegada dentro de um Quadro.
    /// </summary>
    public sealed partial class telaLogin : Page
    {
        public telaLogin()
        {
            this.InitializeComponent();
        }

		private async void button_Click(object sender, RoutedEventArgs e)
		{
			if(textBox.Text.Equals("abc") && textBox1.Text.Equals("123"))
			{
				var msg = new MessageDialog("foi");
				await msg.ShowAsync();

				this.Frame.Navigate(typeof(telaPrincipal));
			}
			else
			{
				var msg = new MessageDialog("NÃO FOI");
				await msg.ShowAsync();
			}
		}
	}
}
