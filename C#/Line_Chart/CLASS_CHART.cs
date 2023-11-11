using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line_Chart
{
    public class CLASS_CHART
    {
        public string Lacation { get; set; }

        public decimal M1 { get; set; }

        public decimal M2 { get; set; }

        public decimal M3 { get; set; }

        public decimal M4 { get; set; }

        public decimal M5 { get; set; }

        public decimal M6 { get; set; }

        public decimal M7 { get; set; }

        public decimal M8 { get; set; }

        public decimal M9 { get; set; }

        public decimal M10 { get; set; }

        public decimal M11 { get; set; }

        public decimal M12 { get; set; }


        public object this[string property_name]
        {
            get { return this.GetType().GetProperty(property_name).GetValue(this, null); }
            set { this.GetType().GetProperty(property_name).SetValue(this, value, null); }
        }
    }
}
