using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP7.Models
{
    public class DetallesModels
    {
        public int _id, _facturaId, _articuloId, _cantidad;
        public double _precio;

        public DetallesModels() { }

        public DetallesModels( int Id, int FacturaId, int ArticuloId, int Cantidad, double Precio)
        {
            this._id = Id;
            this._facturaId = FacturaId;
            this._articuloId = ArticuloId;
            this._cantidad = Cantidad;
            this._precio = Precio;
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

        public int FacturaId
        {
            get
            {
                return _facturaId;
            }
            set
            {
                _facturaId = value;
            }
        }

        public int ArtciulosId
        {
            get
            {
                return _articuloId;
            }
            set
            {
                _articuloId = value;
            }
        }

        public int Cantidad
        {
            get
            {
                return _cantidad;
            }
            set
            {
                _cantidad = value;
            }
        }

        public double Precio
        {
            get
            {
                return _precio;
            }
            set
            {
                _precio = value;
            }
        }

    }
}