<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register Assembly="DevExpress.Web.v13.1, Version=13.1.14.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxGridView"
    TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v13.1, Version=13.1.14.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxEditors"
    TagPrefix="dx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>How to return the number of visible data rows, excluding group rows</title>
</head>
<body>
    <form id="form1" runat="server">
    <dx:ASPxGridView ID="grid" runat="server" KeyFieldName="ID" OnBeforeGetCallbackResult="BeforeGetCallbackResult" OnPreRender="PreRender" OnDataBound="DataBound">
        <Columns>
            <dx:GridViewDataColumn FieldName="ID" />
            <dx:GridViewDataColumn FieldName="City" />
        </Columns>
        <Settings ShowGroupPanel="true" ShowFilterRow="true" />
        <SettingsPager PageSize="10" AlwaysShowPager="true" />
        <TotalSummary>
            <dx:ASPxSummaryItem FieldName="City" SummaryType="Count" ShowInColumn="City" DisplayFormat="{0} Item(s)" />
        </TotalSummary>
    </dx:ASPxGridView>
    <br />
    <dx:ASPxButton runat="server" Text="send PostBack" />
    </form>
</body>
</html>
