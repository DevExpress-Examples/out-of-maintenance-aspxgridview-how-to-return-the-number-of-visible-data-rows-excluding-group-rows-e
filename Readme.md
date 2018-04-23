# ASPxGridView - How to return the number of visible data rows excluding group rows


<p>To change the number of visible data rows excluding group rows, do the following:</p><p>- Define the TotalSummary item:</p>

```aspx
<TotalSummary>
    <dx:ASPxSummaryItem FieldName="City" SummaryType="Count" ShowInColumn="City" DisplayFormat="{0} Item(s)" />
</TotalSummary>

```

<p> </p><p>- Handle the grid's BeforeGetCallbackResult, PreRender, and DataBound events;</p><p>- Call the <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebASPxGridViewASPxGridView_GetTotalSummaryValuetopic"><u>ASPxGridView.GetTotalSummaryValue</u></a> to obtain the number of rows;</p><p>- Set this value as SettingsPager.Summary.Text.</p>

<br/>


