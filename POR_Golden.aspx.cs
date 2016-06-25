using System;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Collections.Generic;
using System.Linq;
using System.Web.Configuration;
using MySql.Data.MySqlClient;

public partial class _Default : System.Web.UI.Page
{
    public string srcCtl = "";
    public string srcForm = "";
    public List<string> por_golden_data = new List<string>();
    public string strQuerySQL = "";
    public string sql1 = "select DISTINCT POR_01 from npipor";
    public static string  Global_Sql_POR = "";
    
    
    /*
    public void ReturnOpener()
    {
        string jsStr = "";
        jsStr += "window.opener." + srcForm + "." + srcCtl + ".value = ";
        jsStr += "window.opener." + srcForm + "." + srcCtl + ".value = form1." + por_golden_data[1] + ".value; ";
        jsStr += "window.close();";
        jsStr += "self.opener." + srcForm + ".submit();";
        ClientScript.RegisterStartupScript(this.GetType(), "ret", jsStr, true);

    }
    */

    [System.Web.Services.WebMethod]
    public static string[] GetPKG(string prefix)
    {
        List<string> PKG = new List<string>();
       
        string strSQL = " select DISTINCT POR_02 from npipor where POR_02 like '" + prefix + "%'"; 


        clsMySQL db = new clsMySQL();
        foreach (DataRow dr in db.QueryDataSet(strSQL).Tables[0].Rows)
        {
            //customers.Add(string.Format("{0},{1}", dr["new_customer"], dr["new_device"]));
            PKG.Add(string.Format("{0}", dr["POR_02"]));
        }
        return PKG.ToArray();
    }

    [System.Web.Services.WebMethod]
    public static string[] GetWT(string prefix)
    {
        List<string> WT = new List<string>();

        string strSQL = " select DISTINCT POR_03 from npipor where POR_03 like '" + prefix + "%'";


        clsMySQL db = new clsMySQL();
        foreach (DataRow dr in db.QueryDataSet(strSQL).Tables[0].Rows)
        {
            //customers.Add(string.Format("{0},{1}", dr["new_customer"], dr["new_device"]));
            WT.Add(string.Format("{0}", dr["POR_03"]));
        }
        return WT.ToArray();
    }

    [System.Web.Services.WebMethod]
    public static string[] GetFAB(string prefix)
    {
        List<string> FAB = new List<string>();

        string strSQL = " select DISTINCT POR_04 from npipor where POR_04 like '" + prefix + "%'";


        clsMySQL db = new clsMySQL();
        foreach (DataRow dr in db.QueryDataSet(strSQL).Tables[0].Rows)
        {
            //customers.Add(string.Format("{0},{1}", dr["new_customer"], dr["new_device"]));
            FAB.Add(string.Format("{0}", dr["POR_04"]));
        }
        return FAB.ToArray();
    }

    [System.Web.Services.WebMethod]
    public static string[] GetPSV(string prefix)
    {
        List<string> PSV = new List<string>();

        string strSQL = " select DISTINCT POR_05 from npipor where POR_05 like '" + prefix + "%'";


        clsMySQL db = new clsMySQL();
        foreach (DataRow dr in db.QueryDataSet(strSQL).Tables[0].Rows)
        {
            //customers.Add(string.Format("{0},{1}", dr["new_customer"], dr["new_device"]));
            PSV.Add(string.Format("{0}", dr["POR_05"]));
        }
        return PSV.ToArray();
    }

    [System.Web.Services.WebMethod]
    public static string[] GetCustomer(string prefix)
    {
        List<string> Customer = new List<string>();

        string strSQL = " select DISTINCT POR_14 from npipor where POR_14 like '" + prefix + "%'";


        clsMySQL db = new clsMySQL();
        foreach (DataRow dr in db.QueryDataSet(strSQL).Tables[0].Rows)
        {
            //customers.Add(string.Format("{0},{1}", dr["new_customer"], dr["new_device"]));
            Customer.Add(string.Format("{0}", dr["POR_14"]));
        }
        return Customer.ToArray();
    }
   






    protected void Page_Load(object sender, EventArgs e)
    {
        if(!Page.IsPostBack)
        {
            put_prosite_data(sql1);


        }
    }

    
  

