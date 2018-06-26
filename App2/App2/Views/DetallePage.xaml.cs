using App2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DetallePage : ContentPage
	{
		public DetallePage ( PersonaModel modelo)
		{
			InitializeComponent ();
            BindingContext = modelo;
		}
	}
}
