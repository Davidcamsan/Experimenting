using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;
using System.Linq;
using Experimenting.Models;
using Experimenting.Views;

namespace Experimenting.ViewModels
{
    public class EstudianteViewModel : INotifyPropertyChanged
    {
        #region Singleton
        private static EstudianteViewModel instance = null;


        public EstudianteViewModel()
        {
            InitClass();
            InitCommands();
        }

        public static EstudianteViewModel GetInstance()
        {
            if (instance == null)
                instance = new EstudianteViewModel();

            return instance;
        }


        public static void DeleteInstance()
        {
            if (instance != null)
                instance = null;
        }
        #endregion


        #region Instancias

        //Escogiendo Un estudiante en especifico
        private EstudianteModel _EstudianteActual { get; set; }

        public EstudianteModel EstudianteActual
        {
            get
            {
                return _EstudianteActual;
            }

            set
            {
                _EstudianteActual = value;
                OnPropertyChanged("EstudianteActual");
            }
        }

        //espacio para agregar nuevo estudiante
        private EstudianteModel _NuevoEstudiante = new EstudianteModel();

        public EstudianteModel NuevoEstudiante{
            get
            {
                return _NuevoEstudiante;
            }
            set
            {
                _NuevoEstudiante = value;
                OnPropertyChanged("NuevoEstudiante");
            }
        }

        //Sacando lista de Todos Estudiantes
        private ObservableCollection<EstudianteModel> _lstEstudiantes = new ObservableCollection<EstudianteModel>();

        public ObservableCollection<EstudianteModel> lstEstudiantes
        {
            get
            {
                return _lstEstudiantes;
            }

            set
            {
                _lstEstudiantes = value;
                OnPropertyChanged("lstEstudiantes");
            }
        }

        public ICommand VerEstudianteCommand { get; set; }
        public ICommand AgregarNuevoEstudianteCommand { get; set; }

        #endregion

        #region Methods
        private void VerEstudiante(int id){
            EstudianteActual = lstEstudiantes.Where(x => x.ID == id).FirstOrDefault();
        }

        private void AgregarNuevoEstudiante()
        {
            lstEstudiantes.Add(NuevoEstudiante);
            OnPropertyChanged("lstEstudiantes");
            NuevoEstudiante = new EstudianteModel();
        }

        #endregion

        private async void InitClass(){
            lstEstudiantes = await EstudianteModel.ObtenerEstudiantes();
        }

        private void InitCommands(){
            VerEstudianteCommand = new Command<int>(VerEstudiante);
            AgregarNuevoEstudianteCommand = new Command(AgregarNuevoEstudiante);
        }


        #region INotifyPropertyChange Interface

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

    }
}
