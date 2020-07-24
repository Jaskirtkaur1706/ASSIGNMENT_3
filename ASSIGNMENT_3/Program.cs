using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Author's Name        :JASKIRAT KAUR
 * Student Number       :301107505
 * Date last modified   :2020/JULY/22
 * Program description  :Assignment_3 abstract planets
 * Revision History     :2020/JULY/22
 */
namespace ASSIGNMENT_3
{
    /*
     * This is the driver class.
    */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------Planets--------------------------");
            GiantPlanet giantplanet = new GiantPlanet("Jupiter", 139822, 1.898 * Math.Pow(10, 27), "Gas");
            Console.WriteLine(giantplanet.ToString());

            //Extra Work: to test the HasMoons, HasRings and Habitable methods
            giantplanet.MoonCount = 1;                                                                      // Assigned 1 moon to giantplanet object for testing
            Console.WriteLine("Does {0} have any moons? {1}", giantplanet.Name, giantplanet.HasMoons());
            Console.WriteLine("Does {0} have any rings? {1}", giantplanet.Name, giantplanet.HasRings());         // Did not assign any rings to giantplanet

            Console.WriteLine();
            TerrestrialPlanet terrestrialplanet = new TerrestrialPlanet("Earth", 12742, 5.972 * Math.Pow(10, 24), true);
            Console.WriteLine(terrestrialplanet.ToString());

            //Extra Work: to test the HasMoons, HasRings and Habitable methods                                             
            Console.WriteLine("Does {0} have any moons? {1}", terrestrialplanet.Name, terrestrialplanet.HasMoons());        // Did not assign any moons to terrestrialplanet
            Console.WriteLine("Is {0} habitable (does it have oxygen?) {1}", terrestrialplanet.Name, terrestrialplanet.Habitable());


            WaitForAnyKey();


        }

        static void WaitForAnyKey()
        {

            Console.WriteLine("\nPress any key!!!");
            Console.WriteLine("A wild bunny has appeared!");
            System.Console.ReadKey(true);
            Console.WriteLine("      /)/)");
            System.Console.ReadKey(true);
            Console.WriteLine("     (.__.)");
            System.Console.ReadKey(true);
            Console.WriteLine("    c(\")(\")");
            Console.ReadKey();
        }
    }
}
