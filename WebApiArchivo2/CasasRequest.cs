using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiArchivo2
{
    public class CasasRequest
    {
        public int dias { get; set; }
        public List<int> lstCasas { get; set; }
    }
}