    protected void GridView1_RowCommand(object sender,GridViewCommandEventArgs e)
    {
        

       


        if (e.CommandName == "Compare")
        {
            int index;
            int i = 0;
            index = Convert.ToInt32(e.CommandArgument);
            //GridViewRow selecteRow = GridView1.Rows[index];
            string productName_Device = GridView1.Rows[index].Cells[1].Text;
            string productName_Production_Site = GridView1.Rows[index].Cells[2].Text;
            string productName_PKG = GridView1.Rows[index].Cells[3].Text;
            string productName_Wafer = GridView1.Rows[index].Cells[4].Text;
            string productName_fab = GridView1.Rows[index].Cells[5].Text;
            string productWaferPSV = GridView1.Rows[index].Cells[6].Text;
            string productRVSI = GridView1.Rows[index].Cells[7].Text;
            string productCustomer = GridView1.Rows[index].Cells[8].Text;

           
            string strScript = "";
            string arydata = "";

            string pass_message = "'確定將以下八個條件帶入EP_TRA中?\\nDevice:" + productName_Device + "\\nProduction_Site:" + productName_Production_Site +
                                "\\nPKG:" + productName_PKG + "\\nWafer Tech.(nm) :" + productName_Wafer + "\\nFAB:" + productName_fab
                                + "\\nWafer PSV type / Thickness:" + productWaferPSV + "\\nRVSI:" + productRVSI + "\\nCustomer:" + productCustomer + "','";
                               



            arydata = productName_Device + "|" + productName_Production_Site + "|" + productName_PKG + "|" + productName_Wafer
                +"|"+ productName_fab +"|" + productWaferPSV +"|" + productRVSI +"|" + productCustomer;
            strScript = "<script language='javascript'>Confirm("+ pass_message + arydata + "');</script>";
            //strScript = "<script language='javascript'>Confirm('確定？','" + arydata + "');</script>";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "onload", strScript);


            /*string strScript = string.Format("<script language='javascript'>error_msg('查無此資料，請再重新選擇POR Golden 條件!');</script>");
            Page.ClientScript.RegisterStartupScript(this.GetType(), "onload", strScript);*/



            //ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "msg", "alert('"+ "'Device:" + productName_Device.Text +"')", true);


            /* for (i=0;i<8;i++)
             {
                 Response.Write(por_golden_data[i]+"<br />");
             }*/
            // Response.Write("<script>window.open('POR_Golden.aspx','POR_Golden_Condition',config='height=1024,width=1100');</script>");


            /*
             Response.Redirect("~/EP_TRA.aspx?Device="+this.por_golden_data[0] +"Production_Site=" + this.por_golden_data[1] + "PKG=" + this.por_golden_data[2] +
                  "Wafer=" + this.por_golden_data[3] + "Name_fab=" + this.por_golden_data[4] + "WaferPSV=" + this.por_golden_data[5] +
                  "RVSI=" + this.por_golden_data[6] + "Customer=" + this.por_golden_data[7]);
             */



            /*Response.Redirect("~/EP_TRA.aspx?" + this.por_golden_data[1]  + this.por_golden_data[2] +
                 this.por_golden_data[3] +  this.por_golden_data[4] +  this.por_golden_data[5] +
                 this.por_golden_data[6]  + this.por_golden_data[7]);*/





        }
    }

    [System.Web.Services.WebMethod(EnableSession = true)]

    public static string CreateJob(string strConjData)
    {
        string strError = "";
        string[] strData = new string[1];
        strData = strConjData.Split('|');
        HttpContext.Current.Session["value1"] = strData[0];
        HttpContext.Current.Session["value2"] = strData[1];
        HttpContext.Current.Session["value3"] = strData[2];
        HttpContext.Current.Session["value4"] = strData[3];
        HttpContext.Current.Session["value5"] = strData[4];
        HttpContext.Current.Session["value6"] = strData[5];
        HttpContext.Current.Session["value7"] = strData[6];
        HttpContext.Current.Session["value8"] = strData[7];
        return strError;
    }


