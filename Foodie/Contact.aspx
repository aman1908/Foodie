<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="Foodie.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        <div id="form2" style="max-width: 600px;">
            <div class="panel panel-default">
                <div class="panel-heading h4 text-primary text-center">Your contact page.</div>
                    <div class="panel-body">
                        <div class="form-horizontal" role="form">
                            <div class="form-group">
                                <label class="col-sm-2 control-label" for="txtName">Name</label>
                                <div class="col-sm-10">
                                    <asp:textbox class="form-control" id="txtName" placeholder="Enter Name" runat="server"></asp:textbox>
                                </div>
                             </div>
                            <div class="form-group">
                                <label class="col-sm-2 control-label" for="txtContact">Contact Number</label>
                                <div class="col-sm-10">
                                    <asp:textbox class="form-control" id="txtContact" placeholder="Enter Contact Number" runat="server"></asp:textbox>
                                </div>
                            </div>
                            <div class="form-group">
                                <div class="col-sm-offset-2 col-sm-2">
                                    <asp:button cssclass="btn btn-success" id="btnSubmit" onclick="btnSubmit_Click" runat="server" text="submit" />
                            </div>
                    </div>
                </div>
        </div>
     </div>
         <strong>Support:</strong>   <a href="mailto:Support@example.com">Support@example.com</a><br />
        <strong>Marketing:</strong> <a href="mailto:Marketing@example.com">Marketing@example.com</a>
    </div>

       
    
</asp:Content>
