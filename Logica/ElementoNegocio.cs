using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;


namespace Logica
{
    public class ElementoNegocio
    {
        public List<Estilo> ListarEstilo()
        {
            List<Estilo> listaEstilo = new List<Estilo>();
            AccesoDatos accesoDatos = new AccesoDatos();

            try
            {
                accesoDatos.setearConsulta("select Id, descripcion from ESTILOS;");
                accesoDatos.ejecutarLectura();

                while (accesoDatos.Lector.Read())
                {
                    Estilo aux = new Estilo();


                    aux.Id = (int)accesoDatos.Lector["Id"];
                    aux.Descripcion = (string)accesoDatos.Lector["Descripcion"];

                    listaEstilo.Add(aux);

                }
                return listaEstilo;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                accesoDatos.cerrarConexion();
            }
        }



        public List<TipoEdicion> ListarTipoEdicion()
        {
            List<TipoEdicion> listaTipoEdicion = new List<TipoEdicion>();

            AccesoDatos accesoDatos = new AccesoDatos();

            try
            {
                accesoDatos.setearConsulta("select Id, descripcion from TIPOSEDICION;");
                accesoDatos.ejecutarLectura();

                while (accesoDatos.Lector.Read())
                {
                    TipoEdicion aux = new TipoEdicion();


                    aux.Id = (int)accesoDatos.Lector["Id"];
                    aux.Descripcion = (string)accesoDatos.Lector["Descripcion"];

                    listaTipoEdicion.Add(aux);

                }
                return listaTipoEdicion;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {

                accesoDatos.cerrarConexion();
            }
        }
    }
}
