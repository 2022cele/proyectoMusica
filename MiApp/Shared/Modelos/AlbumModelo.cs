using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiApp.Shared
{
    public class AlbumModelo
    {
        /// <summary>
        ///  Modelo para tabla Album
        ///  Album:id, nombre, idArtista
        /// </summary>
        
        public int id { get; set; }
        public string nombre { get; set; }
        public int idArtista { get; set; }

    }
}
