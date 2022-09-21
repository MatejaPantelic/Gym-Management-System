<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="TeretanawWeb.Home" %>

<!DOCTYPE html>
<html lang="en">
<head runat="server">
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.6.1/dist/css/bootstrap.min.css" integrity="sha384-zCbKRCUGaJDkqS1kPbPd7TveP5iyJE0EjAuZQTgFLD2ylzuqKfdKlfG/eSrtxUkn" crossorigin="anonymous">
    <script src="https://cdn.jsdelivr.net/npm/jquery@3.5.1/dist/jquery.slim.min.js" integrity="sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@4.6.1/dist/js/bootstrap.bundle.min.js" integrity="sha384-fQybjgWLrvvRgtW6bFlB7jaZrFsaBXjsOMm/tB9LTS58ONXgqbR9W8oWht/amnpF" crossorigin="anonymous"></script>
    <link rel="stylesheet" href="style.css">
    <title>Teretana - Login</title>
</head>
<body>
    <form id="form1" runat="server">
           <asp:ScriptManager ID="ScriptManager1" runat="server">
</asp:ScriptManager>
    <div class="wrapper">
        <div class="text-light w-100">
            <h1 class="text-center text-bold">Dobrodošli u vaš AMTD GYM Centar</h1>
            <button type="submit" id="btn1" class="btn btn-outline-light mx-auto d-block py-2 px-4 my-5  buttons" runat="server" onserverclick="Unnamed_ServerClick">Treneri</button>
            <button type="submit" class="btn btn-outline-light mx-auto d-block py-2 px-4 my-5 buttons" runat="server" onserverclick="Unnamed_ServerClick1">Vežbe</button>

        </div>
    </div>
        </form>
</body>
</html>