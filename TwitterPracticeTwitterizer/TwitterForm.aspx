<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TwitterForm.aspx.cs" Inherits="TwitterPracticeTwitterizer.TwitterForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="tbTweet" runat="server" Height="69px" MaxLength="140" Width="445px"></asp:TextBox>
        <asp:Button ID="btnTweet" runat="server" OnClick="btnTweet_Click" Text="Tweet" Width="90px" />
        <asp:Button ID="btnQuit" runat="server" OnClick="btnQuit_Click" Text="Quit" />
    
    </div>
    </form>
</body>
</html>
