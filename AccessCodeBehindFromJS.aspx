<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>


    <form id="form1" runat="server">
            <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePageMethods="true">
</asp:ScriptManager>

    <div>
    <script>
        function cside(x)
        {
            PageMethods.yazdir(x);
        }
    </script>
    </div>

        <div id ="div2" runat="server">
            MY DIV:



        </div>
    </form>
</body>
</html>
