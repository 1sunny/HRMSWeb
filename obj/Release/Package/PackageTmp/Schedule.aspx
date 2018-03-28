<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="Schedule.aspx.cs" Inherits="HRMSWeb.Schedule" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="phdBodyContent" runat="server">
    <ajaxToolkit:ToolkitScriptManager  ID="ScriptManager1" runat="server"></ajaxToolkit:ToolkitScriptManager> 
    <table>
        <tr>
            <td colspan="5">
                <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label></td>
        </tr>
        <tr>
            <td>From Date</td>
            <td><asp:TextBox ID="txtFromDate"  Enabled="false"  runat="server" ></asp:TextBox></td>

              <td>To Date</td>
            <td><asp:TextBox ID="txtToDate" Enabled="false" runat="server" ></asp:TextBox></td>

            <td>
                <asp:Button ID="btnSchdule" runat="server" Text="Schedule"  Width="100px" OnClick="btnSchdule_Click"/></td>
        </tr>

        <tr>

            <td colspan="5">
                 <asp:GridView ID="gdvSchedule" runat="server" AutoGenerateColumns="False"   
            BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px"   
            CellPadding="0" DataKeyNames="EmpId" GridLines="Vertical"   
            onrowdatabound="gdvSchedule_RowDataBound" >  
            <AlternatingRowStyle BackColor="#DCDCDC" />  
            <Columns>  
                <asp:TemplateField HeaderText="ID">  
                    <EditItemTemplate>  
                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("EmpId") %>'></asp:TextBox>  
                    </EditItemTemplate>  
                    <ItemTemplate>  
                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("EmpId") %>'></asp:Label>  
                    </ItemTemplate>  
                </asp:TemplateField>  
                <asp:TemplateField HeaderText="Name">  
                    <EditItemTemplate>  
                        <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("Name") %>'></asp:TextBox>  
                    </EditItemTemplate>  
                    <ItemTemplate>  
                        <asp:Label ID="Label2" runat="server" Text='<%# Bind("Name") %>'></asp:Label>  
                    </ItemTemplate>  
                </asp:TemplateField>  
                
                <asp:TemplateField HeaderText="Sunday">  
                    <EditItemTemplate>  
                        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>  
                    </EditItemTemplate>  
                    <ItemTemplate>  
                        <asp:DropDownList ID="ddlShiftId1" runat="server">  
                        </asp:DropDownList>  
                    </ItemTemplate>  
                </asp:TemplateField> 
                
                <asp:TemplateField HeaderText="Monday">  
                    <EditItemTemplate>  
                        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>  
                    </EditItemTemplate>  
                    <ItemTemplate>  
                        <asp:DropDownList ID="ddlShiftId2" runat="server">  
                        </asp:DropDownList>  
                    </ItemTemplate>  
                </asp:TemplateField> 
                
                 <asp:TemplateField HeaderText="Tuesday">  
                    <EditItemTemplate>  
                        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>  
                    </EditItemTemplate>  
                    <ItemTemplate>  
                        <asp:DropDownList ID="ddlShiftId3" runat="server">  
                        </asp:DropDownList>  
                    </ItemTemplate>  
                </asp:TemplateField>   

                  <asp:TemplateField HeaderText="Wednesday">  
                    <EditItemTemplate>  
                        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>  
                    </EditItemTemplate>  
                    <ItemTemplate>  
                        <asp:DropDownList ID="ddlShiftId4" runat="server">  
                        </asp:DropDownList>  
                    </ItemTemplate>  
                </asp:TemplateField> 
                
                 <asp:TemplateField HeaderText="Thursday">  
                    <EditItemTemplate>  
                        <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>  
                    </EditItemTemplate>  
                    <ItemTemplate>  
                        <asp:DropDownList ID="ddlShiftId5" runat="server">  
                        </asp:DropDownList>  
                    </ItemTemplate>  
                </asp:TemplateField> 

                 <asp:TemplateField HeaderText="Friday">  
                    <EditItemTemplate>  
                        <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>  
                    </EditItemTemplate>  
                    <ItemTemplate>  
                        <asp:DropDownList ID="ddlShiftId6" runat="server">  
                        </asp:DropDownList>  
                    </ItemTemplate>  
                </asp:TemplateField> 

                 <asp:TemplateField HeaderText="Saturday">  
                    <EditItemTemplate>  
                        <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>  
                    </EditItemTemplate>  
                    <ItemTemplate>  
                        <asp:DropDownList ID="ddlShiftId7" runat="server">  
                        </asp:DropDownList>  
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
        <tr><td colspan="4"></td>
            <td>
                <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click"  Visible="false"/></td>
        </tr>

    </table>
       
</asp:Content>
