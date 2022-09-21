﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Vezbe.aspx.cs" Inherits="TeretanawWeb.Korisnici" %>

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
    <title>Pregled vežbi</title>
    <style type="text/css">
        .auto-style1 {
            height: 34px;
        }
    </style>
</head>
<body>
 
    <form id="form1" runat="server">
           <asp:ScriptManager ID="ScriptManager1" runat="server">
</asp:ScriptManager>
    <div class="wrapper">
        <div class="text-light w-75">
            <h1 class="text-center text-bold my-3">Informacije o vežbama</h1>

                <table class="table text-light text-center">
                    <thead>
                      <tr>
                        <th scope="col" class="auto-style1">Naziv</th>
                        <th scope="col" class="auto-style1">Broj ponavljanja</th>
                        <th scope="col" class="auto-style1">Broj serija</th>
                        <th scope="col" class="auto-style1">Regija tela</th>
                      </tr>
                    </thead>
                    <tbody id="tablecontent" runat="server">
                    
                    </tbody>
                  </table>
            <button type="submit" class="btn btn-outline-light ml-auto d-block py-2 px-4 my-5" style="font-size: 1.5rem;" id="btn2" runat="server" onserverclick="btn2_ServerClick">Nazad</button>

        </div>
    </div>
        </form>
</body>
</html>