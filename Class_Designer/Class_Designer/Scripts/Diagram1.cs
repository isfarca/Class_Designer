using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Designer
{
    class Diagram1
    {
    }

    public class Person
    {
        private string namen;
        private string telefonnummer;
        private string email;

        public Wohnadresse GetAdresse
        {
            get => default(Wohnadresse);
            set
            {
            }
        }
    }

    public class Wohnadresse
    {
        private string straße;
        private string stadt;
        private string plz;
        private string land;

        public void BestaetigeWohnadresse()
        {
            throw new System.NotImplementedException();
        }

        public void DruckeBeschriftung()
        {
            throw new System.NotImplementedException();
        }
    }

    public class Student : Person
    {
        private string materialnummer;
        private double durchschnittsnote;

        public void EinschreibeModul()
        {
            throw new System.NotImplementedException();
        }
    }

    public class Professor : Person
    {
        private double lohn;
    }
}