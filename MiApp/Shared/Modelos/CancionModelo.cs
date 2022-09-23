using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiApp.Shared
{
    public class CancionModelo
    {
        /*<summary>
         * Modelo de Cancion
         * Tabla Cancion: id, nombreCancion, duracion, genero, idAlbum. 
         */
        public int id { get; set; }
        public string nombre { get; set; }
        public string tiempo { get; set; }
        public string genero { get; set; }
        public int idAlbum { get; set; }
        
    }
}
