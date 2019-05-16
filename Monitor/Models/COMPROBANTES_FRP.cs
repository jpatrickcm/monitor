using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Monitor.Models
{
    public class COMPROBANTES_FRP
    {
        public string RUC { get; set; }
        public string COMPROBANTE { get; set; }
        public string SERIE { get; set; }
        public int CORRELATIVO { get; set; }
        public string FECHA_EMISION { get; set; }
        public string FECHA_CARGA { get; set; }
        public string ESTADO { get; set; }
        public int NUMERO_EMPRESA { get; set; }
        public string MENSAJE { get; set; }
    }
}