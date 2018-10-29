using EPM.BLL.Interfaces;
using EPM.BLL.Services;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EPM.WebAPI.Util
{
    public class ProjectModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IProjectService>().To<ProjectService>();
        }
    }
}