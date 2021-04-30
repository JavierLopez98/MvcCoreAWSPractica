using MvcCoreAWSPractica.Data;
using MvcCoreAWSPractica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreAWSPractica.Repositories
{
    public class RepositoryCoches
    {
        public CochesContext context;
        public RepositoryCoches(CochesContext context)
        {
            this.context = context;
        }
        public List<Coche> GetCoches()
        {
            return this.context.Coches.ToList();
        }
        public Coche BuscarCoche(int id)
        {
            return this.context.Coches.SingleOrDefault(x => x.Idcoche == id);
        }
    }
}
