using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_Clase__11
{
    internal class Recetas
    {
        public string NombreReceta {  get; set; }

        public string TipoReceta { get; set; }

        public int TiempoPreparacion { get; set; }

        public Recetas(string nombreReceta, string tipoReceta, int tiempoPreparacion)
        {
            NombreReceta = nombreReceta;
            TipoReceta = tipoReceta;
            TiempoPreparacion = tiempoPreparacion;
        }

    }
    
}
