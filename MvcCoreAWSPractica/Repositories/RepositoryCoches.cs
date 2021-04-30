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
        public void NuevoCoche(String marca,String modelo,String conductor,String imagen)
        {
            Coche car = new Coche();
            car.Idcoche = this.GetMaxId();
            car.Marcar = marca;
            car.Modelo = modelo;
            car.Conductor = conductor;
            car.Imagen = imagen;
            this.context.Coches.Add(car);
            this.context.SaveChanges();
        }
        public int GetMaxId()
        {
            return this.context.Coches.Max(x => x.Idcoche) + 1;
        }
        public void modificarCoche(int id, String marca, String modelo, String conductor, String imagen)
        {
            Coche car = this.BuscarCoche(id);
            car.Marcar = marca;
            car.Modelo = modelo;
            car.Conductor = conductor;
            car.Imagen = imagen;
            this.context.SaveChanges();
        }
    }
}
