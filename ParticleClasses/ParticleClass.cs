using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Interfaces;

namespace ParticleClasses
{
    /// <summary>
    /// Base particle class
    /// </summary>
    public class ParticleBase : IParticle
    {
        // logic to check if particle values are self-consistent
        IValidation<IParticle> validation = null;

        // values are in Hartree atomic units.
        public string name { get; set; }
        public decimal charge { get; set; }
        public decimal spin { get; set; }
        public decimal mass { get; set; }

        public ParticleBase(IValidation<IParticle> _validation)
        {
            validation = _validation;
        }

        /// <summary>
        /// Check if particle values are self-consistent using validation passed to constructor
        /// </summary>
        public virtual void Validate()
        {
            validation.Validate(this);
        }

        /// <summary>
        /// Copy the values from a different particle. (will be moved to factor later)
        /// </summary>
        /// <param name="_particle"></param>
        public virtual void CopyValues(IParticle _particle)
        {
            name = _particle.name;
            charge = _particle.charge;
            spin = _particle.spin;
            mass = _particle.mass;
        }

    }

    /// <summary>
    /// Bosons must have integral spin (this is checked in validation class).
    /// </summary>
    public class Boson : ParticleBase
    {
        public Boson(IValidation<IParticle> _validation) : base(_validation)
        {
        }
    }

    /// <summary>
    /// Fermions must have half integral spin (this is checked in validation class).
    /// </summary>
    public class Fermion : ParticleBase
    {
        public Fermion(IValidation<IParticle> _validation) : base(_validation)
        {
        }
    }
}

