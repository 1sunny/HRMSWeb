<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="Import.aspx.cs" Inherits="HRMSWeb.Import" %>
<asp:Content ID="Content1" ContentPlaceHolderID="phdBodyContent" runat="server">
     <table style="width: 100%;" border="0">
        <tr>
            <td class="text-admin-panel" width="20%">
               Import Data
            </td>
            <td>
                 <asp:Label ID="lblMessage" runat="server" ForeColor="Red" ClientIDMode="Static"></asp:Label>&nbsp;
            </td>
        </tr>
    </table>

     <table>
         <tr>
            <td>
            Import Data Type:
            </td>
            <td>
                   <asp:DropDownList ID="ddlType" runat="server">
                        <asp:ListItem Value="1" Text="Employee"></asp:ListItem>
                    </asp:DropDownList>
            </td>
        </tr>

          <tr>
            <td>
               <asp:FileUpload ID="fileuploadExcel"  runat="server" />
            </td>
            <td>
                  <asp:Button ID="btnImport" ClientIDMode="Static" style="width: 100px;" runat="server" Text="Import" OnClick="btnImport_Click" />
            </td>
        </tr>
    </table>
</asp:Content>
