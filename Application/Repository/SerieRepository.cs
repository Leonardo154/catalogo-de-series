using Catalogo_series.Application.Model;
using System;
using System.Collections.Generic;

namespace Catalogo_series.Application.Repository
{
    public class SerieRepository : ISerieRepository<Serie>
    {
        static List<Serie> series = new List<Serie>();
        public void Add(Serie serie)
        {
            series.Add(serie);
        }

        public void Delete(int id, bool excluded)
        {
            series[id].Excluded = excluded;
        }

        public List<Serie> List()
        {
            return series;
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
