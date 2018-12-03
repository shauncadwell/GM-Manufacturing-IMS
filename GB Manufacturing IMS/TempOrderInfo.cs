using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_Manufacturing_IMS
{
    class TempOrderInfo : IEquatable<TempOrderInfo>
    {
        public int itemNumber { get; set; }
        public int jobCode { get; set; }
        public string description { get; set; }
        public int quantity { get; set; }

        // Displays list item
        public string displayEntry()
        {
            return "Item Number: " + itemNumber + "\t Description: " + description + "\t Quantity: " + quantity + Environment.NewLine;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            TempOrderInfo objAsPart = obj as TempOrderInfo;
            if (objAsPart == null) return false;
            else return Equals(objAsPart);
        }

        public bool Equals(TempOrderInfo other)
        {
            throw new NotImplementedException();
        }
    }
}
