using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Author's Name        :JASKIRAT KAUR
 * Student Number       :301107505
 * Date last modified   :2020/JULY/22
 * Program description  :Assignment_3 Terrestrialplanet class
 * Revision History     :2020/JULY/22
 */

namespace ASSIGNMENT_3
{
    /// <summary>
    /// This is the TerrestrialPlanet class
    /// </summary>
    public class TerrestrialPlanet : Planet, IHasMoons, IHabitable
    {
        // private instance variables (fields)
        private bool _oxygen;

        // public properties

        /// <summary>
        /// This is the constructor which takes the parameters of the planet base class and adds an oxygen bool variable
        /// </summary>
        /// <jk name="name"></jk>
        /// <jk name="diameter"></jk>
        /// <jk name="mass"></jk>
        /// <jk name="oxygen"></jk>
        // constructors -----------------------------------------------------------
        public TerrestrialPlanet(string name, double diameter, double mass, bool oxygen) : base(name, diameter, mass)
        {
            this._oxygen = oxygen;
        }

        // private methods


        // public methods
        /// <summary>
        /// These public methods will return if satisfied
        /// </summary>
        public bool HasMoons()
        {
            return MoonCount > 0;
        }

        public bool Habitable()
        {
            return _oxygen = true;
        }

        /// <summary>
        /// Extra: This is the ToString method specific for TerrestrialPlanet Class
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string output = this.Name + " | " + " Diameter = " + this.Diameter + " km | Mass = " + this.Mass + " kg | Oxygen? = " + this._oxygen;
            return output;
        }

    }
}
