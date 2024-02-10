using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace _10._1
{
    internal class Angle
    {
        int gradus;
        int min;
        int sec;
        public bool IsCorrect = true;
        public Angle(int gradus, int min, int sec)
        {   
            this.Gradus = gradus;
            this.Min = min;
            this.Sec = sec;
        }
        //1 angle = 360 gradus
        //1 gradus = 60 min
        // 1 min = 60 sec
        public int Gradus
        {   
            get 
            { 
                return gradus; 
            }
            set
            {   
                if (value < 0)
                {
                    IsCorrect = false;
                }
                else
                {
                    gradus = value % 360;
                }
            }
        }
        public int Min
        {
            get
            {
                return min;
            }
            set
            {   
                if (value < 0)
                {
                    IsCorrect = false;
                }
                else 
                {
                    Gradus += value / 60;
                    min += value % 60;
                }
            }
        }
        public int Sec
        {
            get
            {
                return sec;
            }
            set
            {
                if (value < 0)
                {
                    IsCorrect = false;
                }
                else
                {
                    Min += value / 60;
                    sec += value % 60;
                }
            }
        }

        public float GetAngle()
        {
            return (float)gradus + (float)min /60 + (float)sec /(60*60);
        }

        public double GetRadians()
        {   
            float angle = GetAngle();
            return (Math.PI) * angle / 180;
        }
    }
}
