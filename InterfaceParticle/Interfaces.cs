using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    /// <summary>
    /// Interface for main particle class.
    /// </summary>
    public interface IParticle
    {
        string name { get; set; }
        decimal charge { get; set; }
        decimal spin { get; set; }
        decimal mass { get; set; }

        void Validate();
        void CopyValues(IParticle _particle);
    }

    /// <summary>
    /// Interface for particle validation methods.
    /// </summary>
    /// <typeparam name="Type"></typeparam>
    public interface IValidation<Type>
    {
        void Validate(Type particle);
    }

    /// <summary>
    /// Interface for particle database.
    /// </summary>
    public interface IDataBase<Type>
    {
        void Add(Type particle);
        void Save();
    }
}
