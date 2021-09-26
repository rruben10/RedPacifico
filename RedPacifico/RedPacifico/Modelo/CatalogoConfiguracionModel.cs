using RedPacifico.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RedPacifico.Entity;

namespace RedPacifico.Modelo
{
    class CatalogoConfiguracionModel
    {
        public Configuracion ObtenerConfiguracion()
        {
            Configuracion conf = new Configuracion();
            try
            {
                using(sistemaEntities2 db = new sistemaEntities2())
                {
                    var configuracion = db.configuracion.ToList();

                    foreach(var dbConfig in configuracion)
                    {
                        conf.IdConfiguracion = int.Parse(dbConfig.id.ToString());
                        conf.TasaFinanciamiento = dbConfig.tasa;
                        conf.PorcentajeEnganche = dbConfig.enganche;
                        conf.Plazo = dbConfig.plazo;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            return conf;
        }
        public Boolean ModificarConfiguracion(int idConfig, float tasaFinanciamiento, float porcentajeEnganche, short plazo)
        {
            bool graboConfig = false;
            try
            {
                //Modifico decimales a 2
                tasaFinanciamiento = float.Parse(String.Format("{0:0.00}", tasaFinanciamiento));
                porcentajeEnganche = float.Parse(String.Format("{0:0.00}", porcentajeEnganche));
                if (idConfig == 0)
                {
                    using (sistemaEntities2 db = new sistemaEntities2())
                    {
                        configuracion oConfig = new configuracion
                        {
                            tasa = tasaFinanciamiento,
                            enganche = porcentajeEnganche,
                            plazo = plazo
                        };

                        db.configuracion.Add(oConfig);
                        db.SaveChanges();
                        graboConfig = true;
                    }

                }
                else
                {
                    using (sistemaEntities2 db = new sistemaEntities2())
                    {
                        var config = db.configuracion.Find(idConfig);

                        config.id = idConfig;
                        config.tasa = tasaFinanciamiento;
                        config.enganche = porcentajeEnganche;
                        config.plazo = plazo;

                        db.Entry(config).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                        graboConfig = true;
                    }
                }
            }
            catch (Exception e)
            {

                throw e;
            }

            return graboConfig;
        }
    }
}
