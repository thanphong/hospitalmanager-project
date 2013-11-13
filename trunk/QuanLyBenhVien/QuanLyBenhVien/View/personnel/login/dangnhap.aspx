<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="dangnhap.aspx.cs" Inherits="QuanLyBenhVien.View.personnel.login.dangnhap" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            height: 19px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table cellpadding="0" cellspacing="0" class="style1">
            <tr>
                <td align="center" bgcolor="#66CCFF" colspan="2" height="40">
                    <asp:Label ID="Label1" runat="server" Font-Bold="True" ForeColor="#CC0000"
                        Text="Đăng Nhập"></asp:Label>
                </td>
            </tr>
            <tr>
                <td width="100" >
                    </td>
                <td class="style1">
                    </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="UserName:"></asp:Label>
                </td>
                <td height="30">
                    <asp:TextBox ID="txtU" runat="server" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    <asp:Label ID="Label3" runat="server" Text="PassWord"></asp:Label>
                </td>
                <td height="30">
                    <asp:TextBox ID="txtP" runat="server" Width="200px" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <br />
                    <br />
                </td>
                <td height="40">
                    <asp:Button ID="btInsert" runat="server" onclick="btInsert_Click"
                        Text="Insert" />&nbsp;&nbsp;&nbsp;
                    <%--< asp:button id="btlogin" runat="server" onclick="btlogin_click" text="login" />--%>
                </td>
            </tr>
        </table>
        &nbsp;<asp:GridView 
            ID="gvtkhoan" runat="server" AutoGenerateColumns="False" Width="403px" 
            onrowcancelingedit="gvtkhoan_CancelingEdit" onrowdeleting="gvtkhoan_Deleting" 
            onrowediting="gvtkhoan_Editing" onrowupdating="gvtkhoan_Updateing">
            <Columns>
                <asp:TemplateField HeaderText="Mã User">
                    <ItemTemplate>
                        <asp:Label ID="lbId" runat="server" Text='<%# Eval("id") %>'></asp:Label>
                    </ItemTemplate>
                   
                    <FooterTemplate>
                        <asp:TextBox ID="txtId" runat="server" Height="22px"></asp:TextBox>
                    </FooterTemplate>
                   
                </asp:TemplateField>
                <asp:BoundField DataField="username" HeaderText="tên đăng nhập" />
                <asp:BoundField DataField="pass" HeaderText="Mật khẩu" />
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                <asp:TemplateField HeaderText="Tên đăng nhập">
                    <ItemTemplate>
                        <asp:Label ID="lbUS" runat="server" Text='<%# Eval("username") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtUS" runat="server" Text='<%# Eval("username") %>'></asp:TextBox>
                    </EditItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Mật khẩu">
                    <ItemTemplate>
                        <asp:Label ID="lbPass" runat="server" Text='<%# Eval("pass") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtPass" runat="server" Text='<%# Eval("pass") %>'></asp:TextBox>
                    </EditItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
    </form>
</body>
</html>
