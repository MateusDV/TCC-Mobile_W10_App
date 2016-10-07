using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
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

// O modelo de item de Página em Branco é documentado em http://go.microsoft.com/fwlink/?LinkId=234238

namespace Albert_Alves
{
	/// <summary>
	/// Uma página vazia que pode ser usada isoladamente ou navegada dentro de um Quadro.
	/// </summary>
	public sealed partial class telaPrincipal : Page
	{
		public telaPrincipal()
		{
			this.InitializeComponent();
		}

		private async void AppBarButton_Click(object sender, RoutedEventArgs e)
		{
			//this.Frame.Navigate(typeof(telaLogin));
			string html = await MakeWebRequest("http://www.google.com.br");
			var msg = new MessageDialog(html);
			await msg.ShowAsync();
		}

		public async Task<String> MakeWebRequest(string url)
		{
			HttpClient http = new System.Net.Http.HttpClient();
			HttpResponseMessage response = await http.GetAsync(url);
			return await response.Content.ReadAsStringAsync();
		}
	}
}
