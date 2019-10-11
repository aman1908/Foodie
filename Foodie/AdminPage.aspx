<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AdminPage.aspx.cs" Inherits="Foodie.AdminPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div id="form2" style="max-width: 600px;">
            <div class="panel panel-default">
                <div class="panel-heading h4 text-primary text-center">Add Food Details</div>
                    <div class="panel-body">
                        <div class="form-horizontal" role="form">
                            <div class="form-group">
                                <asp:Label ID="loggedUser" runat="server"></asp:Label>
                                <label class="col-sm-2 control-label" for="txtFoodName">FoodName</label>
                                <div class="col-sm-10">
                                    <asp:textbox class="form-control" id="txtFoodName" placeholder="Enter food Name" runat="server"></asp:textbox>
                                </div>
                             </div>
                            <div class="form-group">
                                <asp:Label ID="Label2" runat="server"></asp:Label>
                                <label class="col-sm-2 control-label" for="txtDescription">Description</label>
                                <div class="col-sm-10">
                                    <asp:textbox class="form-control" id="txtDescription" placeholder="Enter food description" runat="server"></asp:textbox>
                                </div>
                             </div>
                            <div class="form-group">
                                <asp:Label ID="Label3" runat="server"></asp:Label>
                                <label class="col-sm-2 control-label" for="txtImagePath">ImagePath</label>
                                <div class="col-sm-10">
                                    <asp:textbox class="form-control" id="txtImagePath" placeholder="Enter food Image Path" runat="server"></asp:textbox>
                                </div>
                             </div>
                            <div class="form-group">
                                <asp:Label ID="Label4" runat="server"></asp:Label>
                                <label class="col-sm-2 control-label" for="txtUnitPrice">UnitPrice</label>
                                <div class="col-sm-10">
                                    <asp:textbox class="form-control" id="txtUnitPrice" placeholder="Enter food price" runat="server"></asp:textbox>
                                </div>
                             </div>
                            <div class="form-group">
                                <asp:Label ID="Label1" runat="server"></asp:Label>
                                <label class="col-sm-2 control-label" for="txtCategoryID">CategoryID</label>
                                <div class="col-sm-10">
                                    <asp:textbox class="form-control" id="txtCategoryID" placeholder="Enter Category ID" runat="server"></asp:textbox>
                                </div>
                             </div>
                            <div class="form-group">
                                <div class="col-sm-offset-2 col-sm-2">
                                    <asp:button cssclass="btn btn-success" id="btnAdd" onclick="btnAdd_Click" runat="server" text="ADD"/>
                            </div>
                            <div class="form-group">
                                 <div class="col-sm-10">
                                       <h3>Remove Food</h3>
                                   </div>
                            </div>
                            <div class="form-group">
                                <asp:Label ID="Label5" runat="server"></asp:Label>
                                <label class="col-sm-4 control-label" for="txtfoodDropDownList">Food Name</label>
                                <div class="col-sm-8">
                                    <asp:dropDownList ID="txtfoodDropDownList" runat="server">
                                        <asp:ListItem Text="Select a food"></asp:ListItem>
                                    </asp:dropDownList>
                                </div>
                             </div>
                            <div class="form-group">
                                <div class="col-sm-offset-2 col-sm-2">
                                    <asp:button cssclass="btn btn-success" id="BtnRemove" onclick="btnRemove_Click" runat="server" text="Remove"/>
                                </div>
                            </div>
                    </div>
                </div>
        </div>
     </div>
    </div>
</asp:Content>
