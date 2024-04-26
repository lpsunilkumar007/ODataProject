using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using Microsoft.OData.Edm;
using ODataProject.Service;

namespace ODataProject.Controller
{
    public class ODataBaseController : ODataController
    {
        private readonly DatabaseService _databaseService;

        public ODataBaseController(DatabaseService databaseService)
        {
            _databaseService = databaseService;
        }

        //protected IEdmModel BuildEdmModel()
        //{
        //    var tablesAndViews = _databaseService.GetAllTablesAndViews();

        //    var builder = new EdmModelBuilder();
        //    foreach (var name in tablesAndViews)
        //    {
        //        // You would map these to entity sets or other parts of the model here
        //        builder.AddEntityType(name);
        //    }

        //    return builder.GetEdmModel();
        //}
    }
}
