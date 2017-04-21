using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace ParticleValidations
{
    /// <summary>
    /// Base particle validation class checks if the properties of a particle are self-consistent.
    /// </summary>
    public class ValidationBase : IValidation<IParticle>
    {
        public virtual void Validate(IParticle particle)
        {
            // check if a name exists.
            if (particle.name.Length == 0)
            {
                throw new Exception("The particle must have a name.");
            }

            // check if charge is an integral value.
            if (!((Math.Abs(particle.charge) % 1 == 0)))
            {
                throw new Exception("Particles must have integral charge.");
            }
        }
    }

    /// <summary>
    /// Specific validation checks for bosons.
    /// </summary>
    public class ValidationBoson : ValidationBase
    {
        public override void Validate(IParticle particle)
        {
            base.Validate(particle);

            // check if spin is an integral value
            if (!(particle.spin % 1.0m == 0.0m))
            {
                throw new Exception("Bosons must have integral spin.");
            }
        }
    }

    /// <summary>
    /// Specific validation checks for fermions.
    /// </summary>
    public class ValidationFermion : ValidationBase
    {
        public override void Validate(IParticle particle)
        {
            base.Validate(particle);

            // check if spin is a half integral value.
            if (!((particle.spin + 0.5m) % 1.0m == 0.0m))
            {
                throw new Exception("Fermions must have half-integral spin.");
            }
        }
    }
}
