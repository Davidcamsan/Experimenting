using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace Experimenting.Models
{
    public class EstudianteModel
    {
        public EstudianteModel()
        {
            lstTareas = new List<TareasModel>();
            lstTareas.Add(new TareasModel { ID = 1, Archivo = "Mate" });
        }

        public int ID { get; set; }
        public string Nombre { get; set; }
        public int Nota { get; set; }
        public string Foto { get; set; }
        public List<TareasModel> lstTareas { get; set; }

        public static async Task<ObservableCollection<EstudianteModel>> ObtenerEstudiantes(){
            ObservableCollection<EstudianteModel> lstEstudiantes = new ObservableCollection<EstudianteModel>();

            lstEstudiantes.Add(new EstudianteModel { ID = 1, Nombre = "Carla Cintura", Nota = 60, Foto = "Cara" });
            lstEstudiantes.Add(new EstudianteModel { ID = 2, Nombre = "Carlos Cint", Nota = 60, Foto = "Cara" });
            lstEstudiantes.Add(new EstudianteModel { ID = 3, Nombre = "Gabriel Sancho", Nota = 60, Foto = "Cara" });
            lstEstudiantes.Add(new EstudianteModel { ID = 4, Nombre = "Daniel Fiel", Nota = 60, Foto = "Cara" });

            Task.Delay(1000);

            return lstEstudiantes;
        }

    }
}
