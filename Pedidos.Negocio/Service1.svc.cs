using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Pedidos.AccesoDatos;

namespace Pedidos.Negocio
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IWebService
    {
        public int id_producto { get; set; }
        public String nombre { get; set; }
        public decimal precio { get; set; }
        public String img { get; set; }
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public List<Service1> obtenerProductos()
        {
            using (BD_PEDIDO_Contexto contexto = new BD_PEDIDO_Contexto()) {
                var l = new BD_PEDIDO_Contexto().PRODUCTO.Select(
                    ent_prod => new Service1 {
                        id_producto = ent_prod.id_producto,
                        nombre = ent_prod.nombre,
                        precio = ent_prod.precio,
                        img = ent_prod.img
                    }).ToList();

                return l;
            }
        }
    }
}
