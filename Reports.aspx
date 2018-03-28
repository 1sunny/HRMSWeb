<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="Reports.aspx.cs" Inherits="HRMSWeb.Reports" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="phdBodyContent" runat="server">
      <ajaxToolkit:ToolkitScriptManager  ID="ToolkitScriptManager1" runat="server"></ajaxToolkit:ToolkitScriptManager> 
      <table style="width: 100%;" border="0">
        <tr>
            <td class="text-admin-panel" width="20%">
               Reports
            </td>
            <td>
                 <asp:Label ID="lblMessage" runat="server" ForeColor="Red" ClientIDMode="Static"></asp:Label>&nbsp;
            </td>
        </tr>
    </table>

     <table>

        <tr>
           
            <td>
               Report Date:
            </td>
            <td>
                 <asp:TextBox ID="txtDate" runat="server"></asp:TextBox>
                  <ajaxToolkit:CalendarExtender ID="CalendarExtender2" runat="server" Enabled="True" TargetControlID="txtDate" Format="dd/MM/yyyy" >
                 </ajaxToolkit:CalendarExtender>
               
            </td>

            </tr>

            <tr>     
                <td>
                    Type:
                </td>
                
                <td>
                    <asp:RadioButtonList ID="rblType" runat="server" RepeatDirection="Horizontal">
                        <asp:ListItem Value="1" Selected="True">Daily</asp:ListItem>
                        <asp:ListItem Value="2">Weekly</asp:ListItem>
                        <asp:ListItem Value="3">Monthly</asp:ListItem>
                    </asp:RadioButtonList>
                </td>

            </tr>
                 
                
         <tr>
             <td>
            </td>
           
            <td>
               <asp:Button ID="btnReport" style="width: 70px;" runat="server" Text="Report" OnClick="btnReport_Click" />

               &nbsp;&nbsp;&nbsp; <asp:Button ID="btnDownload" Visible="false" style="width: 100px;" runat="server" Text="Download" OnClick="btnDownload_Click" />
            </td>
        </tr>
        
                 
     </table>
</asp:Content>
