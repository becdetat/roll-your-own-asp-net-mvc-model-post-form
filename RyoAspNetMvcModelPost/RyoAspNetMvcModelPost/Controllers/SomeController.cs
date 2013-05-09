using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RyoAspNetMvcModelPost.Models;

namespace RyoAspNetMvcModelPost.Controllers
{
    public class SomeController : Controller
    {
        ParentViewModel PretendRepository()
        {
            var children = new[]
                {
                    new ChildItemViewModel("a01", "Ho", ChildState.StateIsFalse),
                    new ChildItemViewModel("b02", "Hum", ChildState.StateIsFalse),
                    new ChildItemViewModel("c03", "Whatevs", ChildState.StateIsFalse),
                };
            return new ParentViewModel("Boring", children);
        }
        
        public ActionResult Index()
        {
            return View(PretendRepository());
        }

        public ActionResult IndexSubmit(ParentViewModel viewModel)
        {
            throw new NotImplementedException("Set a breakpoint on me to see the view model!!!1!");
            
            // TIP: What gets set in the view model is _only_ what is set in the request. And what is set in the request
            // _cannot be trusted_ ooh scary...
        }

    }
}
