using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP7.Models
{
    public class ArticulosModels
    {
        public int _id;
        public string _Codigo, _Descripcion;
        public double _Precio;

        public ArticulosModels() { }

        public ArticulosModels(string Codigo, string Descripcion, double Precio)
        {
            this._Codigo = Codigo;
            this._Descripcion = Descripcion;
            this._Precio = Precio;
        }

        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }

        public string Codigo
        {
            get
            {
                return _Codigo;
            }
            set
            {
                _Codigo = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return _Descripcion;
            }
            set
            {
                _Descripcion = value;
            }
        }

        public double Precio
        {
            get
            {
                return _Precio;
            }
            set
            {
                _Precio = value;
            }
        }
    }
}