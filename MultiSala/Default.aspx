<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MultiSala.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="Style.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="Prenotazione">            
            <h1>Cinema Multisala</h1>
                Nome: <br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br /> 
            <br />
            Cognome:<br /><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br /> 
            <br />
            Sala:
            <asp:DropDownList ID="DropDownList1" runat="server" Width="200px">
                <asp:ListItem Value="1" Text="SALA NORD" />
                <asp:ListItem Value="2" Text="SALA EST" />
                <asp:ListItem Value="3" Text="SALA SUD" />
            </asp:DropDownList>
            <asp:CheckBox ID="CheckBox1" runat="server" Text="Biglietto ridotto" />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Prenota" OnClick="Button1_Click" />
                </div>
            <div class="StatisticheVendite">
                <p><strong>Informazioni Supplementari:</strong></p>
                
                <div class="salaA">
                    <p>
                       Biglietti venduti SALA NORD: <asp:Label ID="LabelBigliettiVendutiA" runat="server" Text=""></asp:Label>, 
                       di cui ridotti: <asp:Label ID="LabelBigliettiRidottiVendutiA" runat="server" Text=""></asp:Label>
                    </p>
                </div>

                <div class="salaB">
                    <p>
                       Biglietti venduti SALA EST: <asp:Label ID="LabelBigliettiVendutiB" runat="server" Text=""></asp:Label>,
                       di cui ridotti: <asp:Label ID="LabelBigliettiRidottiVendutiB" runat="server" Text=""></asp:Label>
                    </p>
                </div>

                <div class="salaC">
                    <p>
                       Biglietti venduti SALA SUD: <asp:Label ID="LabelBigliettiVendutiC" runat="server" Text=""></asp:Label>,
                         di cui ridotti: <asp:Label ID="LabelBigliettiRidottiVendutiC" runat="server" Text=""></asp:Label>
                    </p>
                </div>

            </div>
        </div>
    </form>
</body>
</html>
