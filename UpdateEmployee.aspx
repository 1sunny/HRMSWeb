<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="UpdateEmployee.aspx.cs" Inherits="HRMSWeb.UpdateEmployee" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="phdBodyContent" runat="server">
    <ajaxToolkit:ToolkitScriptManager  ID="ScriptManager1" runat="server"></ajaxToolkit:ToolkitScriptManager> 
     <table style="width: 100%;" border="0">
        <tr>
            <td class="text-admin-panel" width="20%">
                Employee Info
            </td>
            <td>
                 <asp:Label ID="lblMessage" runat="server" ForeColor="Red" ClientIDMode="Static"></asp:Label>&nbsp;
            </td>
        </tr>
    </table>

    <table>

        <tr>
            <td>
             Emp Id:
            </td>
            <td>
                  <ajaxToolkit:ComboBox ID="cmbEmpId" ClientIDMode="Static" runat="server" 
                    AutoPostBack="true" 
                    DropDownStyle="DropDown" 
                    AutoCompleteMode="SuggestAppend" 
                    CaseSensitive="False" 
                    CssClass="" 
                    ItemInsertLocation="Append" OnSelectedIndexChanged="cmbEmpId_SelectedIndexChanged" 
                       >
                  </ajaxToolkit:ComboBox> 
                
            </td>
        </tr>

         <tr>
            <td>
                Name:
            </td>
            <td>
                <asp:TextBox ID="txtName" ReadOnly="true" runat="server"></asp:TextBox>
            </td>
         </tr>

         <tr>
            <td>
            Location:
            </td>
            <td>
                   <asp:DropDownList ID="ddlLocation" runat="server" AutoPostBack="true">
                    </asp:DropDownList>
            </td>
        </tr>
         
         <tr>
            <td>
                Status:
            </td>
            <td>
                <asp:CheckBox ID="ChkStatus" runat="server" />
            </td>
         </tr>
        <tr>
            <td>
                &nbsp;
            </td>
            <td>
                <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
            </td>
        </tr>
         
       
        </table>
</asp:Content>
