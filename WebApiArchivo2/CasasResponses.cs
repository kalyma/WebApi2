using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiArchivo2
{
    public class CasasResponses
    {
        public int dias { get; set; }
        public List<int> entrada { get; set; }
        public List<int> salida { get; set; }
    }
}