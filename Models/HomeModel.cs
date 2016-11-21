using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CodingChallenge.Data.DataAccess;
using CodingChallenge.Data.Classes;

namespace CodingChallenge.Models
{
    public class HomeModel
    {
        public List<Titulo> tituloList
        {
            get
            {
                List<Titulo> tituloList = new List<Titulo>();
                var repositorio = new MockRepository().TituloRepository;
                var titulos = repositorio.GetTitulos();
                foreach (var t in titulos)
                {
                    tituloList.Add(t);
                }
                return tituloList;
            }
        }

        public string tituloDeBolsaName { get; set; }
    }
}