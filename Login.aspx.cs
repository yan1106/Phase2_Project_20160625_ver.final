using System;
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
using System.Web.UI.HtmlControls;
using System.Collections;
using System.Web.Configuration;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;

public partial class Pages_Login : System.Web.UI.Page
{
    [DllImport("kernel32.dll")]
    static extern void GetSystemTime(out SYSTEMTIME lpSystemTime);
    private struct SYSTEMTIME{
        public ushort wYear;
        public ushort wMonth;
        public ushort wDayOfweek;
        public ushort wDay;
        public ushort wHour;
        public ushort wMinute;
        public ushort wSecond;
        public ushort wMilliseconds;
    
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        GetTime();
    }
    private void GetTime()
    {
        SYSTEMTIME stime = new SYSTEMTIME();
        GetSystemTime(out stime);
        //labTime.Text = "Current Time:" + stime.wYear.ToString() + "/" + stime.wMonth.ToString() + "/" + stime.wDay.ToString() + "  " + stime.wHour.ToString() +":"+ stime.wMinute.ToString() +":"+ stime.wSecond.ToString();
        //lblError.Text = DateTime.Now.ToString("yyyyMMdd");
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        //SqlConnection Conn = new SqlConnection(WebConfigurationManager.ConnectionStrings["SHDBConnectionString"].ConnectionString.ToString());
        //Conn.Open();       
        //string strSQL = "select User_Code,User_Name,user_flag from users where user_acc = '"+ username.Text +"' and user_pw='"+ password.Text +"'";
        //SqlCommand cmd = new SqlCommand(strSQL, Conn);
        //SqlDataReader dr = cmd.ExecuteReader();
        //if (dr.HasRows)
        //{
        //    dr.Read();
        //    Session["usercode"] = dr["User_Code"];//dr.GetOrdinal("user_code");
        //    Session["username"] = dr["User_Name"];//dr.GetOrdinal("user_name");
        //    Session["userflag"] = dr["User_flag"]; //0:離職 1:普通使用者 3:可以看不可修改 5:最大權限 
        //    Session["login"] = "OK";
        //    Response.Redirect("~/Pages/Home.aspx");
        //    cmd.Cancel();
        //    dr.Close();
        //    Conn.Close();
        //}
        //else
        //{
        //    Label1.Text = "您輸入的帳號/密碼有誤!";
        //    cmd.Cancel();
        //    dr.Close();
        //    Conn.Close();
        //}
        //Session["usercode"] = "twshao";//dr.GetOrdinal("user_code");
        //Session["username"] = "邵朝文";//dr.GetOrdinal("user_name");
        //Session["userflag"] = "1"; //0:離職 1:普通使用者 3:可以看不可修改 5:最大權限 
        //Session["userpassword"] = "1234";   
        clsMySQL db = new clsMySQL();
        MySqlDataReader dr;
        //DataSet ds;
        //DataRow dr;
        if (username.Text == "") 
        {
            lblError.Text = "請輸入工號!"; 
        }
        else if (password.Text == "")
        {
            lblError.Text = "請輸入密碼!"; 
        }
        else {
            string strQuerySQL = "Select * from infor_personal where workno ='" + username.Text.Trim() + "' and password = '" + password.Text.Trim() + "'";            
            //lblError.Text = strQuerySQL +"<br>";
            try
            {
                //ds = db.QueryDataSet(strQuerySQL);
                dr = db.dbQueryDR(strQuerySQL);
                if (dr.HasRows)
                //if (ds.Tables[0].Rows.Count > 0)
                {
                    //dr = ds.Tables[0].Rows[0];
                    dr.Read();
                    Session["Workno"] = dr["WorkNo"].ToString();
                    Session["chinesename"] = dr["ChineseName"].ToString();
                    Session["departname"] = dr["DepartName"].ToString();
                    Response.Redirect("~/test/Home.aspx");
                    //lblError.Text = "WorkNo:" + Session["WorkNo"].ToString() +"/ Chinesename :"+ Session["chinesename"].ToString() ;
                }
                else
                {
                    lblError.Text = "您輸入的工號/密碼不正確!";
                }     
                db.Close();
            }
            catch (Exception ex)
            {
                lblError.Text = "[Login Error Message] : " + ex.ToString();
                db.Close();
            }


            //if (username.Text == "twshao" && password.Text == "1234")
            //{
            //    Session["username"] = "邵朝文";
            //    Session["usercode"] = "twshao";
            //    Response.Redirect("~/test/Home.aspx");              
            //}
            //else
            //{
            //    lblError.Text = "您輸入的帳號/密碼不正確!";
            //}        
        }      
    }
}