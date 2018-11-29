using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*Class creation to handle keeping new form creation inside the MAIN window. */

namespace GB_Manufacturing_IMS
{
    class appForm
    {
        //createWindow to show new form. 
        public void createWindow(string name, Form currentForm, Form targetForm, bool isDiag)
    {
        bool isOpen = false;
        foreach (Form f in Application.OpenForms)
        {
            if (f.Text == "Form")
            {
                isOpen = true;
                f.Focus();
                break;
                    //comment to force change
                    // Kyle was here
            }
        }
        if (isOpen == false) 
        {
            if (isDiag)
                {
                    targetForm.ShowDialog();
                }
            else
                {
                    targetForm.MdiParent = currentForm;
                    targetForm.Dock = DockStyle.Fill;
                    targetForm.WindowState = FormWindowState.Maximized;
                    targetForm.Show();
                }
         
        }
    }
    }
    

}

