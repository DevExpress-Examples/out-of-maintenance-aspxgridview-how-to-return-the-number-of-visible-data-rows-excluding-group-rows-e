using System;
using System.Collections.Generic;

public partial class _Default : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {
        grid.DataSource = GetDataSource(50);
        grid.DataBind();
    }
    protected void DataBound(object sender, EventArgs e) {
        SetItemCount();
    }
    protected void PreRender(object sender, EventArgs e) {
        SetItemCount();
    }
    protected void BeforeGetCallbackResult(object sender, EventArgs e) {
        SetItemCount();
    }
    void SetItemCount() {
        int itemCount = (int)grid.GetTotalSummaryValue(grid.TotalSummary["City"]);
        grid.SettingsPager.Summary.Text = "Page {0} of {1} (" + itemCount.ToString() + " items)";
    }
    object GetDataSource(int count) {
        List<object> result = new List<object>();
        for(int i = 0; i < count; i++)
            result.Add(new { ID = i, City = "City_" + i });
        return result;
    }
}