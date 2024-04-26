using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using ODataProject.Service;

namespace ODataProject.Controller
{
    public class MyDataController : ODataBaseController
    {
        public MyDataController(DatabaseService databaseService) : base(databaseService) { }

        [EnableQuery]
        public IQueryable<object> Get()
        {
            // This would be the data source from which queries are derived
            //var queryableData = ...; // How you generate this will depend on your application logic

            //return queryableData;

            return null;
        }
    }

}
