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
    public partial class Subjects : System.Web.UI.Page
    {
        

        protected void Page_Load(object sender, EventArgs e)
        {
            Ins.ISubject subject = new Biz.SubjectBO().CreateSubject();

            if (!IsPostBack)
            {
                ViewState["subject"] = subject;

            }

        }

        protected void ButtonSubmit_Click(object sender, EventArgs e)
        {
           /* if (subject.ID == null)
            {
                subject.ID = 0;
                if (TextBoxSubjectName.Text.Trim() != "")
                    subject.SubjectName = TextBoxSubjectName.Text.Trim();

                subject.User = User.Identity.Name;
                ViewState["subject"] = new Biz.SubjectBO().Save(subject);

            }
            if (subject.ID != 0)*/

                LabelMessage.Text = "Successfully Saved!";
        }
    }
}