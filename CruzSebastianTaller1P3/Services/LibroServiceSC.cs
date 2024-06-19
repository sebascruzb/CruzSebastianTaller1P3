using CruzSebastianTaller1P3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CruzSebastianTaller1P3.Services
{
    public class LibroServiceSC : ILibroServiceSC
    {
        public List<LibroSC> ObtenerLibro() 
        {
            return new List<LibroSC>
            {
        new LibroSC { Titulo = "Libro1", Autor = "autor1" },
        new LibroSC { Titulo = "Libro2", Autor = "autor2" },
        new LibroSC { Titulo = "Libro3", Autor = "autor3" },
        new LibroSC { Titulo = "Libro4", Autor = "autor4" },
        new LibroSC { Titulo = "Libro5", Autor = "autor5" },
            };
        }
    }
}
