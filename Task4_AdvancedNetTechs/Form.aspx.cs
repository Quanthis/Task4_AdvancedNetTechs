using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static System.Convert;

public partial class Form : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string sqlConnection = TextBox1.Text;
        var makeSQLQuery = new SQLHandler(sqlConnection);

        var farm = new Farm(makeSQLQuery.GetLastActionDate(), makeSQLQuery.GetMoney(), makeSQLQuery.GetActualProduction());

        SewInfo.Text = farm.Sow(ToInt32(HowMuchToSew));        
    }

    protected void Collect_Click(object sender, EventArgs e)
    {
        string sqlConnection = TextBox1.Text;
        var makeSQLQuery = new SQLHandler(sqlConnection);

        var farm = new Farm(makeSQLQuery.GetLastActionDate(), makeSQLQuery.GetMoney(), makeSQLQuery.GetActualProduction());

        CollectedInfo.Text += farm.Collect().ToString();
    }

    protected void Check_Click(object sender, EventArgs e)
    {
        string sqlConnection = TextBox1.Text;
        var makeSQLQuery = new SQLHandler(sqlConnection);

        var farm = new Farm(makeSQLQuery.GetLastActionDate(), makeSQLQuery.GetMoney(), makeSQLQuery.GetActualProduction());

        CollectedInfo.Text += farm.GetActualProduction() + " " + farm.GetLastActionDate() + " " + farm.GetMoney();
    }
}