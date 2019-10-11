<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Foodie.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
        <div id="form2" style="max-width: 600px;">
            <div class="panel panel-default">
                <div class="panel-heading h4 text-primary text-center">Registration Page</div>
                    <div class="panel-body">
                        <div class="form-horizontal" role="form">
			                <div class="form-group">
                                <label class="col-sm-2 control-label" for="userNameLabel">UserName</label>
                                <div class="col-sm-10">
                                    <asp:textbox class="form-control" id="UserName" placeholder="Enter UserName" runat="server"></asp:textbox>
                                </div>
                             </div>
			                
                            <div class="form-group">
                                <label class="col-sm-2 control-label" for="passLabel">Password</label>
                                <div class="col-sm-10">
                                    <asp:textbox class="form-control" id="Password" placeholder="Enter Password" runat="server" textmode="Password"></asp:textbox>
                                </div>
                            </div>
			                <div class="form-group">
                                <label class="col-sm-2 control-label" for="cPassLabel">Confirm Password</label>
                                <div class="col-sm-10">
                                    <asp:textbox class="form-control" id="confirmPassword" placeholder="Enter Confirm Password" runat="server" textmode="Password"></asp:textbox>
                                </div>
                            </div>
                            <div class="form-group">
                                <label class="col-sm-2 control-label" for="fullNameLabel">FullName</label>
                                <div class="col-sm-10">
                                    <asp:textbox class="form-control" id="FullName" placeholder="Enter FullName" runat="server"></asp:textbox>
                                </div>
                             </div>
                            <div class="form-group">
                                <div class="col-sm-offset-2 col-sm-2">
                                    <asp:Button cssClass="btn btn-success" ID="submitButton" OnClick="submitButton_click" runat="server" Text="submit"></asp:Button>
                                 </div>
                                <asp:Label ID="insertedUser" runat="server"></asp:Label>
                            </div>
                                   
                    </div>
                </div>
        </div>
        </div>
</asp:Content>
