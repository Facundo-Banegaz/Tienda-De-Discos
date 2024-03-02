using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Disco
    {
        //atributos y encapsulamiento

        //atributos y encapsulamiento

        [DisplayName("Título")]
        public string Titulo { get; set; }
        [DisplayName("Fecha Lanzamiento")]
        public DateTime FechaLanzamiento { get; set; }

        [DisplayName("Cantidad de Canciones")]
        public int CantidadCanciones { get; set; }

        [DisplayName("Url Img")]
        public string UrlImagenTapa { get; set; }
        [DisplayName("Precio")]

        public decimal Precio { get; set; }
        [DisplayName("Estilo")]
        public Estilo Estilo { get; set; }
        [DisplayName("Edición")]
        public TipoEdicion TipoEdicion { get; set; }
    }
}
