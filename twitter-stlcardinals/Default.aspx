<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Twitter Ticker</title>
    <meta name="author" content="Samantha Smith" />
    <link href="Content/reset.css" rel="stylesheet" type="text/css" />
    <link href="Content/Style.css" rel="stylesheet" type="text/css" />
    <script src="//ajax.googleapis.com/ajax/libs/jquery/1.10.2/jquery.min.js"></script>
    <script type="text/javascript" src="Scripts/js/jquery_effect.js"></script> 
</head>
<body>
    <form id="form1" runat="server">
        <div id="wrapper">
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <asp:Timer ID="Timer1" runat="server" OnTick="Timer1_Tick"></asp:Timer>
 
            <h1>Twitter Ticker</h1>
            <div id="widgetWrapper" class="lightGradient roundedBox boxShadow">
                <div id="widgetHeader" class="darkGradient">
                    <h3 class="textshadow">STL Cardinals Tweets</h3>
                </div> <!-- // widgetHeader -->

                <div id="widgetContainer" class="">
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                        <Triggers><asp:AsyncPostBackTrigger ControlID="Timer1" EventName="Tick" /></Triggers>
                        <ContentTemplate>
                            <asp:DataList runat="server" OnItemCommand="DataList1_ItemCommand" OnItemDataBound="DataList1_ItemDataBound" CssClass="DataListStyle" ID="DataList1">              
                                 <ItemTemplate>
                                    <div class="twitterItemThumbnail"><asp:Image ID="Image1" CssClass="roundedBox" runat="server" ImageUrl='<%# Eval("Photo") %>' /> </div>
                                    <div class="twitterItemText">
                                        <span class="twitterScreenName"><%# DataBinder.Eval(Container.DataItem,"ScreenName") %></span><br />           
                                        <%# DataBinder.Eval(Container.DataItem, "Text") %>
                                     </div> 
                                 </ItemTemplate>                    
                                <SeparatorTemplate></SeparatorTemplate>
                                <FooterTemplate>
                                    <div class="navButton floatLeft"><asp:LinkButton ID="btnPrev" runat="server" CommandName="PrevPage" CssClass="" ToolTip="Previous Page"></asp:LinkButton></div>
                                    <div class="navText"><asp:Label ID="lblPage" runat="server" Text="Page " CssClass="twitterFooterPage"></asp:Label></div>
                                    <div class="navButton floatRight"><asp:LinkButton ID="btnNext" runat="server" CommandName="NextPage" CssClass="" ToolTip="Next Page"></asp:LinkButton></div>
                                </FooterTemplate>

                                <ItemStyle CssClass="DataListItemStyle clearGroup" />
                                <SeparatorStyle CssClass="DataListSeparatorStyle" />
                                <FooterStyle CssClass="DataListFooterStyle clearGroup" />

                            </asp:DataList>
                    
                            
                        </ContentTemplate>
                    </asp:UpdatePanel>

                    </div><!-- // widgetContainer -->
            </div> <!--  // widgetWrapper -->
            <div class="twitterFeedStatus"><asp:Label ID="lbFeedlStatus" runat="server"></asp:Label></div>
            <div class="footer">
                &copy;2013 ssmith1975.com - All rights reserved.
            </div>
        </div> <!-- // wrapper -->
    </form>
</body>
</html>
