<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="ComponentProgrammingAssignment.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" type="text/css" href="StyleSheet.css" />
    <title>SSBU Card Game!</title>
</head>
<body>
    <form id="form1" runat="server">

        <canvas></canvas>

        <div class="player1">
            <asp:Label ID="Player1NameLbl" runat="server" Text="Player 1"></asp:Label>
        </div>

        <div class="containerLeft">
        <div class="container">
            <asp:Image ID="Image1" runat="server" class="image"/> 
            <div class="overlay">
                <asp:Label ID="Label1" runat="server" Text="Label" class="text"></asp:Label>
            </div>
        </div>
        <div class="container">
            <asp:Image ID="Image2" runat="server" class="image"/> 
            <div class="overlay">
                <asp:Label ID="Label2" runat="server" Text="Label" class="text"></asp:Label>
            </div>
        </div>
        <div class="container">
            <asp:Image ID="Image3" runat="server" class="image"/> 
            <div class="overlay">
                <asp:Label ID="Label3" runat="server" Text="Label" class="text"></asp:Label>
            </div>
        </div>
        </div>

        <div class="containerLeft">
            <div class="radio-toolbar">
                <label class="container">
                    <asp:RadioButton ID="RadioButton1" runat="server" GroupName="P1HeroChoice" Text="Label" />
                </label>

                <label class="container">            
                    <asp:RadioButton ID="RadioButton2" runat="server" GroupName="P1HeroChoice" Text="Label" />
                </label>

                <label class="container">
                    <asp:RadioButton ID="RadioButton3" runat="server" GroupName="P1HeroChoice" Text="Label" />
                </label>
            </div>
        </div>
               

        <div class="flipCard">
          <div class="flipCardInner" >
            <div class="flip-card-front" >
                <asp:Image ID="Image7" ImageUrl="~/Images/smashball.png" class="enemies" runat="server" />
            </div>
            <div class="flip-card-back">
                <asp:Image ID="BossImage" class="enemies" runat="server" />
            </div>
          </div>
        </div>

        <div class="textContainer">
             <asp:Label ID="Label7" runat="server" class="eventText" Text="Label" ></asp:Label>
        </div>

        <div class="buttonContainer">
            <asp:Button ID="newPlayerHand" runat="server" Text="Hand" Height="50px" Width="50px"/>       
            <button type="button" class="button" id="animateButton"> </button>
            <button type="button" class="button" id="flipButton" runat="server"> </button>
            <asp:Button ID="newBossBtn" runat="server" Text="Boss" Height="50px" Width="50px" />
        </div>

        <script src="Script.js"></script> 

        <div class="player2">
            <asp:Label ID="Player2NameLbl" runat="server" Text="Player 2"></asp:Label>
        </div>

        <div class="containerRight">
        <div class="container">
            <asp:Image ID="Image4" runat="server" class="image"/> 
            <div class="overlay">
                <asp:Label ID="Label4" runat="server" Text="Label" class="text"></asp:Label>
            </div>
        </div>
        <div class="container">
            <asp:Image ID="Image5" runat="server" class="image"/> 
            <div class="overlay">
                <asp:Label ID="Label5" runat="server" Text="Label" class="text"></asp:Label>
            </div>
        </div>
        <div class="container">
            <asp:Image ID="Image6" runat="server" class="image"/> 
            <div class="overlay">
                <asp:Label ID="Label6" runat="server" Text="Label" class="text"></asp:Label>
            </div>
        </div>
        </div>

       <div class="containerRightRadio">
            <label class="container">
                <asp:RadioButton ID="RadioButton4" runat="server" GroupName="P2HeroChoice" Text="Label" />
            </label>

            <label class="container">            
                <asp:RadioButton ID="RadioButton5" runat="server" GroupName="P2HeroChoice" Text="Label" />
            </label>

            <label class="container">
                <asp:RadioButton ID="RadioButton6" runat="server" GroupName="P2HeroChoice" Text="Label" />
            </label>
        </div>
    </form>
</body>
</html>
