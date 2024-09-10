using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab02_MVC_Rivera_B.Models
{
    public class ClsDispensador
    {
        public double monto { get; set; }
        public double b10 { get; set; }
        public double b20 { get; set; }
        public double b50 { get; set; }
        public double b100 { get; set; }

        public double m5 { get; set; }
        public double m2 { get; set; }
        public double m1 { get; set; }
        public double m05 { get; set; }
        public double m02 { get; set; }
        public double m01 { get; set; }

        public double cantidad { get; set; }
        public double moneda { get; set; }
    }
}