using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Experimenting.ViewModels;

namespace Experimenting.Views
{
    public partial class NuevoEstudianteView : ContentPage
    {
        public NuevoEstudianteView()
        {
            InitializeComponent();
            BindingContext = EstudianteViewModel.GetInstance();
        }
    }
}
