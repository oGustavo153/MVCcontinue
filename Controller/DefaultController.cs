using MVC.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.Controller
{
    internal class DefaultController
    {
        protected static DataContext dataContext = new DataContext();
    }
}
