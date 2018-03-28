<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="Attendance.aspx.cs" Inherits="HRMSWeb.Attendance" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="phdBodyContent" runat="server">
    
       <ajaxToolkit:ToolkitScriptManager  ID="ToolkitScriptManager1" runat="server"></ajaxToolkit:ToolkitScriptManager> 
      <table style="width: 100%;" border="0">
        <tr>
            <td class="text-admin-panel" width="20%">
                Attendance Info
            </td>
            <td>
                 <asp:Label ID="lblMessage" runat="server" ForeColor="Red" ClientIDMode="Static"></asp:Label>&nbsp;
            </td>
        </tr>
    </table>

     <table>

        <tr>
           
            <td>
               From Date:
            </td>
            <td>
                 <asp:TextBox ID="txtFromDate" runat="server"></asp:TextBox>
                  <ajaxToolkit:CalendarExtender ID="CalendarExtender2" runat="server" Enabled="True" TargetControlID="txtFromDate" Format="dd/MM/yyyy" >
                 </ajaxToolkit:CalendarExtender>
               
            </td>

            <td>
               To Date:
            </td>
            <td>
                 <asp:TextBox ID="txtToDate" runat="server"></asp:TextBox>
                  <ajaxToolkit:CalendarExtender ID="CalendarExtender1" runat="server" Enabled="True" TargetControlID="txtToDate" Format="dd/MM/yyyy" >
                 </ajaxToolkit:CalendarExtender>
            </td>
            <td>
               <asp:Button ID="btnReport" style="width: 70px;" runat="server" Text="Report" OnClick="btnReport_Click"   />
            </td>
        </tr>
         <tr>
             <td colspan="5">
                 

                    <asp:GridView ID="gdvAttendance" DataKeyNames="EmpId" runat="server" AutoGenerateColumns="False" 
                         BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px"   
            CellPadding="0" GridLines="Vertical"   
            onrowdatabound="gdvAttendance_RowDataBound" >  
            <AlternatingRowStyle BackColor="#DCDCDC" /> 
              


<Columns>
<asp:TemplateField HeaderText="Id" Visible="false">
    <ItemTemplate>
        <asp:Label ID="Id" runat="server" Text='<%#Eval("Id") %>'/>
    </ItemTemplate>
</asp:TemplateField>
<asp:TemplateField HeaderText="Date">
    <ItemTemplate>
        <asp:Label ID="txtDate" runat="server"  Width="70px" Text='<%#Convert.ToDateTime(Eval("Date")).ToString("dd-MMM-yy") %>'/>
    </ItemTemplate>
</asp:TemplateField>
 <asp:TemplateField HeaderText="EmpId">
      <ItemTemplate>
         <asp:Label ID="lblEmpId" runat="server" Text='<%#Eval("EmpId") %>'/>
     </ItemTemplate>
 </asp:TemplateField>
 <asp:TemplateField HeaderText="EmpName">
     <ItemTemplate>
         <asp:Label ID="lblEmpName" runat="server" Text='<%#Eval("EmpName") %>'/>
     </ItemTemplate>
   
 </asp:TemplateField>
  <asp:TemplateField HeaderText="CheckIn">
       <ItemTemplate>
         <asp:Label ID="lblCheckIn" runat="server" Text='<%#Eval("CheckIn") %>'/>
     </ItemTemplate>
 </asp:TemplateField>

  <asp:TemplateField HeaderText="CheckOut">
       <ItemTemplate>
         <asp:Label ID="lblCheckOut" runat="server" Text='<%#Eval("CheckOut") %>'/>
     </ItemTemplate>
 </asp:TemplateField>

<asp:TemplateField HeaderText="WorkedTime">
       <ItemTemplate>
         <asp:Label ID="lblWorkedTime" runat="server" Text='<%#Eval("WorkedTime") %>'/>
     </ItemTemplate>
 </asp:TemplateField>

  <%--<asp:TemplateField HeaderText="Work Time">
       <ItemTemplate>
         <asp:Label ID="lblWorkTime" runat="server" Text='<%#Eval("lblWorkTime") %>'/>
     </ItemTemplate>
 </asp:TemplateField>--%>

