using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParticleClasses;
using Microsoft.Practices.Unity;
using Interfaces;
using ParticleValidations;
using DAL;

namespace Factory
{
    /// <summary>
    /// Creates particles and data layers.
    /// </summary>
    /// <typeparam name="Type"></typeparam>
    public static class Factory<Type>
    {
        private static IUnityContainer container = null;

        public static Type Create(string typeName)
        {
            if(container == null)
            {
                container = new UnityContainer();
                container.RegisterType<IParticle, Fermion>("fermion", new InjectionConstructor(new ValidationFermion()));
                container.RegisterType<IParticle, Boson>("boson", new InjectionConstructor(new ValidationBoson()));
                container.RegisterType<IDataBase<IParticle>, ParticleDataLayer>("ParticleDAL");
            }
            return container.Resolve<Type>(typeName,
                                            new ResolverOverride[]
                                            {
                                                // supply correct path to your database .mdf here (not required to run program)
                                                new ParameterOverride("_connection", @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nicholas\documents\visual studio 2017\Projects\ClassLibrary1\Database\ParticleDatabase.mdf;Integrated Security=True")
                                            });
        }
    }
}
