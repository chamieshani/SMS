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
    public partial class Subject : System.Web.UI.Page
    {
        Ins.ISubject subject;

        protected void Page_Load(object sender, EventArgs e)
        { 

            if (!IsPostBack)
            {
                ViewState["subject"] = new Biz.SubjectBO().CreateSubject();

            }

        }

        protected void ButtonSubmit_Click(object sender, EventArgs e)
        {
            subject = ViewState["subject"] as Ins.ISubject;
            if (subject.ID == null)
            {

                subject.ID = 0;
                if (TextBoxSubjectName.Text.Trim() != "")
                    subject.SubjectName = TextBoxSubjectName.Text.Trim();

                subject.User = User.Identity.Name;
                ViewState["subject"] = new Biz.SubjectBO().Save(subject);

            }
            if (subject.ID != 0)

                LabelMessage.Text = "Successfully Saved!";
        }
    }
}