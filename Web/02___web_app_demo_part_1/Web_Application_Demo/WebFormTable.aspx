<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormTable.aspx.cs" Inherits="Web_Application_Demo.WebFormTable" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 135px;
        }
    </style>
</head>
<body>
    <form id="WebFormTable" runat="server">
       <table style ="font-family:Arial;border:2px solid black">
           <tr>
               <td colspan ="6" style ="border-bottom:2px solid black">
                   <b> Search Users by:</b>
               </td>
           </tr>
           <tr>
               <td>
                   <b> User Name </b>
               </td>
               <td>
                   <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
               </td>
               <td>
                   <b> Email </b>
               </td>
               <td>
                   <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
               </td>
               <td>
                   <b> Town </b>
               </td>
               <td>
                   <asp:TextBox ID="txtTown" runat="server"></asp:TextBox>
               </td>
           </tr>
           <tr >
               <td colspan=" 6">
                   <asp:Button ID="buttonSearch" runat="server" Text="Search" OnClick="buttonSearch_Click" />
               </td>
           </tr>
           <tr>
               <td colspan=" 600" class="auto-style1">
                   <asp:GridView ID="gvUsers" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                       <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                       <EditRowStyle BackColor="#999999" />
                       <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                       <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                       <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                       <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                       <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                       <SortedAscendingCellStyle BackColor="#E9E7E2" />
                       <SortedAscendingHeaderStyle BackColor="#506C8C" />
                       <SortedDescendingCellStyle BackColor="#FFFDF8" />
                       <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                   </asp:GridView>
               </td>
           </tr>
       </table>
    </form>
</body>
</html>
