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
                profileArray[i] = null;
            }
        }

        private static T AssignProfile<T>() // i am really sorry but using generic types makes it easier and shorter
        {
            T profileToAdd;
            string profileType;
            do
            {
                Console.WriteLine("What is the type of the profile?");
                profileType = Console.ReadLine();
            } while (profileType != CIBeam.Type && profileType != CRoundTube.Type);
            dynamic profileTemp;
            if(profileType == CIBeam.Type)
            {
                profileTemp = new CIBeam();
            } else
            {
                profileTemp = new CRoundTube();
            }
            profileToAdd = profileTemp;
            return profileToAdd; // UNFINISHED!!!
        }
    }
}
