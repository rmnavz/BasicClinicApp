using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNETCore_WebApp.Data
{
    public class DbInitializer
    {
        public static void Initialize(DatabaseContext context)
        {
            context.Database.EnsureCreated();

            ////Look for any Pages.
            //if (context.Sys_Pages.Any())
            //{
            //    return; //DB has been seeded
            //}

            ////Setup your pages here
            //var Sys_Pages = new Sys_PageModel[]
            //{
            //    new Sys_PageModel
            //    {
            //        PageTitle = "Home",
            //        PageDescription = "The home page of the website",
            //        PageController = "Home",
            //        PageAction = "Index",
            //        IsPublic = true,
            //        DateCreated = DateTime.Now,
            //        IsEnabled = true
            //    }
            //};

            ////Add Pages to the system page database
            //foreach (Sys_PageModel page in Sys_Pages)
            //{
            //    context.Sys_Pages.Add(page);
            //}
            //context.SaveChanges();
        }
    }
}