    protected void Search_Por_Sql(string porsql)
    {

        clsMySQL db = new clsMySQL(); //Connection MySQL
        clsMySQL.DBReply dr = db.QueryDS(porsql);
        GridView1.DataSource = dr.dsDataSet.Tables[0].DefaultView;
        GridView1.DataBind();
        db.Close();



    }


    protected void put_prosite_data(string mySQL)
    {
        string TableFild = "";
        int FieldCunt = 0;


        // clsMySQL db = new clsMySQL();

        //MySqlDataReader mydr = db.QueryDataReader(mySQL);
        MySqlConnection MySqlConn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySQL"].ConnectionString);
        MySqlConn.Open();

        MySqlCommand MySqlCmd = new MySqlCommand(mySQL, MySqlConn);
        MySqlDataReader mydr = MySqlCmd.ExecuteReader();

        while (mydr.Read())
        {
            for (FieldCunt = 0; FieldCunt <= 0; FieldCunt++)
            {

                TableFild = mydr.GetString(0);
                //temp_Data.Add(TableFild);
                ProSite_ddl.Items.Add(TableFild);
                //FieldCunt++;

            }

        }
        mydr.Close();
        MySqlConn.Close();
    }

    protected Boolean jude_pordata(string mySQL)
    {
        string TableFild = "";
        int FieldCunt = 0;


        // clsMySQL db = new clsMySQL();

        //MySqlDataReader mydr = db.QueryDataReader(mySQL);
        MySqlConnection MySqlConn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySQL"].ConnectionString);
        MySqlConn.Open();

        MySqlCommand MySqlCmd = new MySqlCommand(mySQL, MySqlConn);
        MySqlDataReader mydr = MySqlCmd.ExecuteReader();

        while (mydr.Read())
        {
            for (FieldCunt = 0; FieldCunt <= 0; FieldCunt++)
            {

                TableFild = mydr.GetString(0);
                //temp_Data.Add(TableFild);            
                //FieldCunt++;

            }

        }
        mydr.Close();
        MySqlConn.Close();

        if (TableFild == "")
            return false;
        else
            return true;



    }

    protected void put_POR_Data(string sql)
    {
        clsMySQL db = new clsMySQL();

        clsMySQL.DBReply dr = db.QueryDS(sql);
        GridView1.DataSource = dr.dsDataSet.Tables[0].DefaultView;
        GridView1.DataBind();
        db.Close();
   
    }




