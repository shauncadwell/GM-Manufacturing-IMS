using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GB_Manufacturing_IMS
{
    class appForm
    {
        public void showWindow(string name, Form currentForm, Form targetForm, bool isDiag)
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

