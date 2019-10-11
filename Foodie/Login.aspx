<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Foodie.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
        <div id="form2" style="max-width: 600px;">
            <div class="panel panel-default">
                <div class="panel-heading h4 text-primary text-center">Login Page</div>
                    <div class="panel-body">
                        <div class="form-horizontal" role="form">
                            <div class="form-group">
                                <asp:Label ID="loggedUser" runat="server"></asp:Label>
                                <label class="col-sm-2 control-label" for="txtUserName">UserName</label>
                                <div class="col-sm-10">
                                    <asp:textbox class="form-control" id="txtUserName" placeholder="Enter UserName" runat="server"></asp:textbox>
                                </div>
                             </div>
                            <div class="form-group">
                                <label class="col-sm-2 control-label" for="txtpwd">Password</label>
                                <div class="col-sm-10">
                                    <asp:textbox class="form-control" id="txtpwd" placeholder="Enter Password" runat="server" textmode="Password"></asp:textbox>
                                </div>
                            </div>
                            <div class="form-group">
                                <div class="col-sm-offset-2 col-sm-2">
                                    <asp:button cssclass="btn btn-success" id="btnLogin" onclick="btnLogin_Click" runat="server" text="Login">
                                </asp:button></div>
                                    <div class="col-sm-4">
                                    <asp:button cssclass="btn btn-success" id="btnRegister" runat="server" text="Have Account?" OnClick="btnRegister_Click">
                                </asp:button></div>
                            </div>
                    </div>
                </div>
        </div>
     </div>
</asp:Content>
