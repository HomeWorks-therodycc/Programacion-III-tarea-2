using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace Tarea_II.Pages
{
    public class SacadoDatos
    {
        public List<Result> Conseguir()
        {
         
                WebClient cliente = new WebClient();
                var api = "https://randomuser.me/api/?results=1";
                var datos = cliente.DownloadString(api);
                var resultado = JsonConvert.DeserializeObject<Root>(datos);

                return resultado.results;
       
        }
    }
}
