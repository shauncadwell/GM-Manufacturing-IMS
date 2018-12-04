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
        //setters
        public void setFname(string f) { fName = f; }
        public void setLname(string f) { lName = f; }
        public void setID(int f) { id = f; }
        public void setRank(int f) { rank = f; }
        public void setStatus(string f) { status = f; }
        //getters
        public string getFullName() { return fName + " " + lName; }
        public string getfName() { return fName; }
        public string getlName() { return lName; }
        public string getStatus() { return status; }
        public int getRank() { return rank; }
        public int getID() { return id; }

        public void update()
        {
            //Use ProjectDB to update using runquery function
        }

        public void add()
        {
            //Use ProjectDB to add into database using runquery function
        }

        public void remove()
        {
            //Use ProjectDB to remove from database using runquery function
        }
    }
}
