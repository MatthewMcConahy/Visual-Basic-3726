<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="Main" StyleSheetTheme="" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 23px;
        }
        .auto-style3 {
            height: 23px;
            text-align: center;
        }
        .auto-style4 {
            height: 23px;
            width: 98px;
        }
        .auto-style5 {
            width: 98px;
        }
        .auto-style8 {
            height: 23px;
            width: 191px;
        }
        .auto-style9 {
            width: 191px;
        }
        .auto-style10 {
            height: 23px;
            width: 195px;
        }
        .auto-style11 {
            width: 195px;
        }
    </style>
</head>
<body style="Blue">
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style4"></td>
                    <td class="auto-style10"></td>
                    <td class="auto-style3" colspan="3">
                        <asp:Label ID="Label1" runat="server" Text="Calorie Counter"></asp:Label>
                    </td>
                    <td class="auto-style2"></td>
                    <td class="auto-style2"></td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <asp:Label ID="Label3" runat="server" Text="Fat"></asp:Label>
                    </td>
                    <td class="auto-style10">
                        <asp:TextBox ID="FatTextBox" runat="server"></asp:TextBox>
&nbsp;</td>
                    <td class="auto-style8">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="FatTextBox" ErrorMessage="Only Numbers between 1-100" Display="Dynamic">*</asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="FatTextBox" ErrorMessage="Numbers must be 1-100" MaximumValue="100" MinimumValue="1" Type="Integer"></asp:RangeValidator>
                    </td>
                    <td class="auto-style2"></td>
                    <td class="auto-style2"></td>
                    <td class="auto-style2"></td>
                    <td class="auto-style2"></td>
                </tr>
                <tr>
                    <td class="auto-style5">
                        <asp:Label ID="Label4" runat="server" Text="Carbs"></asp:Label>
                    </td>
                    <td class="auto-style11">
                        <asp:TextBox ID="CarbsTextBox" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style9">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="CarbsTextBox" ErrorMessage="1-100" Display="Dynamic">*</asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="RangeValidator2" runat="server" ControlToValidate="CarbsTextBox" ErrorMessage="Numbers must be 1-100" MaximumValue="100" MinimumValue="1" Type="Integer"></asp:RangeValidator>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">
                        <asp:Label ID="Label5" runat="server" Text="Protien"></asp:Label>
                    </td>
                    <td class="auto-style11">
                        <asp:TextBox ID="ProtienTextBox" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style9">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="ProtienTextBox" ErrorMessage="1-100" Display="Dynamic">*</asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="RangeValidator3" runat="server" ControlToValidate="ProtienTextBox" ErrorMessage="Numbers must be 1-100" MaximumValue="100" MinimumValue="1" Type="Integer"></asp:RangeValidator>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style11">&nbsp;</td>
                    <td class="auto-style9">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">
                        <asp:Button ID="CalculateButton" runat="server" Text="Calculate" />
                    </td>
                    <td class="auto-style11">
                        <asp:Button ID="ClearButton" runat="server" Text="Clear" />
                    </td>
                    <td class="auto-style9">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style11">
                        <asp:Label ID="Label6" runat="server" Text="Calories For Current Item:"></asp:Label>
                    </td>
                    <td class="auto-style9">
                        <asp:Label ID="TotalCurrentCaloriesLabel" runat="server" Visible="False"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style11">&nbsp;</td>
                    <td class="auto-style9">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>
                        <asp:HiddenField ID="TotalCaloriesHiddenField" runat="server" Value="0" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style11">
                        <asp:Label ID="Label7" runat="server" Text="Total # of Items:"></asp:Label>
                    </td>
                    <td class="auto-style9">
                        <asp:Label ID="TotalItemsAmountLabel" runat="server" Visible="False"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>
                        <asp:HiddenField ID="TotalItemsHiddenField" runat="server" Value="0" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style11">
                        <asp:Label ID="Label8" runat="server" Text="Total # of Calories:"></asp:Label>
                    </td>
                    <td class="auto-style9">
                        <asp:Label ID="TotalCaloriesOverallLabel" runat="server" Visible="False"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>
                        <asp:HiddenField ID="OutputCaloriesHiddenField" runat="server" Value="0" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
