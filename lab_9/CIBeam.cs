using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_9
{
    class CIBeam : CProfile
    {
        private double m_dHeight; // the unit is also not specified for all these 3 properties...
        private double m_dWidth;
        private double m_dThickness;

        public static readonly string Type = "I-beam";

        public double Height
        {
            get
            {
                return m_dHeight;
            }
            set
            {
                m_dHeight = value;
            }
        }
        public double Width
        {
            get
            {
                return m_dWidth;
            }
            set
            {
                m_dWidth = value;
            }
        }

        public double Thickness
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

        public CIBeam()
        {
            StructuralType = CIBeam.Type;
        }

        public CIBeam(double height, double width, double thickness, double lenght, double weightPerMeter) : base(lenght, weightPerMeter)
        {
            Width = width;
            Height = height;
            Thickness = thickness;
            StructuralType = CIBeam.Type;
            // child constructor always calls parent constructor... becouse we have such hierarchy (lets call it family)
            // parent: CProfile, child: CIBeam. So parent has to be created first (like in real life ^^) so naturally its constructor is being called and then its child constructor
            // FYI: for example in TypeScript we have to call parent constructor manually (it is obligatory there) with super() but here (c#) we dont have to. If you want parent constructor with params look at line 56
        }

        public void Show()
        {
            Console.WriteLine("Hello i am " + CIBeam.Type + " ,here are my parameters: \n lenght: {0}, weight perimeter: {1}, structural type: {2}, height: {3}, width: {4}, thickness: {5} \n", Length, WeightPerMeter, StructuralType, Height, Width, Thickness);
            // note: normally if a line is quite long its good to split it into 2 or more lines but lets not make any unnecessary changes
        }
    }
}
