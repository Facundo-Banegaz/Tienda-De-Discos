using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;


namespace Logica
{
    public class CN_Genero
    {
        public List<Disco> listarDiscos()
        {
            AccesoDatos accesoDatos = new AccesoDatos();


            //atributo
            List<Disco> discos = new List<Disco>();

            try
            {


                accesoDatos.setearConsulta("select  D.Titulo, D.FechaLanzamiento, D.CantidadCanciones, D.UrlImagenTapa, D.Precio,T.Descripcion as Edicion, E.Descripcion as Estilo  from DISCOS D inner join ESTILOS E on  D.IdEstilo = E.Id inner join TIPOSEDICION T on D.IdTipoEdicion = T.Id;");

                accesoDatos.ejecutarLectura();

                while (accesoDatos.Lector.Read())
                {
                    Disco aux = new Disco();

                    aux.Titulo = (string)accesoDatos.Lector["Titulo"];
                    aux.FechaLanzamiento = (DateTime)accesoDatos.Lector["FechaLanzamiento"];
                    aux.CantidadCanciones = (int)accesoDatos.Lector["CantidadCanciones"];
                    aux.Precio = (decimal)accesoDatos.Lector["Precio"];
                    aux.Estilo = new Estilo();

                    aux.Estilo.Descripcion = (string)accesoDatos.Lector["Estilo"];

                    aux.TipoEdicion = new TipoEdicion();

                    aux.TipoEdicion.Descripcion = (string)accesoDatos.Lector["Edicion"];

                    ////if (!(lector.IsDBNull(lector.GetOrdinal("UrlImagenTapa"))))
                    if (!(accesoDatos.Lector["UrlImagenTapa"] is DBNull))
                        aux.UrlImagenTapa = (string)accesoDatos.Lector["UrlImagenTapa"];


                    discos.Add(aux);
                }

                accesoDatos.cerrarConexion();
                return discos;
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

        public void Agregar(Disco disco)
        {
            AccesoDatos accesoDatos = new AccesoDatos();

            try
            {



                accesoDatos.setearConsulta("insert into DISCOS (Titulo, FechaLanzamiento,CantidadCanciones, UrlImagenTapa,IdEstilo,IdTipoEdicion,Precio)values (@Titulo,@FechaLanzamiento,@CantidadCanciones,@UrlImagenTapa,@IdEstilo,@IdTipoEdicion,@Precio)");

                accesoDatos.setearParametro("@Titulo", disco.Titulo);
                accesoDatos.setearParametro("@FechaLanzamiento", disco.FechaLanzamiento.ToString("yyyy-MM-dd hh:mm:ss"));
                accesoDatos.setearParametro("@CantidadCanciones", disco.CantidadCanciones);

                accesoDatos.setearParametro("@UrlImagenTapa", disco.UrlImagenTapa);
                accesoDatos.setearParametro("@IdEstilo", disco.Estilo.Id);
                accesoDatos.setearParametro("@IdTipoEdicion", disco.TipoEdicion.Id);
                accesoDatos.setearParametro("@Precio", disco.Precio);

                accesoDatos.ejecutarAccion();
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

        public void Modificar(Disco disco)
        {
            AccesoDatos accesoDatos = new AccesoDatos();

            try
            {
                accesoDatos.setearConsulta("update  DISCOS set Titulo=@Titulo, FechaLanzamiento=@FechaLanzamiento, CantidadCanciones=@CantidadCanciones, UrlImagenTapa=@UrlImagenTapa, IdEstilo=@IdEstilo, IdTipoEdicion=@IdTipoEdicion, Precio=@Precio  where Id=@Id;");
                
                accesoDatos.setearParametro("@Titulo", disco.Titulo);
                accesoDatos.setearParametro("@FechaLanzamiento", disco.FechaLanzamiento.ToString("yyyy-MM-dd hh:mm:ss"));
                accesoDatos.setearParametro("@CantidadCanciones", disco.CantidadCanciones);

                accesoDatos.setearParametro("@UrlImagenTapa", disco.UrlImagenTapa);
                accesoDatos.setearParametro("@IdEstilo", disco.Estilo.Id);
                accesoDatos.setearParametro("@IdTipoEdicion", disco.TipoEdicion.Id);
                accesoDatos.setearParametro("@Precio", disco.Precio);
                accesoDatos.ejecutarAccion();
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


        public void Eliminar(int Id)
        {
            AccesoDatos accesoDatos = new AccesoDatos();
            try
            {
                accesoDatos.setearConsulta("Delete from ARTICULOS where Id=@Id");
                accesoDatos.setearParametro("@Id", Id);

                accesoDatos.ejecutarAccion();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                accesoDatos.cerrarConexion();
            }
        }
    }
}
