using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_2017
{
    /// <summary>
    /// La clase Producto será abstracta, evitando que se instancien elementos de este tipo.
    /// //ok fede
    /// </summary>
    public abstract class Producto
    {
       public enum EMarca
        {
            Serenisima, Campagnola, Arcor, Ilolay, Sancor, Pepsico
        }
        EMarca _marca;
        string _codigoDeBarras;
        ConsoleColor _colorPrimarioEmpaque;

        public Producto(string codigo, EMarca marca, ConsoleColor col)
        {
            this._marca=marca;
            this._codigoDeBarras = codigo;
            this._colorPrimarioEmpaque = col;
        }

        /// <summary>
        /// ReadOnly: Retornará la cantidad de ruedas del vehículo
        /// </summary>
       public/* abstract*/ virtual short CantidadCalorias { get; set; } //agrego public y virtual y quito abstract

        /// <summary>
        /// Publica todos los datos del Producto.
        /// </summary>
        /// <returns></returns>
       /* sealed*/ public virtual string Mostrar() //agrego public y virtual
        {
            return this;
        }

       /* private*/ public static /*explicit*/ implicit operator string(Producto p) //quito private y pongo public, y cambio explicit por implicit, pq por algun lado tengo "return this"
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("CODIGO DE BARRAS: "+p._codigoDeBarras+"\r\n");
            sb.AppendLine("MARCA          : "+p._marca.ToString()+"\r\n");
            sb.AppendLine("COLOR EMPAQUE  : "+p._colorPrimarioEmpaque.ToString()+"\r\n");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }

        /// <summary>
        /// Dos productos son iguales si comparten el mismo código de barras
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator ==(Producto v1, Producto v2)
        {
            return (v1._codigoDeBarras == v2._codigoDeBarras);
        }
        /// <summary>
        /// Dos productos son distintos si su código de barras es distinto
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator !=(Producto v1, Producto v2)
        {
            return (v1._codigoDeBarras == v2._codigoDeBarras);
        }
    }
}
