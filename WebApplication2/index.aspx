<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication2._Default" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>Basic Calculator</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            padding: 20px;
        }
        .container {
            max-width: 600px;
            margin: 0 auto;
            text-align: center;
        }
        input, button {
            margin: 10px;
            padding: 10px;
            font-size: 16px;
        }
        #result {
            font-size: 20px;
            font-weight: bold;
        }
    </style>
</head>
<body>
    <div class="container">
        <h1>Basic Calculator</h1>
        <form id="form1" runat="server">
            <label for="expressionInput">Enter Expression:</label>
            <input type="text" id="expressionInput" runat="server" placeholder="e.g. 3 + (2 - 5)" />
            <br />
           
            <asp:Button ID="CalculateButton" runat="server" Text="Calculate" OnClick="CalculateButton_Click" />
        </form>
        <div id="result">
            <asp:Label ID="ResultLabel" runat="server" Text="Result: " />
        </div>
    </div>
</body>
</html>
