using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_ControleXF.Controles
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SearchBarPage : ContentPage
	{
        private List<String> empresasTi;

        public SearchBarPage ()
		{
			InitializeComponent ();

            empresasTi = new List<string>();
            empresasTi.Add("Microsoft");
            empresasTi.Add("Apple");
            empresasTi.Add("Oracle");
            empresasTi.Add("IBM");
            empresasTi.Add("SAP");
            empresasTi.Add("Uber");
            empresasTi.Add("99Taxi");

            Preencher(empresasTi);
        }

        private void Preencher(List<String> empresaTi)
        {
            ListResult.Children.Clear();
            foreach (var emp in empresasTi)
            {
                ListResult.Children.Add(new Label { Text = emp });
            }
        }

        private void Pesquisar(object sender, TextChangedEventArgs args)
        {
            var resultado = empresasTi.Where(a => a.Contains(args.NewTextValue)).ToList();
            Preencher(resultado);
        }

        private void BotaoPesquisar(object sender, EventArgs e)
        {
            var resultado = empresasTi.Where(a => a.Contains(((SearchBar)sender).Text)).ToList();
            Preencher(resultado);
        }
    }
}