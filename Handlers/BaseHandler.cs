using ApiMeatTemp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiMeatTemp.Handlers
{
    
    public class BaseHandler
    {
        protected FoodContext FoodDb = new FoodContext();

        
    }
}