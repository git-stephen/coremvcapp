using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using coremvcapp.Models;

namespace coremvcapp.Helper
{
    public class ActionFilterHelper : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)       
        {
            //Inject some code to be executed before action start executing
            
            base.OnActionExecuting(filterContext); 
        }
        
    }
}
