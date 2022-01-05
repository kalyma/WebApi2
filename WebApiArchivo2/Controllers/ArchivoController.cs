using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.IO;
//using System.Web.Http.Cors;
using System.Threading.Tasks;
using System.Web;
using WebApiArchivo2;

namespace WebApiArchivo.Controllers
{
    //--[EnableCors("http s://localhost:44376", "*", "get")]
    public class ArchivoController : ApiController
    {
        private static readonly List<CasasRequest> Casas = CrearCasas();


        private static List<CasasRequest> CrearCasas()
        {
            var Casas = new List<CasasRequest>();
            var lista = new List<int>();

            lista.Add(1); lista.Add(1); lista.Add(1); lista.Add(0); lista.Add(1); lista.Add(1); lista.Add(1); lista.Add(1);
            Casas.Add(new CasasRequest { dias = 1, lstCasas = lista});
         
            return Casas;
        }

        public CasasResponses Post(CasasRequest entrada)
        {
            var respuesta = new CasasResponses();
            int h = 0;int g = 0;
            respuesta.dias = entrada.dias;
            respuesta.entrada = entrada.lstCasas;
            var listaSalida = new List<int>();

            var listaAuxiliar = new List<int>();

            listaAuxiliar = entrada.lstCasas;

            for (int i = 0; i < respuesta.dias; i++)
            {
               
                if (h == listaAuxiliar[1])
                    listaSalida.Add(0);
                else
                    listaSalida.Add(1);

                if (listaAuxiliar[0]== listaAuxiliar[2])
                    listaSalida.Add(0);
                else
                    listaSalida.Add(1);

                if (listaAuxiliar[1] == listaAuxiliar[3])
                    listaSalida.Add(0);
                else
                    listaSalida.Add(1);

                if (listaAuxiliar[2] == listaAuxiliar[4])
                    listaSalida.Add(0);
                else
                    listaSalida.Add(1);

                if (listaAuxiliar[3] == listaAuxiliar[5])
                    listaSalida.Add(0);
                else
                    listaSalida.Add(1);

                if (listaAuxiliar[4] == listaAuxiliar[6])
                    listaSalida.Add(0);
                else
                    listaSalida.Add(1);

                if (listaAuxiliar[5] == listaAuxiliar[7])
                    listaSalida.Add(0);
                else
                    listaSalida.Add(1);

                if (g == listaAuxiliar[6])
                    listaSalida.Add(0);
                else
                    listaSalida.Add(1);

                listaAuxiliar = new List<int>(listaSalida);

                listaSalida.Clear();
            }

            
            respuesta.salida = listaAuxiliar;

            return respuesta;

        }


    }
}