using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Experimenting.ViewModels;


namespace Experimenting.Views
{
    public partial class EstudianteEspecificoView : ContentPage
    {
        public EstudianteEspecificoView()
        {
            InitializeComponent();
            BindingContext = EstudianteViewModel.GetInstance();
        }
    }
}
