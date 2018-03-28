<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="OfferGenerator.aspx.cs" Inherits="HRMSWeb.OfferGenerator" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="phdBodyContent" runat="server">
     <ajaxToolkit:ToolkitScriptManager  ID="ScriptManager1" runat="server"></ajaxToolkit:ToolkitScriptManager> 
     <table style="width: 100%;" border="0">
        <tr>
            <td class="text-admin-panel" width="20%">
                Offer Code Generator
            </td>
            <td>
                 <asp:Label ID="lblMessage" runat="server" ForeColor="Red" ClientIDMode="Static"></asp:Label>&nbsp;
            </td>
        </tr>
    </table>

    <table>
               
        <tr>
            <td>
             Valid Until:
            </td>
            <td>
                <asp:TextBox ID="txtValidUntil"   runat="server" TextMode="Date"></asp:TextBox>
            </td>
        </tr>
         
        <tr>
            <td>
                &nbsp;
            </td>
            <td>
                <asp:Button ID="btnGenerate" Width="100px"  runat="server" Text="Generate" OnClick="btnGenerate_Click" />
            </td>
        </tr>
         
       
        </table>
</asp:Content>
