<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128535245/11.2.12%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4122)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Default.aspx](./CS/WebSite/Default.aspx) (VB: [Default.aspx](./VB/WebSite/Default.aspx))
* [Default.aspx.cs](./CS/WebSite/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/WebSite/Default.aspx.vb))
<!-- default file list end -->
# ASPxGridView - How to return the number of visible data rows excluding group rows
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e4122/)**
<!-- run online end -->


<p>To change the number of visible data rows excluding group rows, do the following:</p><p>- Define the TotalSummary item:</p>

```aspx
<TotalSummary>
    <dx:ASPxSummaryItem FieldName="City" SummaryType="Count" ShowInColumn="City" DisplayFormat="{0} Item(s)" />
</TotalSummary>

```

<p> </p><p>- Handle the grid's BeforeGetCallbackResult, PreRender, and DataBound events;</p><p>- Call the <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebASPxGridViewASPxGridView_GetTotalSummaryValuetopic"><u>ASPxGridView.GetTotalSummaryValue</u></a> to obtain the number of rows;</p><p>- Set this value as SettingsPager.Summary.Text.</p>

<br/>


