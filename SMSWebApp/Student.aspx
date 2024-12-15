<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Student.aspx.cs" Inherits="SMSWebApp.Student" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
 <div class="sms-outer">
        <div class="sms-inner sms-formdiv">

            <div class="sms-dr">
                <div class="sms-innerLeft">Name:</div>
                <div>
                    <asp:TextBox ID="TextBoxStudent" runat="server"></asp:TextBox>
                </div>
            </div>

            <div class="sms-dr">
                <div class="sms-innerLeft">Age:</div>
                <div>
                    <asp:TextBox ID="TextBoxAge" runat="server"></asp:TextBox>
                </div>
            </div>

            <div class="sms-dr">
                <div class="sms-innerLeft">RegNo:</div>
                <div>
                    <asp:TextBox ID="TextBoxRegNo" runat="server"></asp:TextBox>
                </div>
            </div>
            <div class="sms-dr">
                <div class="sms-innerLeft">Email:</div>
                <div>
                    <asp:TextBox ID="TextBoxEmail" runat="server"></asp:TextBox>
                </div>
            </div>
            <div class="sms-dr">
                <div class="sms-innerLeft">DOB:</div>
                <div>
                    <asp:TextBox ID="TextBoxDOB" runat="server"></asp:TextBox>
                </div>
            </div>
             <div class="sms-dr">
                <div class="sms-innerLeft"></div>
                <div>
                    <asp:Button ID="ButtonSubmit" runat="server" Text="Submit" OnClick="ButtonSubmit_Click" />
                    <asp:Label ID="Label1" runat="server" ForeColor="Red"></asp:Label>
                </div>
            </div>
        </div>

        <div class="sms-inner sms-griddiv">
            <div class="sms-griddiv">


            </div>
            </div>

    </div>

</asp:Content>
