<%@ Page Title="Food Details" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FoodDetails.aspx.cs" Inherits="Foodie.FoodDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:FormView ID="foodDetail" runat="server" ItemType="Foodie.Models.Food" SelectMethod ="GetFood" RenderOuterTable="false">
        <ItemTemplate>
            <div>
                <h1><%#:Item.FoodName %></h1>
            </div>
            <br />
            <table>
                <tr>
                    <td>
                        <img src="/Catalog/Images/<%#:Item.ImagePath %>" style="border:solid; height:300px" alt="<%#:Item.FoodName %>"/>
                    </td>
                    <td>&nbsp;</td>  
                    <td style="vertical-align: top; text-align:left;">
                        <b>Description:</b><br /><%#:Item.Description %>
                        <br />
                        <span><b>Price:</b>&nbsp;<%#: String.Format("{0:c}", Item.UnitPrice) %></span>
                        <br />
                        <span><b>Food Number:</b>&nbsp;<%#:Item.FoodID %></span>
                        <br />
                    </td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:FormView>
</asp:Content>
