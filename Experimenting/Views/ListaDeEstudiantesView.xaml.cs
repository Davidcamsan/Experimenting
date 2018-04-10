using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Experimenting.ViewModels;


namespace Experimenting.Views
{
    public partial class ListaDeEstudiantesView : ContentPage
    {
        public ListaDeEstudiantesView()
        {
            InitializeComponent();
            BindingContext = EstudianteViewModel.GetInstance();
        }
    }
}