    protected void Search_por_Click(object sender, EventArgs e)
    {
      
        GridView1.Visible = true;
       



       
        Boolean bisWhereExist = false;
        
        string jude_Sql = "";
       
 
        if (TB_PKG.Text.Trim() != "" || TB_WT.Text.Trim() != "" ||
             TB_FAB.Text.Trim() != "" || TB_PSV.Text.Trim() != "" || ddl_RVSI.SelectedIndex!= 0 ||
             TB_Customer.Text.Trim() != "" || ProSite_ddl.SelectedIndex != 0)
        {
            strQuerySQL = "Select * from npipor Where Stype='POR' ";
            jude_Sql= "Select POR_Customer from npipor Where Stype='POR' ";
            bisWhereExist = true;
        }
        else
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "msg", "alert('請輸入POR Golden 條件!')", true);
        }
        if (TB_PKG.Text.Trim() != "")
        {
            if (bisWhereExist)
            {
                strQuerySQL = strQuerySQL + "and POR_02 like'" + TB_PKG.Text + "%' ";
                jude_Sql = jude_Sql + "and POR_02 like'" + TB_PKG.Text + "%' ";
            }
            else
            {
                strQuerySQL = strQuerySQL + "Where POR_01 like'" + TB_PKG.Text + "%' ";
                jude_Sql = jude_Sql + "Where POR_01 like'" + TB_PKG.Text + "%' ";
            }         
        }
       
        if (TB_WT.Text.Trim() != "")
        {
            if (bisWhereExist)
            {
                strQuerySQL = strQuerySQL + "and POR_03 like'" + TB_WT.Text + "%' ";
                jude_Sql = jude_Sql + "and POR_03 like'" + TB_WT.Text + "%' ";
            }
            else
            {
                strQuerySQL = strQuerySQL + "Where POR_03 like'" + TB_WT.Text + "%' ";
                jude_Sql = jude_Sql + "Where POR_03 like'" + TB_WT.Text + "%' ";
            }
        }
        if (TB_FAB.Text.Trim() != "")
        {
            if (bisWhereExist)
            {
                strQuerySQL = strQuerySQL + "and POR_04 like'" + TB_FAB.Text + "%' ";
                jude_Sql = jude_Sql + "and POR_04 like'" + TB_FAB.Text + "%' ";
            }
            else
            {
                strQuerySQL = strQuerySQL + "Where POR_04 like'" + TB_FAB.Text + "%' ";
                jude_Sql = jude_Sql + "Where POR_04 like'" + TB_FAB.Text + "%' ";
            }
        }
        if (TB_PSV.Text.Trim() != "")
        {
            if (bisWhereExist)
            {
                strQuerySQL = strQuerySQL + "and POR_05 like'" + TB_PSV.Text + "%' ";
                jude_Sql = jude_Sql + "and POR_05 like'" + TB_PSV.Text + "%' ";
            }
            else
            {
                strQuerySQL = strQuerySQL + "Where POR_04 like'" + TB_PSV.Text + "%' ";
                jude_Sql = jude_Sql + "Where POR_04 like'" + TB_PSV.Text + "%' ";
            }
        }
        if (ddl_RVSI.SelectedIndex != 0)
        {
            if (bisWhereExist)
            {
                strQuerySQL = strQuerySQL + "and POR_11 like'" + ddl_RVSI.SelectedValue + "%' ";
                jude_Sql = jude_Sql + "and POR_11 like'" + ddl_RVSI.SelectedValue + "%' ";
            }
            else
            {
                strQuerySQL = strQuerySQL + "Where POR_11 like'" + ddl_RVSI.SelectedValue + "%'";
                jude_Sql = jude_Sql + "Where POR_11 like'" + ddl_RVSI.SelectedValue + "%'";
            }
        }
        if (TB_Customer.Text.Trim() != "")
        {
            if (bisWhereExist)
            {
                strQuerySQL = strQuerySQL + "and POR_14 like'" + TB_Customer.Text + "%' ";
                jude_Sql = strQuerySQL + "and POR_14 like'" + TB_Customer.Text + "%' ";
            }
            else
            {
                strQuerySQL = strQuerySQL + "Where POR_14 like'" + TB_Customer.Text + "%' ";
                jude_Sql = jude_Sql + "Where POR_14 like'" + TB_Customer.Text + "%' ";
            }
        }
        if (ProSite_ddl.SelectedIndex != 0)
        {
            if (bisWhereExist)
            {
                strQuerySQL = strQuerySQL + "and POR_01 like'" + ProSite_ddl.SelectedValue + "%' ";
                jude_Sql = strQuerySQL + "and POR_01 like'" + ProSite_ddl.SelectedValue + "%' ";
            }
            else
            {
                strQuerySQL = strQuerySQL + "Where POR_01 like'" + ProSite_ddl.SelectedValue + "%' ";
                jude_Sql = jude_Sql + "Where POR_01 like'" + ProSite_ddl.SelectedValue + "%' ";
            }
        }
        //lblError.Text = strQuerySQL;
        try
        {
            

            if (jude_pordata(jude_Sql))
            {
                put_POR_Data(strQuerySQL);
                Global_Sql_POR = strQuerySQL;
                HttpContext.Current.Session["value_sign_sql"] = strQuerySQL;
                
            }
            else
            {

                string strScript = string.Format("<script language='javascript'>error_msg('查無此資料，請再重新選擇POR Golden 條件!');</script>");
                Page.ClientScript.RegisterStartupScript(this.GetType(), "onload", strScript);              
                GridView1.Visible = false;
            }
        }
        catch (Exception ex)
        {
            //lblError.Text = "[NPIPOR Function-Error Message, btn_Search_Click] : " + ex.ToString();
        }

    }

    
  





  

  
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        
        GridView1.PageIndex = e.NewPageIndex;
        string temp = Global_Sql_POR;
        put_POR_Data(temp);

    }

    

   
   
}