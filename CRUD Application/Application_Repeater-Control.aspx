<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Application_RepeaterLontrol.aspx.cs" Inherits="CRUD_Application.Application_Repeater_Control" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        th, td {
            border: 1px solid black;
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView2" runat="server">
            </asp:GridView>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <table style="border: 2px solid black; margin-block: 2px; border-collapse: collapse; width: 20%">
                        <tr>
                            <th>ID</th>
                            <td>
                                <asp:Label runat="server" ID="idLabel" Text='<%#Eval("ID") %>' />
                            </td>
                        </tr>
                        <tr>
                            <th>Name</th>
                            <td>
                                <asp:Label runat="server" ID="nameLabel" Text='<%#Eval("Name") %>' />
                            </td>
                        </tr>
                        <tr>
                            <th>Gender</th>
                            <td>
                                <asp:Label runat="server" ID="genderLabel" Text='<%#Eval("Gender") %>' />
                            </td>
                        </tr>
                        <tr>
                            <th>City</th>
                            <td>
                                <asp:Label runat="server" ID="cityLabel" Text='<%#Eval("City") %>' />
                            </td>
                        </tr>
                    </table>
                </ItemTemplate>
                <SeparatorTemplate>
                    <hr />
                </SeparatorTemplate>
            </asp:Repeater>
        </div>
    </form>
</body>
</html>
