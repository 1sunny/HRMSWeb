<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="EmployeeInfo.aspx.cs" Inherits="HRMSWeb.EmployeeInfo" %>

<%@ Register Assembly="EditableDropDownList" Namespace="EditableControls" TagPrefix="editable" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="phdBodyContent" runat="server">
     <ajaxToolkit:ToolkitScriptManager  ID="ScriptManager1" runat="server"></ajaxToolkit:ToolkitScriptManager> 
     <link href="css/jquery-ui.css" rel="stylesheet" type="text/css" />
    <script src="js/jquery-1.6.4.min.js" type="text/javascript"></script>
    <script src="js/jquery.ui.core.js" type="text/javascript"></script>
    <script src="js/jquery.ui.widget.js" type="text/javascript"></script>
    <script src="js/jquery.ui.button.js" type="text/javascript"></script>
    <script src="js/jquery.ui.position.js" type="text/javascript"></script>
    <script src="js/jquery.ui.autocomplete.js" type="text/javascript"></script> 
    <script src="js/jquery.ui.combobox.js" type="text/javascript"></script> 
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
                 <editable:EditableDropDownList ID="ddlEmpId" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlEmpId_SelectedIndexChanged">
                 </editable:EditableDropDownList>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1"  runat="server" ErrorMessage="This Field is Required" display="Dynamic" ControlToValidate="ddlEmpId" ForeColor="Red" Font-Size="Larger" ValidationGroup="EmpInfo">*</asp:RequiredFieldValidator>
            </td>
        </tr>

         <tr>
            <td>
             First Name:
            </td>
            <td>
                <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator18"  runat="server" ErrorMessage="This Field is Required" display="Dynamic" ControlToValidate="txtFirstName" ForeColor="Red" Font-Size="Larger" ValidationGroup="EmpInfo">*</asp:RequiredFieldValidator>
            </td>
        </tr>

         <tr>
            <td>
             Middle Name:
            </td>
            <td>
                <asp:TextBox ID="txtMiddleName" runat="server"></asp:TextBox>
            </td>
         </tr>
        
         <tr>
            <td>
             Last Name:
            </td>
            <td>
                 <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
                 <asp:RequiredFieldValidator ID="RequiredFieldValidator19"  runat="server" ErrorMessage="This Field is Required" display="Dynamic" ControlToValidate="txtLastName" ForeColor="Red" Font-Size="Larger" ValidationGroup="EmpInfo">*</asp:RequiredFieldValidator>
            </td>
         </tr>

         <tr>
            <td>
             DOB:
            </td>
            <td>
                 <asp:TextBox ID="txtDOB" runat="server"></asp:TextBox>
                  <ajaxToolkit:CalendarExtender ID="CalendarExtender2" runat="server" Enabled="True" TargetControlID="txtDOB" Format="dd/MM/yyyy" >
                 </ajaxToolkit:CalendarExtender>
                 <asp:RequiredFieldValidator ID="RequiredFieldValidator20"  runat="server" ErrorMessage="This Field is Required" display="Dynamic" ControlToValidate="txtDOB" ForeColor="Red" Font-Size="Larger" ValidationGroup="EmpInfo">*</asp:RequiredFieldValidator>
            </td>
         </tr>

         <tr>
            <td>
             Gender:
            </td>
            <td>
                  <asp:DropDownList ID="ddlGender" runat="server">
                        <asp:ListItem Value="Male" Text="Male"></asp:ListItem>
                        <asp:ListItem Value="Female" Text="Female"></asp:ListItem>
                   </asp:DropDownList>
            </td>
         </tr>
        
         <tr>
            <td>
             Present Address:
            </td>
            <td>
                 <asp:TextBox ID="txtPresentAddress"  TextMode="MultiLine" Columns="30" Width="200" runat="server"></asp:TextBox>
            </td>
         </tr>
        
         <tr>
            <td>
             Permanent Address:
            </td>
            <td>
                 <asp:TextBox ID="txtPermanentAddress"  TextMode="MultiLine" Columns="30" Width="200" runat="server"></asp:TextBox>
            </td>
         </tr>
       
         <tr>
            <td>
             Joining Date:
            </td>
            <td>
                 <asp:TextBox ID="txtJoiningDate" runat="server"></asp:TextBox>
                 <ajaxToolkit:CalendarExtender ID="CalendarExtender1" runat="server" Enabled="True" TargetControlID="txtJoiningDate" Format="dd/MM/yyyy" >
                 </ajaxToolkit:CalendarExtender>
            </td>
         </tr>
        
         <tr>
            <td>
              Marital Status:
            </td>
            <td>
                  <asp:DropDownList ID="ddlMaritalStatus" runat="server">
                        <asp:ListItem Value="Single" Text="Single"></asp:ListItem>
                        <asp:ListItem Value="Married" Text="Married"></asp:ListItem>
                        <asp:ListItem Value="Other" Text="Other"></asp:ListItem>
                    </asp:DropDownList>
            </td>
         </tr>  

         <tr>
            <td>
              Nationality:
            </td>
            <td>
                <asp:TextBox ID="txtNationality" runat="server"></asp:TextBox>
            </td>
         </tr>  
          
          <tr>
            <td>
              Phone No:
            </td>
            <td>
                <asp:TextBox ID="txtPhoneNo" runat="server"></asp:TextBox>
            </td>
         </tr>  
        
        <tr>
            <td>
              Phone No(Home Country):
            </td>
            <td>
                <asp:TextBox ID="txtPhoneHome" runat="server"></asp:TextBox>
            </td>
         </tr>  

         <tr>
            <td>
              Email:
            </td>
            <td>
                <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            </td>
         </tr>  
        

 

        <tr>
            <td>
              Work Location:
            </td>
            <td>
               <asp:DropDownList ID="ddlWorkLocation" runat="server">
                        <asp:ListItem Value="400" Text="400"></asp:ListItem>
                        <asp:ListItem Value="404" Text="404"></asp:ListItem>
               </asp:DropDownList>
            </td>
         </tr>  

        <tr>
            <td>
             Designation:
            </td>
            <td>
               <asp:DropDownList ID="ddlDesignation" runat="server">
                        <asp:ListItem Value="Manager" Text="Manager"></asp:ListItem>
                        <asp:ListItem Value="Dept.Manager" Text="Dept.Manager"></asp:ListItem>
                        <asp:ListItem Value="GSA" Text="GSA"></asp:ListItem>
               </asp:DropDownList>
            </td>
         </tr>  

         <tr>
            <td>
             PassportNo:
            </td>
            <td>
                <asp:TextBox ID="txtPassportNo" runat="server"></asp:TextBox>
            </td>
         </tr>  

         <tr>
            <td>
             Passport Valid From :
            </td>
            <td>
                 <asp:TextBox ID="txtPassportValidFrom" runat="server"></asp:TextBox>
                 <ajaxToolkit:CalendarExtender ID="CalendarExtender6" runat="server" Enabled="True" TargetControlID="txtPassportValidFrom" Format="dd/MM/yyyy" >
                 </ajaxToolkit:CalendarExtender>
            </td>
         </tr>  
         
         <tr>
            <td>
             Passport Valid Till :
            </td>
            <td>
                 <asp:TextBox ID="txtPassportValidTill" runat="server"></asp:TextBox>
                 <ajaxToolkit:CalendarExtender ID="CalendarExtender7" runat="server" Enabled="True" TargetControlID="txtPassportValidTill" Format="dd/MM/yyyy" >
                 </ajaxToolkit:CalendarExtender>
            </td>
         </tr> 

          <tr>
            <td>
             Visa No :
            </td>
            <td>
                 <asp:TextBox ID="txtVisaNo" runat="server"></asp:TextBox>
               
            </td>
         </tr> 
         
         <tr>
            <td>
             Visa Type :
            </td>
            <td>
                 <asp:TextBox ID="txtVisaType" runat="server"></asp:TextBox>
               
            </td>
         </tr> 

         <tr>
            <td>
             Visa Valid From :
            </td>
            <td>
                 <asp:TextBox ID="txtVisaValidFrom" runat="server"></asp:TextBox>
                 <ajaxToolkit:CalendarExtender ID="CalendarExtender10" runat="server" Enabled="True" TargetControlID="txtVisaValidFrom" Format="dd/MM/yyyy" >
                 </ajaxToolkit:CalendarExtender>
            </td>
         </tr>
        
         <tr>
            <td>
             Visa Valid Till :
            </td>
            <td>
                 <asp:TextBox ID="txtVisaValidTill" runat="server"></asp:TextBox>
                 <ajaxToolkit:CalendarExtender ID="CalendarExtender11" runat="server" Enabled="True" TargetControlID="txtVisaValidTill" Format="dd/MM/yyyy" >
                 </ajaxToolkit:CalendarExtender>
            </td>
         </tr> 
        
         <tr>
            <td>
                 ID No :
            </td>
            <td>
                 <asp:TextBox ID="txtIDNo" runat="server"></asp:TextBox>
               
            </td>
         </tr>  

          <tr>
            <td>
                 ID Valid From :
            </td>
            <td>
                 <asp:TextBox ID="txtIDValidFrom" runat="server"></asp:TextBox>
                 <ajaxToolkit:CalendarExtender ID="CalendarExtender13" runat="server" Enabled="True" TargetControlID="txtIDValidFrom" Format="dd/MM/yyyy" >
                 </ajaxToolkit:CalendarExtender>
            </td>
         </tr>  
         
          <tr>
            <td>
                 ID Valid Till :
            </td>
            <td>
                 <asp:TextBox ID="txtIdValidTill" runat="server"></asp:TextBox>
                 <ajaxToolkit:CalendarExtender ID="CalendarExtender14" runat="server" Enabled="True" TargetControlID="txtIdValidTill" Format="dd/MM/yyyy" >
                 </ajaxToolkit:CalendarExtender>
            </td>
         </tr>
        
         <tr>
            <td>
                Social Security No :
            </td>
            <td>
                 <asp:TextBox ID="txtSocialSecurityNo" runat="server"></asp:TextBox>
                
            </td>
         </tr>   

         <tr>
            <td>
               Bank Name :
            </td>
            <td>
                 <asp:TextBox ID="txtBankName" runat="server"></asp:TextBox>
              
            </td>
         </tr> 

          <tr>
            <td>
              Bank Branch :
            </td>
            <td>
                 <asp:TextBox ID="txtBankBranch" runat="server"></asp:TextBox>
            </td>
         </tr> 
         
         <tr>
            <td>
              Bank AccountNo :
            </td>
            <td>
                 <asp:TextBox ID="txtBankAccountNo" runat="server"></asp:TextBox>
            </td>
         </tr>

        <tr>
            <td>
              IBAN No :
            </td>
            <td>
                 <asp:TextBox ID="txtIBANNo" runat="server"></asp:TextBox>
            </td>
         </tr>

         <tr>
            <td>
              Bank Code:
            </td>
            <td>
                 <asp:TextBox ID="txtBankCode" runat="server"></asp:TextBox>
            </td>
         </tr>

          <tr>
            <td>
             Personal Code VISA :
            </td>
            <td>
                 <asp:TextBox ID="txtPersonalCodeVISA" runat="server"></asp:TextBox>
            </td>
         </tr>

          <tr>
            <td>
             Airport Name:
            </td>
            <td>
                 <asp:TextBox ID="txtAirportName" runat="server"></asp:TextBox>
            </td>
         </tr>
         
          <tr>
            <td>
             Destination City:
            </td>
            <td>
                 <asp:TextBox ID="txtDestinationCity" runat="server"></asp:TextBox>
            </td>
         </tr>

         <tr>
            <td>
             Employer Id:
            </td>
            <td>
                 <asp:TextBox ID="txtEmployerId" runat="server"></asp:TextBox>
            </td>
         </tr>
         <tr>
            <td>
             Gosi Amount:
            </td>
            <td>
                 <asp:TextBox ID="txtGosiAmount" runat="server"></asp:TextBox>
            </td>
         </tr>
        <tr>
            <td>
            Is Local:
            </td>
            <td>
                <asp:CheckBoxList ID="CblIsLocal" runat="server">
                    <asp:ListItem Text="Yes"  Selected="True"></asp:ListItem>
                    <asp:ListItem Text="No"></asp:ListItem>
                </asp:CheckBoxList>
            </td>
         </tr>
                        
        
        <tr>
            <td>
                &nbsp;
            </td>
            <td>
                 <asp:Button ID="btnAddEmp" style="width: 70px;" runat="server" Text="Add" ValidationGroup="EmpInfo" OnClick="btnAddEmp_Click" />
                 &nbsp;
                 <asp:Button ID="btnUpdateEmp" style="width: 70px;" runat="server" Text="Update" ValidationGroup="EmpInfo" OnClick="btnUpdateEmp_Click" />
            </td>
        
        </tr>
      
    </table>

</asp:Content>
