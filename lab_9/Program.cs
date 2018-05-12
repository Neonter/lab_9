// Written by Piotr Szołtys 12.05.18
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_9
{
    class Program
    {
        static void Main(string[] args)
        {
            var lBeamProfile = new CIBeam(80, 80, 9, 3000, 10.7);
            var roundTubeProfile = new CRoundTube(42, 3, 2500, 2.89);
            lBeamProfile.Show();
            roundTubeProfile.Show();
            Console.WriteLine("How many profiles are necessary to degign the new construction?");
            int numberOfProfiles = Convert.ToInt32(Console.ReadLine());
            dynamic[] profileArray = new dynamic[numberOfProfiles];
            // FYI: usually you should save array length to some variable to speed up a little, becouse in the solution...
            // ... presented below profileArray.Lenght is being calculated every iteration instead of just once. But lets still keep it simple as possible
            for(int i = 0; i<profileArray.Length; i++)
            {
                profileArray[i] = AssignProfile();
            }
            Console.WriteLine("lbeamProfile overall weight: " + lBeamProfile.getOverallWeight());
            Console.WriteLine("roundTubeProfile overall weight: " + roundTubeProfile.getOverallWeight());
            foreach(var profile in profileArray)
            {
                profile.Show();
                Console.WriteLine("My overall weight: " + profile.getOverallWeight());
                Console.WriteLine("\n");
            }
            Console.ReadKey();
        }

        private static dynamic AssignProfile()
        {
            string profileType;
            do
            {
                Console.WriteLine("What is the type of the profile?");
                profileType = Console.ReadLine();
            } while (profileType != CIBeam.Type && profileType != CRoundTube.Type);
            dynamic profileTemp;
            if(profileType == CIBeam.Type)
            {
                profileTemp = AssignCIBeam();
      
            } else
            {
                profileTemp = AssignRoundTube();
            }
            return profileTemp;
        }
        private static CRoundTube AssignRoundTube()
        {
            var roundTube = new CRoundTube();
            Console.WriteLine("Assigning values to round tube profile...");
            Console.WriteLine("Input diamater:");
            roundTube.Diameter = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input thickenss:");
            roundTube.Thickness = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input length:");
            roundTube.Length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input weight per meter:");
            roundTube.WeightPerMeter = Convert.ToDouble(Console.ReadLine());
            return roundTube;
        }
        private static CIBeam AssignCIBeam()
        {
            var cBeam = new CIBeam();
            Console.WriteLine("Assigning values to round tube profile...");
            Console.WriteLine("Input heigth:");
            cBeam.Height= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input thickenss:");
            cBeam.Thickness = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input length:");
            cBeam.Length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input weight per meter:");
            cBeam.WeightPerMeter = Convert.ToDouble(Console.ReadLine());
            return cBeam;
        }
    }
}
