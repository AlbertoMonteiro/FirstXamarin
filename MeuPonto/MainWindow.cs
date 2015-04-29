using System;
using Xamarin.Forms;

namespace MeuPonto
{
	public class MainWindow : ContentPage
	{
		public MainWindow ()
		{
			Title = "Meu ponto";

			NavigationPage.SetHasNavigationBar (this, true);

			var registrosTab = RegistroTab ();
			var inicioTab = new ContentPage () {
				Title = "Inicio"
			};

			var configTab = ConfigTab ();

			var infoTab = new ContentPage(){
				Title = "Info"
			};
			//Children.Add(inicioTab);
			//Children.Add(registrosTab);
			//Children.Add(configTab);
			//Children.Add(infoTab);
			
			ToolbarItems.Add(new ToolbarItem("+",null, () => {},0,0));
			Content = registrosTab.Content;
		}

		static ContentPage RegistroTab ()
		{
			var registrosTab = new ContentPage {
				Title = "Registros",
				Icon = "icone_relogio.png",
				Content = new StackLayout {
					Spacing = 10,
					Padding = 20,
					VerticalOptions = LayoutOptions.Center,
					Children =  {
						new Label {
							Text = "Data"
						},
						new DatePicker () {
							Format = "dd/MM/yyyy"
						},
						new Button {
							Text = "Batidas de hoje",
							BackgroundColor = Color.FromHex ("#EE4f39"),
							TextColor = Color.White
						},
						new Button {
							Text = "Teste notificacao",
							BackgroundColor = Color.FromHex ("#EE4f39"),
							TextColor = Color.White
						}
					}
				}
			};
			return registrosTab;
		}

		static ContentPage ConfigTab ()
		{			
			var configTab = new ContentPage {
				Title = "Configuracao",
				Content = new StackLayout {
					Spacing = 20, Padding = new Thickness (20, Device.OnPlatform<int> (20, 0, 0), 20, 0),
					VerticalOptions = LayoutOptions.Start,
					Children = {
						new Entry { Placeholder = "PIS", Keyboard = Keyboard.Numeric },
						new Button { Text = "Salvar", BackgroundColor = Color.Green, TextColor = Color.White }
					}
				}
			};
			return configTab;
		}
	}
}

