<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Subject.aspx.cs" Inherits="SMS2.Subject" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="sms-outer">
        <div class="sms-inner sms-formdiv">

            <div class="sms-dr">
                <div class="sms-innerLeft">Subject Name:</div>
                <div>
                    <asp:TextBox ID="TextBoxSubjectName" runat="server"></asp:TextBox>
                </div>
            </div>
            <div class="sms-dr">
                <div class="sms-innerLeft"></div>
                <div>
                    <asp:Button ID="ButtonSubmit" runat="server" Text="Submit" OnClick="ButtonSubmit_Click" />
                    <asp:Label ID="LabelMessage" runat="server" ForeColor="Red"></asp:Label>
                </div>
            </div>

        </div>

        <div class="sms-inner sms-griddiv">
            <div class="sms-griddiv">


            </div>
            </div>

    </div>

</asp:Content>
