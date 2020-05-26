using LugaPasalDataBase;
using LugaPasalModals;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LugaPasalServices
{
    public class ConfigurationServices
    {

        //public  static  ConfigurationServices classObject { get 
        //    {
        //        if (privateInmemory == null)
        //        {
        //            privateInmemory = new ConfigurationServices();
        //        }

        //        return classObject;
                
            
        //    } } // arko class bata get garna milos vanera
        //private static   ConfigurationServices privateInmemory { get; set; }


        //private ConfigurationServices()
        //{


        //}


        public config GetConfig(string key)
        {
            using (var database = new PrkStoreEntities())
            {
                {
                    var all = database.tblConfigurations.Where(x => x.Key == key).
                        Select(x => new config

                        {
                            value = x.value

                        }).FirstOrDefault();
                    return all;
                   

                    
                }

            }
        }
    }
}
