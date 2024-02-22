<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Game.aspx.vb" Inherits="Project3AS.Game" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            color: white;
        }
    </style>
    <link rel="stylesheet" href="StyleSheet2.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
                <br />
                <asp:Label ID="titleLabel" runat="server" CssClass="titleLabel" Text="Card Game for Two!"></asp:Label>
                <br />
                <br />
            </div>
            <div class="auto-style1">
                <br />
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:ImageMap ID="player1IM" runat="server" Height="240px" Width="208px">
                </asp:ImageMap>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:ImageMap ID="player2IM" runat="server" Height="240px" Width="208px">
                </asp:ImageMap>
                <br />
                <br />
            </div>
            <asp:Label ID="Label1" runat="server" Text="Cards Remaining:"></asp:Label>
            <asp:Label ID="remainingCardsLabel" runat="server" CssClass="remainingCardsLabel" Text=" 51" Font-Size="XX-Large"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Player 1 Score:"></asp:Label>
            <asp:Label ID="player1ScoreLabel" runat="server" CssClass="player1ScoreLabel" Text="0" Font-Size="XX-Large"></asp:Label>
            <asp:Label ID="Label3" runat="server" Text="Player 2 Score:"></asp:Label>
            <asp:Label ID="player2ScoreLabel" runat="server" CssClass="player2ScoreLabel" Text="0" Font-Size="XX-Large"></asp:Label>
            <br />
            <br />
            <asp:Label ID="testLabel" runat="server" Text="Label"></asp:Label>
            <asp:Button ID="drawButton" runat="server" Font-Names="Ebrima" Height="58px" Text="Draw" Width="199px" Font-Size="XX-Large" />
            <br />
            <asp:Label ID="tLabel" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Button ID="newButton" runat="server" Height="55px" Text="New Game" Width="102px" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="shuffleButton" runat="server" Font-Names="Ebrima" Height="55px" Text="Shuffle" Width="92px" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="homeButton" runat="server" Height="55px" Text="Home" Width="80px" />
            <br />
            <br />
            <asp:Label ID="feedbackLabel" runat="server" Font-Size="X-Large"></asp:Label>
        </div>
    </form>
</body>
</html>
