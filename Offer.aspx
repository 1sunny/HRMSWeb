<%@ Page Title="" Language="C#" MasterPageFile="~/MellowYellow.Master" AutoEventWireup="true" CodeBehind="Offer.aspx.cs" Inherits="HRMSWeb.Offer" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="phdBodyContent" runat="server">
     <ajaxToolkit:ToolkitScriptManager  ID="ScriptManager1" runat="server"></ajaxToolkit:ToolkitScriptManager> 
       <script type="text/javascript">
          $(document).ready(function () {

              $('#mnReport').hide();
              
        });
       </script>
    <table style="width: 100%;" border="0">
        <tr>
            <td class="text-admin-panel" width="20%">
                Offer Check
            </td>
            <td>
                 <asp:Label ID="lblMessage" runat="server" ForeColor="Red" ClientIDMode="Static"></asp:Label>&nbsp;
            </td>
        </tr>
    </table>

    <table>

         <tr>
            <td>
                Mobile No.:
            </td>
            <td>
                <asp:TextBox ID="txtMobileNo"  runat="server"></asp:TextBox>
            </td>
             <td><asp:Button ID="btnValidate" Width="100px" runat="server" Text="Validate" OnClick="btnValidate_Click" /></td>
         </tr>

        <tr>
            <td>
             Offer Code:
            </td>
            <td>
                <asp:TextBox ID="txtOfferCode"  ReadOnly="true" runat="server"></asp:TextBox>
            </td>
        </tr>
         
        <tr>
            <td>
                &nbsp;
            </td>
            <td>
                <asp:Button ID="btnUseCode" Width="100px"  runat="server" Text="Use Code" Visible="false" OnClick="btnUseCode_Click" />
            </td>
        </tr>
                
        </table>
</asp:Content>
