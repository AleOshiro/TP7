using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TP7.Models
{
    public class FacturasModels
    {
        public int _id;
        public DateTime _Fecha;
        public double _Total;
        public List<DetallesModels> _Detalle;

        public FacturasModels() { }

        public FacturasModels(DateTime Fecha, double Total, List<DetallesModels> Detalle)
        {
            this._Fecha = Fecha;
            this._Total = Total;
            this._Detalle = Detalle;
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

        [Column(TypeName = "DateTime2")]
        public DateTime Fecha
        {
            get
            {
                return _Fecha;
            }
            set
            {
                _Fecha = value;
            }
        }

        public double Total
        {
            get
            {
                return _Total;
            }
            set
            {
                _Total = value;
            }
        }

        public List<DetallesModels> Detalle
        {
            set
            {
                _Detalle = value;
            }
            get
            {
                return _Detalle;
            }
        }
    }
}