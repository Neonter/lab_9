using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_9
{
    class CRoundTube : CProfile
    {
        private double m_dDiameter; // type is not specified so lets say its double
        private double m_dThickness; // as in line 11

        public static readonly string Type = "Round tube";

        public double Diameter
        {
            get
            {
                return m_dDiameter;
            }
            set
            {
                m_dDiameter = value;
            }
        }
        public double  Thickness
        {
            get
            {
                return m_dThickness;
            }
            set
            {
                m_dThickness = value;
            }
        }
        // FYI: if i could change smth i would move thickness to CProfile and we would have -11 lines of code...
        public CRoundTube()
        {
            StructuralType = CRoundTube.Type;
        }
        public CRoundTube(double diameter, double thickness, double length, double weight) : base(length, weight)
        {
            Diameter = diameter;
            Thickness = thickness;
            StructuralType = CRoundTube.Type;
        }
        public void Show()
        {
            Console.WriteLine("Hello i am "+ CRoundTube.Type +" ,here are my parameters:\n diameter: {0}, thickness: {1}, lenght: {2}, weight per meter: {3}, type: {4}", Diameter, Thickness, Length, WeightPerMeter, StructuralType);
        }
    }
}