<asp:TemplateField HeaderText="ShiftId">
      <ItemTemplate>
         <asp:Label ID="lblShiftId" runat="server" Text='<%#Eval("ShiftId") %>'/>
     </ItemTemplate>
 </asp:TemplateField>

  <asp:TemplateField HeaderText="SchIn">
       <ItemTemplate>
         <asp:Label ID="lblSchIn" runat="server" Text='<%#Eval("SchIn") %>'/>
     </ItemTemplate>
 </asp:TemplateField>

  <asp:TemplateField HeaderText="SchOut">
       <ItemTemplate>
         <asp:Label ID="lblSchOut" runat="server" Text='<%#Eval("SchOut") %>'/>
     </ItemTemplate>
 </asp:TemplateField>


   <asp:TemplateField HeaderText="BreakOut">
     <ItemTemplate>
         <asp:Label ID="lblBreakOut" runat="server" Text='<%#Eval("BreakOut") %>'/>
     </ItemTemplate>
  </asp:TemplateField>
    
    <asp:TemplateField HeaderText="BreakIn">
     <ItemTemplate>
         <asp:Label ID="lblBreakIn" runat="server" Text='<%#Eval("BreakIn") %>'/>
     </ItemTemplate>
    
 </asp:TemplateField>

 <asp:TemplateField HeaderText="BreakTime">
 
     <ItemTemplate>
         <asp:Label ID="lblBreakTime" runat="server" Text='<%#Eval("BreakTime") %>'/>
     </ItemTemplate>
 
 </asp:TemplateField>

 <asp:TemplateField HeaderText="Under Time">
     <ItemTemplate>
         <asp:Label ID="lblUnderTime" runat="server" Text='<%#Eval("UnderTime") %>'/>
     </ItemTemplate>
   
 </asp:TemplateField>

 <asp:TemplateField HeaderText="Adj">
     <ItemTemplate>
         <asp:TextBox ID="txtUnderTimeAdj" Width="20px" Text='<%#Eval("UTAdj") %>' runat="server"></asp:TextBox>
     </ItemTemplate>
   
 </asp:TemplateField>

 <asp:TemplateField HeaderText="Owed Hours">
     <ItemTemplate>
         <asp:Label ID="lblOverTime" runat="server" Text='<%#Eval("OverTime") %>'/>
     </ItemTemplate>
 </asp:TemplateField>

<asp:TemplateField HeaderText="Adj">
     <ItemTemplate>
         <asp:TextBox ID="txtOwedHoursAdj" Width="20px" Text='<%#Eval("OHAdj") %>' runat="server"></asp:TextBox>
     </ItemTemplate>
 </asp:TemplateField>


<asp:TemplateField HeaderText="System Remarks">
     <ItemTemplate>
         <asp:Label ID="lblSystemRemarks" runat="server" Text='<%#Eval("SystemRemarks") %>'/>
     </ItemTemplate>
</asp:TemplateField>

<asp:TemplateField HeaderText="Level1Remarks">
     <ItemTemplate>
          <asp:Label ID="lblL1Remarks" runat="server" Text='<%#Eval("L1Remarks") %>'/>
       
         <asp:DropDownList ID="ddlL1Remarks" Width="90px" runat="server"  >
              
   
         </asp:DropDownList>
     </ItemTemplate>
</asp:TemplateField>

 <asp:TemplateField HeaderText="Level1Approve">
    <ItemTemplate >
          <asp:CheckBox ID="chkLevel1" Text="Level1" Checked='<%#Eval("L1Approve") %>' runat="server" />
    </ItemTemplate>
 </asp:TemplateField>

<asp:TemplateField HeaderText="Level2Remarks">
     <ItemTemplate>
         <asp:TextBox ID="txtL2Remarks" TextMode="MultiLine" Rows="2" runat="server"></asp:TextBox>
     </ItemTemplate>
</asp:TemplateField>

 <asp:TemplateField HeaderText="Level2Approve">
    <ItemTemplate>
          <asp:CheckBox ID="chkLevel2" Text="Level2"  runat="server" />
    </ItemTemplate>
 </asp:TemplateField>

 </Columns>
  <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />  
            <HeaderStyle BackColor="#555555" Font-Bold="True" ForeColor="White" />  
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />  
            <RowStyle BackColor="#EEEEEE" ForeColor="Black" />  
            <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />  
            <SortedAscendingCellStyle BackColor="#F1F1F1" />  
            <SortedAscendingHeaderStyle BackColor="#0000A9" />  
            <SortedDescendingCellStyle BackColor="#CAC9C9" />  
            <SortedDescendingHeaderStyle BackColor="#000065" />  
</asp:GridView>

             </td>
         </tr>
         <tr>
             <td colspan="4"></td>
             <td>
                 <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" /></td>
         </tr>
         
     </table>

</asp:Content>
