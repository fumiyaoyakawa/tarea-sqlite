﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Producto.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ProductoView : ContentPage
	{
		public ProductoView ()
		{
			InitializeComponent ();
		}
	}
}