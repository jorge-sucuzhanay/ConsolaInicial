using Ninject.Modules;
using System;

namespace DependenciaInyecciones
{
    class InyectorNinject : NinjectModule
    {
        public override void Load()
        {
            Bind<Producir>().To<ProducirArchivoXml>();
        }
    }
}
