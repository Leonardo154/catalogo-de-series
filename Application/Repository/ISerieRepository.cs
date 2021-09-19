using System.Collections.Generic;

namespace Catalogo_series.Application.Repository
{
    interface ISerieRepository<T>
    {
        List<T> List();
        void Add(T serie);
        void Delete(int id, bool excluded);
        void Update();
    }
}
