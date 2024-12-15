using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Ins = ClassLibrary.Interfaces;
using Biz = ClassLibrary.BO;
namespace SMS2
{
    public partial class Student : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonSubmit_Click(object sender, EventArgs e)
        {
            Ins.IStudent student = new Biz.StudentBO().CreateStudent();

            if (!IsPostBack)
            {

                ViewState["student"] = student;
            }
            Label1.Text = "Successfully Saved!";
            
        }

    }
}