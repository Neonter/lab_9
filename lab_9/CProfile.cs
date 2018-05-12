using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_9
{
    class CProfile
    {
        private double m_dLength;  //lenght of structural [mm]
        private double m_dWeightPerMeter; //weight of structural per 1 meter [kg/m]
        private string m_sType = "unknown"; //type of structural -> this could be moved to constructor

        public double Length
        {
            get { return m_dLength; }
            set { m_dLength = value; }
        }

        public double WeightPerMeter
        {
            get { return m_dWeightPerMeter; }
            set { m_dWeightPerMeter = value; }
        }

        public string StructuralType
        {
            get { return m_sType; }
            set { m_sType = value; }
        }


        public CProfile()
        {
            m_dLength = 0; // this is not needed, but was mentioned to be included, instead type (m_sType) could be moved here instead it is in line 13  
            m_dWeightPerMeter = 0; // this is also not needed
        }

        public CProfile(double length, double weightPerMeter)
        {
            Length = length;
            WeightPerMeter = weightPerMeter;
        }
        // Access specifier is not mentioned in exercised so we could also use "internal" here, if you are interested read about it ;)
        public double getOverallWeight() { // note: usually method names should start with capital, but as we want to have best grade we will do as it is in instruction...
            return Length/1000*WeightPerMeter; // there is no information what should be the result unit... so lets assume its [kg] as the m_dWeightPerMeter is [kg/m]
        }
        // FYI: when we have such simple method we could use arrow methods (called lambdas):
        // public double getOverallWeight() => Length * 1000 * WeightPerMeter;
        // it is your choise


    }
}
