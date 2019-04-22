using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCThreading.Libraries.BusinessRules.DataAccess
{
    public static class DataModelManager
    {
        public static DataAccessManager.DataModels.BasicModel.PLEToteEntities PleBasicModel
        {
            get
            {
                //string enviroment = ConfigurationManager.AppSettings["PLETote_Mode"];

                //switch (enviroment)
                //{
                //    //case "desarrollo":
                //    //    return new DataAccessManager.Desarrollo.DataModels.PLETote.PLEToteDesarrolloEntities();
                //    case "produccion":
                var db = new DataAccessManager.DataModels.BasicModel.PLEToteEntities();
                db.Database.CommandTimeout = 380;
                return db;
                //    default:
                //        throw new Exception("Fatal error: missing or incorrect enviroment key/value in web/app.config for PLETote model");
                //}
            }
        }
    }
}
