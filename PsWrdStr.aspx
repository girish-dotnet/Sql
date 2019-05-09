<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PsWrdStr.aspx.cs" Inherits="AjaxDemoEx.PsWrdStr" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <style> 
         .textIndicator_poor, 
         .textIndicator_weak,
         .textIndicator_good,
         .textIndicator_strong,
         .textIndicator_excellent 
         {padding:2px;font-weight:bold;}
         .textIndicator_poor { background-color:gray;color:#ffff00;}
         .textIndicator_weak { background-color:gray;color:#00ffff;} 
         .textIndicator_good { background-color:gray;color:lightblue;}
         .textIndicator_strong { background-color:gray;color:lightgreen;} 
         .textIndicator_excellent { background-color:gray;color:#00ffdd;}
         .textbox {border: solid 2px #cccccc;
                   border-top: solid 2px #a0a0a0;}

     </style>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
            </asp:ToolkitScriptManager>
            <br />
             <asp:Label ID="Label2" runat="server" Font-Bold="true" Font-Size="14px" Text="Enter Password: "></asp:Label><asp:TextBox CssClass="textbox" Width="200px" ID="TextBox1" runat="server"></asp:TextBox>
        <asp:PasswordStrength ID="PasswordStrength1" runat="server"
                 TargetControlID="TextBox1"    DisplayPosition="RightSide"     MinimumSymbolCharacters="1"     MinimumUpperCaseCharacters="1"    PreferredPasswordLength="10"     CalculationWeightings="25;25;15;35"     RequiresUpperAndLowerCaseCharacters="true"    TextStrengthDescriptions="Poor; Weak; Good; Strong; Excellent"     HelpStatusLabelID="Label1"    StrengthIndicatorType="Text"     HelpHandlePosition="AboveLeft"     TextStrengthDescriptionStyles="textIndicator_poor; textIndicator_weak; textIndicator_good; textIndicator_strong; textIndicator_excellent"></asp:PasswordStrength><div class="clear"><br /></div><asp:Label ID="Label1" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
