using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_Manufacturing_IMS
{
    public class user
    {
        int id = 0;
        int rank = 0;
        string fName = "Unknown";
        string lName = "Unknown";
        string status = "Employed";

        public void set(int uid, int urank, string ufname, string ulname, string ustatus)
        {
            id = uid;
            rank = urank;
            fName = ufname;
            lName = ulname;
            status = ustatus;
        }

        public string getFullName() { return fName + " " + lName; }
        public string getfName() { return fName; }
        public string getStatus() { return status; }
        public int getRank() { return rank; }
        public int getID() { return id; }
    }
}
