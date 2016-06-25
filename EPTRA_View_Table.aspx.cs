﻿using System;
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
using System.ComponentModel;
using System.Drawing;
using System.Web.SessionState;

public partial class EPTRA_View_Table : System.Web.UI.Page
{
    public static string global_Ver_Name = "";

    protected void Page_Load(object sender, EventArgs e)
    {
        

        global_Ver_Name = Request.QueryString["filename"];

        string sql_porgodlen = "select * from npieptraver_por where Ver_Name='" + global_Ver_Name + "'";
        string sql_newdevice = "select * from npieptraver_new where Ver_Name='" + global_Ver_Name + "'";
        string sql_gap = "select * from npieptraver_gap where Ver_Name='" + global_Ver_Name + "'";
        string sql_capability = "select * from npieptraver_cap where Ver_Name='" + global_Ver_Name + "'";
        string sql_no = "select * from npieptraver_main where Ver_Name = '" + global_Ver_Name + "'";



        
        display_PORGOlden_data(sql_porgodlen);
        display_NewDevice_data(sql_newdevice);
        display_Capability_data(sql_capability);
        display_gap_data(sql_gap);
        gap_compare();
    }

    protected void display_PORGOlden_data(string sql_eptramain)
    {



        MySqlConnection MySqlConn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySQL"].ConnectionString);
        MySqlConn.Open();

        MySqlCommand MySqlCmd = new MySqlCommand(sql_eptramain, MySqlConn);
        MySqlDataReader mydr = MySqlCmd.ExecuteReader();




        while (mydr.Read())
        {

            lab_Ver_POR_1.Text = (String)mydr["Ver_POR_1"];
            lab_Ver_POR_2.Text = (String)mydr["Ver_POR_2"];
            lab_Ver_POR_3.Text = (String)mydr["Ver_POR_3"];
            lab_Ver_POR_4.Text = (String)mydr["Ver_POR_4"];
            lab_Ver_POR_5.Text = (String)mydr["Ver_POR_5"];
            lab_Ver_POR_6.Text = (String)mydr["Ver_POR_6"];
            lab_Ver_POR_7.Text = (String)mydr["Ver_POR_7"];
            lab_Ver_POR_8.Text = (String)mydr["Ver_POR_8"];
            lab_Ver_POR_9.Text = (String)mydr["Ver_POR_9"];
            lab_Ver_POR_10.Text = (String)mydr["Ver_POR_10"];
            lab_Ver_POR_11.Text = (String)mydr["Ver_POR_11"];
            lab_Ver_POR_12.Text = (String)mydr["Ver_POR_12"];
            lab_Ver_POR_13.Text = (String)mydr["Ver_POR_13"];
            lab_Ver_POR_14.Text = (String)mydr["Ver_POR_14"];
            lab_Ver_POR_15.Text = (String)mydr["Ver_POR_15"];
            lab_Ver_POR_16.Text = (String)mydr["Ver_POR_16"];
            lab_Ver_POR_17.Text = (String)mydr["Ver_POR_17"];
            lab_Ver_POR_18.Text = (String)mydr["Ver_POR_18"];
            lab_Ver_POR_19.Text = (String)mydr["Ver_POR_19"];
            lab_Ver_POR_20.Text = (String)mydr["Ver_POR_20"];
            lab_Ver_POR_21.Text = (String)mydr["Ver_POR_21"];
            lab_Ver_POR_22.Text = (String)mydr["Ver_POR_22"];
            lab_Ver_POR_23.Text = (String)mydr["Ver_POR_23"];
            lab_Ver_POR_24.Text = (String)mydr["Ver_POR_24"];
            lab_Ver_POR_25.Text = (String)mydr["Ver_POR_25"];
            lab_Ver_POR_26.Text = (String)mydr["Ver_POR_26"];
            lab_Ver_POR_27.Text = (String)mydr["Ver_POR_27"];
            lab_Ver_POR_28.Text = (String)mydr["Ver_POR_28"];
            lab_Ver_POR_29.Text = (String)mydr["Ver_POR_29"];
            lab_Ver_POR_30.Text = (String)mydr["Ver_POR_30"];
            lab_Ver_POR_31.Text = (String)mydr["Ver_POR_31"];
            lab_Ver_POR_32.Text = (String)mydr["Ver_POR_32"];
            lab_Ver_POR_33.Text = (String)mydr["Ver_POR_33"];
            lab_Ver_POR_34.Text = (String)mydr["Ver_POR_34"];
            lab_Ver_POR_35.Text = (String)mydr["Ver_POR_35"];
            lab_Ver_POR_36.Text = (String)mydr["Ver_POR_36"];
            lab_Ver_POR_37.Text = (String)mydr["Ver_POR_37"];
            lab_Ver_POR_38.Text = (String)mydr["Ver_POR_38"];
            lab_Ver_POR_39.Text = (String)mydr["Ver_POR_39"];
            lab_Ver_POR_40.Text = (String)mydr["Ver_POR_40"];
            lab_Ver_POR_41.Text = (String)mydr["Ver_POR_41"];
            lab_Ver_POR_42.Text = (String)mydr["Ver_POR_42"];
            lab_Ver_POR_43.Text = (String)mydr["Ver_POR_43"];


        }

        MySqlConn.Close();

    }





    protected void display_Capability_data(string sql_capability)
    {



        MySqlConnection MySqlConn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySQL"].ConnectionString);
        MySqlConn.Open();

        MySqlCommand MySqlCmd = new MySqlCommand(sql_capability, MySqlConn);
        MySqlDataReader mydr = MySqlCmd.ExecuteReader();




        while (mydr.Read())
        {

            CAP_EP_1.Text = (String)mydr["Ver_Cap_1"];
            CAP_EP_2.Text = (String)mydr["Ver_Cap_2"];
            CAP_EP_3.Text = (String)mydr["Ver_Cap_3"];
            CAP_EP_4.Text = (String)mydr["Ver_Cap_4"];
            CAP_EP_5.Text = (String)mydr["Ver_Cap_5"];
            CAP_EP_6.Text = (String)mydr["Ver_Cap_6"];
            CAP_EP_7.Text = (String)mydr["Ver_Cap_7"];
            CAP_EP_8.Text = (String)mydr["Ver_Cap_8"];
            CAP_EP_9.Text = (String)mydr["Ver_Cap_9"];
            CAP_EP_10.Text = (String)mydr["Ver_Cap_10"];
            CAP_EP_11.Text = (String)mydr["Ver_Cap_11"];
            CAP_EP_12.Text = (String)mydr["Ver_Cap_12"];
            CAP_EP_13.Text = (String)mydr["Ver_Cap_13"];
            CAP_EP_14.Text = (String)mydr["Ver_Cap_14"];
            CAP_EP_15.Text = (String)mydr["Ver_Cap_15"];
            CAP_EP_16.Text = (String)mydr["Ver_Cap_16"];
            CAP_EP_17.Text = (String)mydr["Ver_Cap_17"];
            CAP_EP_18.Text = (String)mydr["Ver_Cap_18"];
            CAP_EP_19.Text = (String)mydr["Ver_Cap_19"];
            CAP_EP_20.Text = (String)mydr["Ver_Cap_20"];
            CAP_EP_21.Text = (String)mydr["Ver_Cap_21"];
            CAP_EP_22.Text = (String)mydr["Ver_Cap_22"];
            CAP_EP_23.Text = (String)mydr["Ver_Cap_23"];
            CAP_EP_24.Text = (String)mydr["Ver_Cap_24"];
            CAP_EP_25.Text = (String)mydr["Ver_Cap_25"];
            CAP_EP_26.Text = (String)mydr["Ver_Cap_26"];
            CAP_EP_27.Text = (String)mydr["Ver_Cap_27"];
            CAP_EP_28.Text = (String)mydr["Ver_Cap_28"];
            CAP_EP_29.Text = (String)mydr["Ver_Cap_29"];
            CAP_EP_30.Text = (String)mydr["Ver_Cap_30"];
            CAP_EP_31.Text = (String)mydr["Ver_Cap_31"];
            CAP_EP_32.Text = (String)mydr["Ver_Cap_32"];
            CAP_EP_33.Text = (String)mydr["Ver_Cap_33"];
            CAP_EP_34.Text = (String)mydr["Ver_Cap_34"];
            CAP_EP_35.Text = (String)mydr["Ver_Cap_35"];
            CAP_EP_36.Text = (String)mydr["Ver_Cap_36"];
            CAP_EP_37.Text = (String)mydr["Ver_Cap_37"];
            CAP_EP_38.Text = (String)mydr["Ver_Cap_38"];
            CAP_EP_39.Text = (String)mydr["Ver_Cap_39"];
            CAP_EP_40.Text = (String)mydr["Ver_Cap_40"];
            CAP_EP_41.Text = (String)mydr["Ver_Cap_41"];
            CAP_EP_42.Text = (String)mydr["Ver_Cap_42"];
            CAP_EP_43.Text = (String)mydr["Ver_Cap_43"];
            CAP_EP_44.Text = (String)mydr["Ver_Cap_44"];
            CAP_EP_45.Text = (String)mydr["Ver_Cap_45"];
            CAP_EP_46.Text = (String)mydr["Ver_Cap_46"];
            CAP_EP_47.Text = (String)mydr["Ver_Cap_47"];
            CAP_EP_48.Text = (String)mydr["Ver_Cap_48"];
            CAP_EP_49.Text = (String)mydr["Ver_Cap_49"];
            CAP_EP_50.Text = (String)mydr["Ver_Cap_50"];
            CAP_EP_51.Text = (String)mydr["Ver_Cap_51"];
            CAP_EP_52.Text = (String)mydr["Ver_Cap_52"];
            CAP_EP_53.Text = (String)mydr["Ver_Cap_53"];
            CAP_EP_54.Text = (String)mydr["Ver_Cap_54"];
            CAP_EP_55.Text = (String)mydr["Ver_Cap_55"];
            CAP_EP_56.Text = (String)mydr["Ver_Cap_56"];
            CAP_EP_57.Text = (String)mydr["Ver_Cap_57"];
            CAP_EP_58.Text = (String)mydr["Ver_Cap_58"];
            CAP_EP_59.Text = (String)mydr["Ver_Cap_59"];
            CAP_EP_60.Text = (String)mydr["Ver_Cap_60"];
            CAP_EP_61.Text = (String)mydr["Ver_Cap_61"];
            CAP_EP_62.Text = (String)mydr["Ver_Cap_62"];
            CAP_EP_63.Text = (String)mydr["Ver_Cap_63"];
            CAP_EP_64.Text = (String)mydr["Ver_Cap_64"];

            CAP_EP__POR_1.Text = (String)mydr["Ver_Cap_Por_1"];
            CAP_EP__POR_2.Text = (String)mydr["Ver_Cap_Por_2"];
            CAP_EP__POR_3.Text = (String)mydr["Ver_Cap_Por_3"];
            CAP_EP__POR_4.Text = (String)mydr["Ver_Cap_Por_4"];
            CAP_EP__POR_5.Text = (String)mydr["Ver_Cap_Por_5"];
            CAP_EP__POR_6.Text = (String)mydr["Ver_Cap_Por_6"];
            CAP_EP__POR_7.Text = (String)mydr["Ver_Cap_Por_7"];
            CAP_EP__POR_8.Text = (String)mydr["Ver_Cap_Por_8"];
            CAP_EP__POR_9.Text = (String)mydr["Ver_Cap_Por_9"];
            CAP_EP__POR_10.Text = (String)mydr["Ver_Cap_Por_10"];
            CAP_EP__POR_11.Text = (String)mydr["Ver_Cap_Por_11"];
            CAP_EP__POR_12.Text = (String)mydr["Ver_Cap_Por_12"];
            CAP_EP__POR_13.Text = (String)mydr["Ver_Cap_Por_13"];
            CAP_EP__POR_14.Text = (String)mydr["Ver_Cap_Por_14"];
            CAP_EP__POR_15.Text = (String)mydr["Ver_Cap_Por_15"];
        }
        MySqlConn.Close();


    }





















    protected void display_NewDevice_data(string sql_eptramain)
    {



        MySqlConnection MySqlConn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySQL"].ConnectionString);
        MySqlConn.Open();

        MySqlCommand MySqlCmd = new MySqlCommand(sql_eptramain, MySqlConn);
        MySqlDataReader mydr = MySqlCmd.ExecuteReader();




        while (mydr.Read())
        {

            lab_Ver_New_2.Text = (String)mydr["Ver_New_2"];
            lab_Ver_New_3.Text = (String)mydr["Ver_New_3"];
            lab_Ver_New_4.Text = (String)mydr["Ver_New_4"];
            lab_Ver_New_5.Text = (String)mydr["Ver_New_5"];
            lab_Ver_New_6.Text = (String)mydr["Ver_New_6"];
            lab_Ver_New_7.Text = (String)mydr["Ver_New_7"];
            lab_Ver_New_8.Text = (String)mydr["Ver_New_8"];
            lab_Ver_New_9.Text = (String)mydr["Ver_New_9"];
            lab_Ver_New_10.Text = (String)mydr["Ver_New_10"];
            lab_Ver_New_11.Text = (String)mydr["Ver_New_11"];
            lab_Ver_New_12.Text = (String)mydr["Ver_New_12"];
            lab_Ver_New_13.Text = (String)mydr["Ver_New_13"];
            lab_Ver_New_14.Text = (String)mydr["Ver_New_14"];
            lab_Ver_New_15.Text = (String)mydr["Ver_New_15"];
            lab_Ver_New_16.Text = (String)mydr["Ver_New_16"];
            lab_Ver_New_17.Text = (String)mydr["Ver_New_17"];
            lab_Ver_New_18.Text = (String)mydr["Ver_New_18"];
            lab_Ver_New_19.Text = (String)mydr["Ver_New_19"];
            lab_Ver_New_20.Text = (String)mydr["Ver_New_20"];
            lab_Ver_New_21.Text = (String)mydr["Ver_New_21"];
            lab_Ver_New_22.Text = (String)mydr["Ver_New_22"];
            lab_Ver_New_23.Text = (String)mydr["Ver_New_23"];
            lab_Ver_New_24.Text = (String)mydr["Ver_New_24"];
            lab_Ver_New_25.Text = (String)mydr["Ver_New_25"];
            lab_Ver_New_26.Text = (String)mydr["Ver_New_26"];
            lab_Ver_New_27.Text = (String)mydr["Ver_New_27"];
            lab_Ver_New_28.Text = (String)mydr["Ver_New_28"];
            lab_Ver_New_29.Text = (String)mydr["Ver_New_29"];
            lab_Ver_New_30.Text = (String)mydr["Ver_New_30"];
            lab_Ver_New_31.Text = (String)mydr["Ver_New_31"];
            lab_Ver_New_32.Text = (String)mydr["Ver_New_32"];
            lab_Ver_New_33.Text = (String)mydr["Ver_New_33"];
            lab_Ver_New_34.Text = (String)mydr["Ver_New_34"];
            lab_Ver_New_35.Text = (String)mydr["Ver_New_35"];
            lab_Ver_New_36.Text = (String)mydr["Ver_New_36"];
            lab_Ver_New_37.Text = (String)mydr["Ver_New_37"];
            lab_Ver_New_38.Text = (String)mydr["Ver_New_38"];
            lab_Ver_New_39.Text = (String)mydr["Ver_New_39"];
            lab_Ver_New_40.Text = (String)mydr["Ver_New_40"];
            lab_Ver_New_41.Text = (String)mydr["Ver_New_41"];
            lab_Ver_New_42.Text = (String)mydr["Ver_New_42"];
            lab_Ver_New_43.Text = (String)mydr["Ver_New_43"];
            lab_Ver_New_44.Text = (String)mydr["Ver_New_44"];
            lab_Ver_New_45.Text = (String)mydr["Ver_New_45"];
            lab_Ver_New_46.Text = (String)mydr["Ver_New_46"];
            lab_Ver_New_47.Text = (String)mydr["Ver_New_47"];
            lab_Ver_New_48.Text = (String)mydr["Ver_New_48"];
            lab_Ver_New_49.Text = (String)mydr["Ver_New_49"];
            lab_Ver_New_50.Text = (String)mydr["Ver_New_50"];
            lab_Ver_New_51.Text = (String)mydr["Ver_New_51"];
            lab_Ver_New_52.Text = (String)mydr["Ver_New_52"];
            lab_Ver_New_53.Text = (String)mydr["Ver_New_53"];
            lab_Ver_New_54.Text = (String)mydr["Ver_New_54"];
            lab_Ver_New_55.Text = (String)mydr["Ver_New_55"];
            lab_Ver_New_56.Text = (String)mydr["Ver_New_56"];
            lab_Ver_New_57.Text = (String)mydr["Ver_New_57"];
            lab_Ver_New_58.Text = (String)mydr["Ver_New_58"];
            lab_Ver_New_59.Text = (String)mydr["Ver_New_59"];
            lab_Ver_New_60.Text = (String)mydr["Ver_New_60"];
            lab_Ver_New_61.Text = (String)mydr["Ver_New_61"];
            lab_Ver_New_62.Text = (String)mydr["Ver_New_62"];
            lab_Ver_New_63.Text = (String)mydr["Ver_New_63"];
            lab_Ver_New_64.Text = (String)mydr["Ver_New_64"];
            lab_Ver_New_65.Text = (String)mydr["Ver_New_65"];
        }
        MySqlConn.Close();


    }

    protected void display_gap_data(string sql_eptramain)
    {



        MySqlConnection MySqlConn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySQL"].ConnectionString);
        MySqlConn.Open();

        MySqlCommand MySqlCmd = new MySqlCommand(sql_eptramain, MySqlConn);
        MySqlDataReader mydr = MySqlCmd.ExecuteReader();




        while (mydr.Read())
        {
            lab_gap2.Text = (String)mydr["Ver_Gap2"];
            lab_gap3.Text = (String)mydr["Ver_Gap3"];
            lab_gap4.Text = (String)mydr["Ver_Gap4"];
            lab_gap5.Text = (String)mydr["Ver_Gap5"];
            lab_gap6.Text = (String)mydr["Ver_Gap6"];
            lab_gap7.Text = (String)mydr["Ver_Gap7"];
            lab_gap8.Text = (String)mydr["Ver_Gap8"];
            lab_gap9.Text = (String)mydr["Ver_Gap9"];
            lab_gap10.Text = (String)mydr["Ver_Gap10"];
            lab_gap11.Text = (String)mydr["Ver_Gap11"];
            lab_gap12.Text = (String)mydr["Ver_Gap12"];
            lab_gap13.Text = (String)mydr["Ver_Gap13"];
            lab_gap14.Text = (String)mydr["Ver_Gap14"];
            lab_gap15.Text = (String)mydr["Ver_Gap15"];
            lab_gap16.Text = (String)mydr["Ver_Gap16"];
            lab_gap17.Text = (String)mydr["Ver_Gap17"];
            lab_gap18.Text = (String)mydr["Ver_Gap18"];
            lab_gap19.Text = (String)mydr["Ver_Gap19"];
            lab_gap20.Text = (String)mydr["Ver_Gap20"];
            lab_gap21.Text = (String)mydr["Ver_Gap21"];
            lab_gap22.Text = (String)mydr["Ver_Gap22"];
            lab_gap23.Text = (String)mydr["Ver_Gap23"];
            lab_gap24.Text = (String)mydr["Ver_Gap24"];
            lab_gap25.Text = (String)mydr["Ver_Gap25"];
            lab_gap26.Text = (String)mydr["Ver_Gap26"];
            lab_gap27.Text = (String)mydr["Ver_Gap27"];
            lab_gap28.Text = (String)mydr["Ver_Gap28"];
            lab_gap29.Text = (String)mydr["Ver_Gap29"];
            lab_gap30.Text = (String)mydr["Ver_Gap30"];
            lab_gap31.Text = (String)mydr["Ver_Gap31"];
            lab_gap32.Text = (String)mydr["Ver_Gap32"];
            lab_gap33.Text = (String)mydr["Ver_Gap33"];
            lab_gap34.Text = (String)mydr["Ver_Gap34"];
            lab_gap35.Text = (String)mydr["Ver_Gap35"];
            lab_gap36.Text = (String)mydr["Ver_Gap36"];
            lab_gap37.Text = (String)mydr["Ver_Gap37"];
            lab_gap38.Text = (String)mydr["Ver_Gap38"];
            lab_gap39.Text = (String)mydr["Ver_Gap39"];
            lab_gap40.Text = (String)mydr["Ver_Gap40"];
            lab_gap41.Text = (String)mydr["Ver_Gap41"];
            lab_gap42.Text = (String)mydr["Ver_Gap42"];
            lab_gap43.Text = (String)mydr["Ver_Gap43"];
            lab_gap44.Text = (String)mydr["Ver_Gap44"];
            lab_gap45.Text = (String)mydr["Ver_Gap45"];
            lab_gap46.Text = (String)mydr["Ver_Gap46"];
            lab_gap47.Text = (String)mydr["Ver_Gap47"];
            lab_gap48.Text = (String)mydr["Ver_Gap48"];
            lab_gap49.Text = (String)mydr["Ver_Gap49"];
            lab_gap50.Text = (String)mydr["Ver_Gap50"];
            lab_gap51.Text = (String)mydr["Ver_Gap51"];
            lab_gap52.Text = (String)mydr["Ver_Gap52"];
            lab_gap53.Text = (String)mydr["Ver_Gap53"];
            lab_gap54.Text = (String)mydr["Ver_Gap54"];
            lab_gap55.Text = (String)mydr["Ver_Gap55"];
            lab_gap56.Text = (String)mydr["Ver_Gap56"];
            lab_gap57.Text = (String)mydr["Ver_Gap57"];
            lab_gap58.Text = (String)mydr["Ver_Gap58"];
            lab_gap59.Text = (String)mydr["Ver_Gap59"];
            lab_gap60.Text = (String)mydr["Ver_Gap60"];
            lab_gap61.Text = (String)mydr["Ver_Gap61"];
            lab_gap62.Text = (String)mydr["Ver_Gap62"];
            lab_gap63.Text = (String)mydr["Ver_Gap63"];
            lab_gap64.Text = (String)mydr["Ver_Gap64"];
            lab_gap65.Text = (String)mydr["Ver_Gap65"];






        }

        MySqlConn.Close();


    }


    protected int count_EffectLabel(string Key_item)
    {
        string sql = "select COUNT(DISTINCT EP_Cate_SpeChar) from npieptraver_category where EP_Cate_Iiitems='" + Key_item + "' and Ver_Name='" + global_Ver_Name + "'";
        int temp = 0;

        MySqlConnection MySqlConn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySQL"].ConnectionString);
        MySqlConn.Open();

        MySqlCommand MySqlCmd = new MySqlCommand(sql, MySqlConn);
        MySqlDataReader mydr = MySqlCmd.ExecuteReader();

        while (mydr.Read())
        {
            temp = Convert.ToInt32(mydr["COUNT(DISTINCT EP_Cate_SpeChar)"]);
        }

        mydr.Close();
        MySqlConn.Close();


        return temp;


    }

    protected int count_Effectstage(string Key_item)
    {
        string sql = "select COUNT(DISTINCT EP_Cate_Stage) from npieptraver_category where EP_Cate_Iiitems='" + Key_item + "' and Ver_Name='" + global_Ver_Name + "'";
        int temp = 0;

        MySqlConnection MySqlConn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySQL"].ConnectionString);
        MySqlConn.Open();

        MySqlCommand MySqlCmd = new MySqlCommand(sql, MySqlConn);
        MySqlDataReader mydr = MySqlCmd.ExecuteReader();

        while (mydr.Read())
        {
            temp = Convert.ToInt32(mydr["COUNT(DISTINCT EP_Cate_Stage)"]);
        }

        mydr.Close();
        MySqlConn.Close();


        return temp;


    }


    protected int count_EffectLabel_stage(string Key_item, string stage)
    {
        string sql = "select COUNT(DISTINCT EP_Cate_SpeChar) from npieptraver_category where EP_Cate_Iiitems='" + Key_item + "'and EP_Cate_Stage='" + stage + "' and Ver_Name='" + global_Ver_Name + "'";
        int temp = 0;

        MySqlConnection MySqlConn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySQL"].ConnectionString);
        MySqlConn.Open();

        MySqlCommand MySqlCmd = new MySqlCommand(sql, MySqlConn);
        MySqlDataReader mydr = MySqlCmd.ExecuteReader();

        while (mydr.Read())
        {
            temp = Convert.ToInt32(mydr["COUNT(DISTINCT EP_Cate_SpeChar)"]);
        }

        mydr.Close();
        MySqlConn.Close();


        return temp;


    }



    protected string display_Effectstage(string Key_item, int temp_num = 0)
    {
        string sql = "select DISTINCT EP_Cate_Stage from npieptraver_category where EP_Cate_Iiitems='" + Key_item + "' and Ver_Name = '" + global_Ver_Name + "'";
        string temp;
        List<string> temp_effect = new List<string>();
        //temp_num = 0;

        MySqlConnection MySqlConn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySQL"].ConnectionString);
        MySqlConn.Open();

        MySqlCommand MySqlCmd = new MySqlCommand(sql, MySqlConn);
        MySqlDataReader mydr = MySqlCmd.ExecuteReader();

        while (mydr.Read())
        {
            temp_effect.Add(Convert.ToString(mydr["EP_Cate_Stage"]));
        }

        mydr.Close();
        MySqlConn.Close();


        return temp_effect[temp_num];

    }



    protected string display_EffectLabel(string Key_item, string stage, int temp_num = 0)
    {
        string sql = "select DISTINCT EP_Cate_SpeChar from npieptraver_category where EP_Cate_Iiitems='" + Key_item + "' and EP_Cate_Stage='" + stage + "' and Ver_Name = '" + global_Ver_Name + "'";
        string temp;
        List<string> temp_effect = new List<string>();


        MySqlConnection MySqlConn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySQL"].ConnectionString);
        MySqlConn.Open();

        MySqlCommand MySqlCmd = new MySqlCommand(sql, MySqlConn);
        MySqlDataReader mydr = MySqlCmd.ExecuteReader();

        while (mydr.Read())
        {
            temp_effect.Add(Convert.ToString(mydr["EP_Cate_SpeChar"]));
        }

        mydr.Close();
        MySqlConn.Close();


        return temp_effect[temp_num];

    }

    protected Boolean jude_keyitem(string keyitem)
    {

        string sql = "select DISTINCT EP_Cate_Stage from npieptraver_category where EP_Cate_Iiitems='" + keyitem + "' and Ver_Name='" + global_Ver_Name + "'";
        string temp = "";


        MySqlConnection MySqlConn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySQL"].ConnectionString);
        MySqlConn.Open();

        MySqlCommand MySqlCmd = new MySqlCommand(sql, MySqlConn);
        MySqlDataReader mydr = MySqlCmd.ExecuteReader();

        while (mydr.Read())
        {
            temp = mydr["EP_Cate_Stage"].ToString();
        }

        mydr.Close();
        MySqlConn.Close();


        if (temp != "")
            return true;
        else
            return false;



    }


    protected void keyitem_put_data2(Panel temp_Lv, Panel temp_stage, Panel temp_pot, Label lab_stage, Label lab_pot, string keyitem)
    {

        List<int> b = new List<int>(); // 存放count_EffectLabel_stage 值
        int a = count_Effectstage(keyitem);
        //int b = count_EffectLabel(keyitem);
        string temp_effect_name = "";
        string temp_pot_name = "";
        string br = "";
        string temp_pot_name2 = "";



       

        if (jude_keyitem(keyitem) == true)
        {
            for (int i = 0; i < a; i++)
            {
                Label effect = new Label();
                ImageButton TraLv = new ImageButton();
                Label Tratext = new Label();

                temp_effect_name = display_Effectstage(keyitem, i);
                effect.ID = "KeyItem_" + keyitem + "stage_" + temp_effect_name;
                TraLv.ID = "Imagebutton_" + keyitem + "_" + temp_effect_name;
                b.Add(count_EffectLabel_stage(keyitem, temp_effect_name));

                for (int j = 0; j < b[i] + 1; j++)
                {
                    br += "<br>";

                }
               
                effect.Text = temp_effect_name + br;
                temp_stage.Controls.Add(effect);

                //TraLv.OnClientClick = "window.open(EP_TRA_Level.aspx,Set_DOE_Lv,width = 200,height = 100)";
                //TraLv.Attributes.Add("onclientClick", "window.open(/EP_TRA_Level.aspx, Set_DOE_Lv)");






                Label Potential = new Label();
                string str = "";

                for (int k = 0; k < b[i]; k++)
                {

                    temp_pot_name = display_EffectLabel(keyitem, temp_effect_name, k);
                    temp_pot_name2 += temp_pot_name + "<br />";
                    if (k != (b[i] - 1))
                    {
                        str += temp_pot_name + "|";
                    }
                    else
                    {
                        str += temp_pot_name;
                    }


                    if (b[i] - 1 == k)
                    {
                        Potential.Text += "<br>";
                    }


                    //Potential.Attributes.Remove("href");
                    //temp_pot.Controls.Add(Potential);

                }

                string temp_lv_count = Query_Lv_amount(global_Ver_Name, keyitem, temp_effect_name);
                string[] count_Lv = temp_lv_count.Split('|');
                int rc = Convert.ToInt32(count_Lv[0]);
                int mc = Convert.ToInt32(count_Lv[1]);
                int lc = Convert.ToInt32(count_Lv[2]);
                double sum_lv = (rc + mc + lc);
                double count_lv_half = Math.Round((sum_lv / 3), 2);




                if (rc == 0 && mc == 0 && lc == 0)
                {
                    TraLv.ImageUrl = "icon/white.gif";
                }
                else if (rc >= 1 && mc == 0 && lc == 0)
                {
                    TraLv.ImageUrl = "icon/red.gif";
                    
                }
                else if (rc >= 1 && mc >= 1 && lc == 0)
                {
                    TraLv.ImageUrl = "icon/red.gif";
                    
                }
                else if (rc >= 1 && lc == 0)
                {
                    TraLv.ImageUrl = "icon/red.gif";
                    
                }
                else if (mc >= 1 && lc == 0)
                {
                    TraLv.ImageUrl = "icon/red.gif";
                   
                }
                else if (mc >= 1 && rc >= 1 && lc >= 1)
                {
                    TraLv.ImageUrl = "icon/red.gif";
                    
                }
                else if (mc >= 1 && lc >= 1)
                {
                    TraLv.ImageUrl = "icon/red.gif";
                    
                }
                else if (rc >= 1 && lc >= 1)
                {
                    TraLv.ImageUrl = "icon/red.gif";
                    
                }
                else if (lc >= 1 && rc == 0 && mc == 0)
                {
                    TraLv.ImageUrl = "icon/green.gif";
                    
                }



                string session = "filename=" + global_Ver_Name + "&" + "keyitem=" + keyitem + "&" + "stage=" + temp_effect_name + "";


                TraLv.OnClientClick = "AddWork_Lv_View('" + global_Ver_Name + "','" + keyitem + "','" + temp_effect_name + "')";
                TraLv.Attributes.Add("onclick", "return false;");

                TraLv.Width = Unit.Pixel(30);
                TraLv.Height = Unit.Pixel(30);
                temp_Lv.Controls.Add(TraLv);



                Tratext.Text = br;

                temp_Lv.Controls.Add(Tratext);


                br = "";

                Potential.ID = "KeyItem" + "_" + keyitem + "Potential_" + temp_pot_name;
                //Potential.NavigateUrl = url;
                //Potential.Target = "_self";
                Potential.Text = temp_pot_name2 + "<br />";

               
                temp_pot_name2 = "";
                temp_pot.Controls.Add(Potential);
            }

        }
        else
        {
            lab_stage.Text = "Not Defined!";
            lab_stage.ForeColor = System.Drawing.Color.Red;
            lab_pot.Text = "Not Defined!";
            lab_pot.ForeColor = System.Drawing.Color.Red;

        }


    }


    protected string Query_Lv_amount(string filename, string keyitem, string stage)
    {
        string str_ret = "";

        string Lv = "";
        string sql = "select EPTRA_LV from npieptra_lv_main where Ver_Name='" + filename + "' and EPTRA_LV_Stage='" + stage + "' and EPTRA_KeyItem='" + keyitem + "'";
        int lc = 0, rc = 0, mc = 0;



        MySqlConnection MySqlConn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySQL"].ConnectionString);
        MySqlConn.Open();

        MySqlCommand MySqlCmd = new MySqlCommand(sql, MySqlConn);
        MySqlDataReader mydr = MySqlCmd.ExecuteReader();

        while (mydr.Read())
        {
            Lv = mydr["EPTRA_LV"].ToString();

            //RC(Lv.3)=MC(Lv.4)>LC(Lv.5)
            if (Lv == "RC(Lv.3)")
                rc++;
            else if (Lv == "MC(Lv.4)")
                mc++;
            else if (Lv == "LC(Lv.5)")
                lc++;


        }
        str_ret = rc.ToString() + "|" + mc.ToString() + "|" + lc.ToString();
        mydr.Close();
        MySqlConn.Close();



        return str_ret;



    }




    protected void gap_compare()
    {


        if (lab_gap1.Text == "Y")
        {
            lab_Eff_01.Text = "--";
            lab_Pot_01.Text = "--";
        }
        else
        {
            lab_Eff_01.Text = "--";
            lab_Pot_01.Text = "--";
        }
        if (lab_gap2.Text == "Y")
        {
            lab_Eff_01.Text = "--";
            lab_Pot_01.Text = "--";
        }
        else
        {
            lab_Eff_01.Text = "--";
            lab_Pot_01.Text = "--";
        }
        if (lab_gap3.Text == "Y")
        {
            lab_Eff_01.Text = "--";
            lab_Pot_01.Text = "--";
        }
        else
        {
            lab_Eff_01.Text = "--";
            lab_Pot_01.Text = "--";
        }
        if (lab_gap4.Text == "Y")
        {
            lab_gap4.Text = "Y";
            lab_gap4.ForeColor = System.Drawing.Color.Red;

            //keyitem_put_data(Panel_Eff_04, Panel_Pot_04,lab_Eff_04,lab_Pot_04,Lab_keyitem_04.Text);
            keyitem_put_data2(Panel_Lv_4, Panel_Eff_04, Panel_Pot_04, lab_Eff_04, lab_Pot_04, Lab_keyitem_04.Text);


        }
        else
        {
            lab_gap4.Text = "N";
            lab_gap4.ForeColor = System.Drawing.Color.Blue;
            lab_Eff_04.Text = "--";
            lab_Pot_04.Text = "--";

        }

        if (lab_gap5.Text == "Y")
        {
            lab_gap5.Text = "Y";
            lab_gap5.ForeColor = System.Drawing.Color.Red;

            keyitem_put_data2(Panel_Lv_5, Panel_Eff_05, Panel_Pot_05, lab_Eff_05, lab_Pot_05, Lab_keyitem_05.Text);
        }
        else
        {
            lab_gap5.Text = "N";
            lab_gap5.ForeColor = System.Drawing.Color.Blue;
            lab_Eff_05.Text = "--";
            lab_Pot_05.Text = "--";
        }

        if (lab_gap6.Text == "Y")
        {
            lab_gap6.Text = "Y";
            lab_gap6.ForeColor = System.Drawing.Color.Red;
            keyitem_put_data2(Panel_Lv_6, Panel_Eff_06, Panel_Pot_06, lab_Eff_06, lab_Pot_06, Lab_keyitem_06.Text);
        }
        else
        {
            lab_gap6.Text = "N";
            lab_gap6.ForeColor = System.Drawing.Color.Blue;
            lab_Eff_06.Text = "--";
            lab_Pot_06.Text = "--";
        }
        if (lab_gap7.Text == "Y")
        {
            lab_gap7.Text = "Y";
            lab_gap7.ForeColor = System.Drawing.Color.Red;
            keyitem_put_data2(Panel_Lv_7, Panel_Eff_07, Panel_Pot_07, lab_Eff_07, lab_Pot_07, Lab_keyitem_07.Text);
        }
        else
        {
            lab_gap7.Text = "N";
            lab_gap7.ForeColor = System.Drawing.Color.Blue;
            lab_Eff_07.Text = "--";
            lab_Pot_07.Text = "--";
        }
        if (lab_gap8.Text == "Y")
        {
            lab_gap8.Text = "Y";
            lab_gap8.ForeColor = System.Drawing.Color.Red;
            keyitem_put_data2(Panel_Lv_8, Panel_Eff_08, Panel_Pot_08, lab_Eff_08, lab_Pot_08, Lab_keyitem_08.Text);
        }
        else
        {
            lab_gap8.Text = "N";
            lab_gap8.ForeColor = System.Drawing.Color.Blue;
            lab_Eff_08.Text = "--";
            lab_Pot_08.Text = "--";
        }
        if (lab_gap9.Text == "Y")
        {
            lab_gap9.Text = "Y";
            lab_gap9.ForeColor = System.Drawing.Color.Red;

            keyitem_put_data2(Panel_Lv_9, Panel_Eff_09, Panel_Pot_09, lab_Eff_09, lab_Pot_09, Lab_keyitem_09.Text);
        }
        else
        {
            lab_gap9.Text = "N";
            lab_gap9.ForeColor = System.Drawing.Color.Blue;
            lab_Eff_09.Text = "--";
            lab_Pot_09.Text = "--";
        }
        if (lab_gap10.Text == "Y")
        {
            lab_gap10.Text = "Y";
            lab_gap10.ForeColor = System.Drawing.Color.Red;
            keyitem_put_data2(Panel_Lv_10, Panel_Eff_10, Panel_Pot_10, lab_Eff_10, lab_Pot_10, Lab_keyitem_10.Text);
        }
        else
        {
            lab_gap10.Text = "N";
            lab_gap10.ForeColor = System.Drawing.Color.Blue;
            lab_Eff_10.Text = "--";
            lab_Pot_10.Text = "--";
        }
        if (lab_gap11.Text == "Y")
        {
            lab_gap11.Text = "Y";
            lab_gap11.ForeColor = System.Drawing.Color.Red;
            keyitem_put_data2(Panel_Lv_11, Panel_Eff_11, Panel_Pot_11, lab_Eff_11, lab_Pot_11, Lab_keyitem_11.Text);
        }
        else
        {
            lab_gap11.Text = "N";
            lab_gap11.ForeColor = System.Drawing.Color.Blue;
            lab_Eff_11.Text = "--";
            lab_Pot_11.Text = "--";
        }
        if (lab_gap12.Text == "Y")
        {
            lab_gap12.Text = "Y";
            lab_gap12.ForeColor = System.Drawing.Color.Red;
            keyitem_put_data2(Panel_Lv_12, Panel_Eff_12, Panel_Pot_12, lab_Eff_12, lab_Pot_12, Lab_keyitem_12.Text);
        }
        else
        {
            lab_gap12.Text = "N";
            lab_gap12.ForeColor = System.Drawing.Color.Blue;
            lab_Eff_12.Text = "--";
            lab_Pot_12.Text = "--";
        }
        if (lab_gap13.Text == "Y")
        {
            lab_gap13.Text = "Y";
            lab_gap13.ForeColor = System.Drawing.Color.Red;
            keyitem_put_data2(Panel_Lv_13, Panel_Eff_13, Panel_Pot_13, lab_Eff_13, lab_Pot_13, Lab_keyitem_13.Text);
        }
        else
        {
            lab_gap13.Text = "N";
            lab_gap13.ForeColor = System.Drawing.Color.Blue;
            lab_Eff_13.Text = "--";
            lab_Pot_13.Text = "--";
        }

        if (lab_gap14.Text == "Y")
        {
            lab_gap14.Text = "Y";
            lab_gap14.ForeColor = System.Drawing.Color.Red;
            keyitem_put_data2(Panel_Lv_14, Panel_Eff_14, Panel_Pot_14, lab_Eff_14, lab_Pot_14, Lab_keyitem_14.Text);
        }
        else
        {
            lab_gap14.Text = "N";
            lab_gap14.ForeColor = System.Drawing.Color.Blue;
            lab_Eff_14.Text = "--";
            lab_Pot_14.Text = "--";
        }
        if (lab_gap15.Text == "Y")
        {
            lab_gap15.Text = "Y";
            lab_gap15.ForeColor = System.Drawing.Color.Red;
            keyitem_put_data2(Panel_Lv_15, Panel_Eff_15, Panel_Pot_15, lab_Eff_15, lab_Pot_15, Lab_keyitem_15.Text);
        }
        else
        {
            lab_gap15.Text = "N";
            lab_gap15.ForeColor = System.Drawing.Color.Blue;
            lab_Eff_15.Text = "--";
            lab_Pot_15.Text = "--";
        }
        if (lab_gap16.Text == "Y")
        {
            lab_gap16.Text = "Y";
            lab_gap16.ForeColor = System.Drawing.Color.Red;
            ///PI Thickness (um)
            keyitem_put_data2(Panel_Lv_16, Panel_Eff_16, Panel_Pot_16, lab_Eff_16, lab_Pot_16, Lab_keyitem_16.Text);

        }
        else
        {
            lab_gap16.Text = "N";
            lab_gap16.ForeColor = System.Drawing.Color.Blue;
            lab_Eff_16.Text = "--";
            lab_Pot_16.Text = "--";
        }

        if (lab_gap17.Text == "Y")
        {
            lab_gap17.Text = "Y";
            lab_gap17.ForeColor = System.Drawing.Color.Red;
            //keyitem_put_data(Panel_Eff_17, Panel_Pot_17, lab_Eff_17, lab_Pot_17, Lab_keyitem_17.Text);
            keyitem_put_data2(Panel_Lv_17, Panel_Eff_17, Panel_Pot_17, lab_Eff_17, lab_Pot_17, Lab_keyitem_17.Text);
        }
        else
        {
            lab_gap17.Text = "N";
            lab_gap17.ForeColor = System.Drawing.Color.Blue;
            lab_Eff_17.Text = "--";
            lab_Pot_17.Text = "--";
        }

        if (lab_gap18.Text == "Y")
        {
            lab_gap18.Text = "Y";
            lab_gap18.ForeColor = System.Drawing.Color.Red;
            keyitem_put_data2(Panel_Lv_18, Panel_Eff_18, Panel_Pot_18, lab_Eff_18, lab_Pot_18, Lab_keyitem_18.Text);
        }
        else
        {
            lab_gap18.Text = "N";
            lab_gap18.ForeColor = System.Drawing.Color.Blue;
            lab_Eff_18.Text = "--";
            lab_Pot_18.Text = "--";
        }

        if (lab_gap19.Text == "Y")
        {
            lab_gap19.Text = "Y";
            lab_gap19.ForeColor = System.Drawing.Color.Red;
            //keyitem_put_data(Panel_Eff_19, Panel_Pot_19, lab_Eff_19, lab_Pot_19, Lab_keyitem_19.Text);
            keyitem_put_data2(Panel_Lv_19, Panel_Eff_19, Panel_Pot_19, lab_Eff_19, lab_Pot_19, Lab_keyitem_19.Text);
        }

        else
        {
            lab_gap19.Text = "N";
            lab_gap19.ForeColor = System.Drawing.Color.Blue;
            lab_Eff_19.Text = "--";
            lab_Pot_19.Text = "--";
        }

        if (lab_gap20.Text == "Y")
        {
            lab_gap20.Text = "Y";
            lab_gap20.ForeColor = System.Drawing.Color.Red;
            keyitem_put_data2(Panel_Lv_20, Panel_Eff_20, Panel_Pot_20, lab_Eff_20, lab_Pot_20, Lab_keyitem_20.Text);
        }
        else
        {
            lab_gap20.Text = "N";
            lab_gap20.ForeColor = System.Drawing.Color.Blue;
            lab_Eff_20.Text = "--";
            lab_Pot_20.Text = "--";
        }

        if (lab_gap21.Text == "Y")
        {
            lab_gap21.Text = "Y";
            lab_gap21.ForeColor = System.Drawing.Color.Red;
            keyitem_put_data2(Panel_Lv_21, Panel_Eff_21, Panel_Pot_21, lab_Eff_21, lab_Pot_21, Lab_keyitem_21.Text);
        }
        else
        {
            lab_gap21.Text = "N";
            lab_gap21.ForeColor = System.Drawing.Color.Blue;
            lab_Eff_21.Text = "--";
            lab_Pot_21.Text = "--";
        }

        if (lab_gap22.Text == "Y")
        {
            lab_gap22.Text = "Y";
            lab_gap22.ForeColor = System.Drawing.Color.Red;

            keyitem_put_data2(Panel_Lv_22, Panel_Eff_22, Panel_Pot_22, lab_Eff_22, lab_Pot_22, Lab_keyitem_22.Text);
        }
        else
        {
            lab_gap22.Text = "N";
            lab_gap22.ForeColor = System.Drawing.Color.Blue;
            lab_Eff_22.Text = "--";
            lab_Pot_22.Text = "--";
        }

        if (lab_gap23.Text == "Y")
        {
            lab_gap23.Text = "Y";
            lab_gap23.ForeColor = System.Drawing.Color.Red;
            keyitem_put_data2(Panel_Lv_23, Panel_Eff_23, Panel_Pot_23, lab_Eff_23, lab_Pot_23, Lab_keyitem_23.Text);
        }
        else
        {
            lab_gap23.Text = "N";
            lab_gap23.ForeColor = System.Drawing.Color.Blue;
            lab_Eff_23.Text = "--";
            lab_Pot_23.Text = "--";
        }
        if (lab_gap24.Text == "Y")
        {
            lab_gap24.Text = "Y";
            lab_gap24.ForeColor = System.Drawing.Color.Red;
            keyitem_put_data2(Panel_Lv_24, Panel_Eff_24, Panel_Pot_24, lab_Eff_24, lab_Pot_24, Lab_keyitem_24.Text);
        }
        else
        {
            lab_gap24.Text = "N";
            lab_gap24.ForeColor = System.Drawing.Color.Blue;
            lab_Eff_24.Text = "--";
            lab_Pot_24.Text = "--";
        }

        if (lab_gap25.Text == "Y")
        {
            lab_gap25.Text = "Y";
            lab_gap25.ForeColor = System.Drawing.Color.Red;
            //keyitem_put_data(Panel_Eff_25, Panel_Pot_25, lab_Eff_25, lab_Pot_25, Lab_keyitem_25.Text);
            keyitem_put_data2(Panel_Lv_25, Panel_Eff_25, Panel_Pot_25, lab_Eff_25, lab_Pot_25, Lab_keyitem_25.Text);
        }
        else
        {
            lab_gap25.Text = "N";
            lab_gap25.ForeColor = System.Drawing.Color.Blue;
            lab_Eff_25.Text = "--";
            lab_Pot_25.Text = "--";
        }

        if (lab_gap26.Text == "Y")
        {
            lab_gap26.Text = "Y";
            lab_gap26.ForeColor = System.Drawing.Color.Red;
            keyitem_put_data2(Panel_Lv_26, Panel_Eff_26, Panel_Pot_26, lab_Eff_26, lab_Pot_26, Lab_keyitem_26.Text);
        }
        else
        {
            lab_gap26.Text = "N";
            lab_gap26.ForeColor = System.Drawing.Color.Blue;
            lab_Eff_26.Text = "--";
            lab_Pot_26.Text = "--";
        }

        if (lab_gap27.Text == "Y")
        {
            lab_gap27.Text = "Y";
            lab_gap27.ForeColor = System.Drawing.Color.Red;
            keyitem_put_data2(Panel_Lv_27, Panel_Eff_27, Panel_Pot_27, lab_Eff_27, lab_Pot_27, Lab_keyitem_27.Text);

        }
        else
        {
            lab_gap27.Text = "N";
            lab_gap27.ForeColor = System.Drawing.Color.Blue;
            lab_Eff_27.Text = "--";
            lab_Pot_27.Text = "--";
        }

        if (lab_gap28.Text == "Y")
        {
            lab_gap28.Text = "Y";
            lab_gap28.ForeColor = System.Drawing.Color.Red;
            keyitem_put_data2(Panel_Lv_28, Panel_Eff_28, Panel_Pot_28, lab_Eff_28, lab_Pot_28, Lab_keyitem_28.Text);
        }
        else
        {
            lab_gap28.Text = "N";
            lab_gap28.ForeColor = System.Drawing.Color.Blue;
            lab_Eff_28.Text = "--";
            lab_Pot_28.Text = "--";
        }

        if (lab_gap29.Text == "Y")
        {
            lab_gap29.Text = "Y";
            lab_gap29.ForeColor = System.Drawing.Color.Red;
            keyitem_put_data2(Panel_Lv_29, Panel_Eff_29, Panel_Pot_29, lab_Eff_29, lab_Pot_29, Lab_keyitem_29.Text);
        }
        else
        {
            lab_gap29.Text = "N";
            lab_gap29.ForeColor = System.Drawing.Color.Blue;
            lab_Eff_29.Text = "--";
            lab_Pot_29.Text = "--";
        }

        if (lab_gap30.Text == "Y")
        {
            lab_gap30.Text = "Y";
            lab_gap30.ForeColor = System.Drawing.Color.Red;
            //keyitem_put_data(Panel_Eff_30, Panel_Pot_30, lab_Eff_30, lab_Pot_30, Lab_keyitem_30.Text);
            keyitem_put_data2(Panel_Lv_30, Panel_Eff_30, Panel_Pot_30, lab_Eff_30, lab_Pot_30, Lab_keyitem_30.Text);
        }
        else
        {
            lab_gap30.Text = "N";
            lab_gap30.ForeColor = System.Drawing.Color.Blue;
            lab_Eff_30.Text = "--";
            lab_Pot_30.Text = "--";
        }

        if (lab_gap31.Text == "Y")
        {
            lab_gap31.Text = "Y";
            lab_gap31.ForeColor = System.Drawing.Color.Red;
            // keyitem_put_data(Panel_Eff_31, Panel_Pot_31, lab_Eff_31, lab_Pot_31, Lab_keyitem_31.Text);
            keyitem_put_data2(Panel_Lv_31, Panel_Eff_31, Panel_Pot_31, lab_Eff_31, lab_Pot_31, Lab_keyitem_31.Text);
        }
        else
        {
            lab_gap31.Text = "N";
            lab_gap31.ForeColor = System.Drawing.Color.Blue;
            lab_Eff_31.Text = "--";
            lab_Pot_31.Text = "--";
        }

        if (lab_gap32.Text == "Y")
        {
            lab_gap32.Text = "Y";
            lab_gap32.ForeColor = System.Drawing.Color.Red;
            keyitem_put_data2(Panel_Lv_32, Panel_Eff_32, Panel_Pot_32, lab_Eff_32, lab_Pot_32, Lab_keyitem_32.Text);
        }
        else
        {
            lab_gap32.Text = "N";
            lab_gap32.ForeColor = System.Drawing.Color.Blue;
            lab_Eff_32.Text = "--";
            lab_Pot_32.Text = "--";
        }

        if (lab_gap33.Text == "Y")
        {
            lab_gap33.Text = "Y";
            lab_gap33.ForeColor = System.Drawing.Color.Red;
            lab_Eff_33.Text = "--";
            lab_Pot_33.Text = "--";
        }
        else
        {
            lab_gap33.Text = "N";
            lab_gap33.ForeColor = System.Drawing.Color.Blue;
            lab_Eff_33.Text = "--";
            lab_Pot_33.Text = "--";
        }

        if (lab_gap34.Text == "Y")
        {
            lab_gap34.Text = "Y";
            lab_gap34.ForeColor = System.Drawing.Color.Red;
            keyitem_put_data2(Panel_Lv_34, Panel_Eff_34, Panel_Pot_34, lab_Eff_34, lab_Pot_34, Lab_keyitem_34.Text);
        }
        else
        {
            lab_gap34.Text = "N";
            lab_gap34.ForeColor = System.Drawing.Color.Blue;
            lab_Eff_34.Text = "--";
            lab_Pot_34.Text = "--";
        }

        if (lab_gap35.Text == "Y")
        {
            lab_gap35.Text = "Y";
            lab_gap35.ForeColor = System.Drawing.Color.Red;
            keyitem_put_data2(Panel_Lv_35, Panel_Eff_35, Panel_Pot_35, lab_Eff_35, lab_Pot_35, Lab_keyitem_35.Text);
        }
        else
        {
            lab_gap35.Text = "N";
            lab_gap35.ForeColor = System.Drawing.Color.Blue;
            lab_Eff_35.Text = "--";
            lab_Pot_35.Text = "--";
        }

        if (lab_gap36.Text == "Y")
        {
            lab_gap36.Text = "Y";
            lab_gap36.ForeColor = System.Drawing.Color.Red;
            keyitem_put_data2(Panel_Lv_36, Panel_Eff_36, Panel_Pot_36, lab_Eff_36, lab_Pot_36, Lab_keyitem_36.Text);
        }
        else
        {
            lab_gap36.Text = "N";
            lab_gap36.ForeColor = System.Drawing.Color.Blue;
            lab_Eff_36.Text = "--";
            lab_Pot_36.Text = "--";
        }

        if (lab_gap37.Text == "Y")
        {
            lab_gap37.Text = "Y";
            lab_gap37.ForeColor = System.Drawing.Color.Red;
            keyitem_put_data2(Panel_Lv_37, Panel_Eff_37, Panel_Pot_37, lab_Eff_37, lab_Pot_37, Lab_keyitem_37.Text);
        }
        else
        {
            lab_gap37.Text = "N";
            lab_gap37.ForeColor = System.Drawing.Color.Blue;
            lab_Eff_37.Text = "--";
            lab_Pot_37.Text = "--";
        }

        if (lab_gap38.Text == "Y")
        {
            lab_gap38.Text = "Y";
            lab_gap38.ForeColor = System.Drawing.Color.Red;
            keyitem_put_data2(Panel_Lv_38, Panel_Eff_38, Panel_Pot_38, lab_Eff_38, lab_Pot_38, Lab_keyitem_38.Text);
        }
        else
        {
            lab_gap38.Text = "N";
            lab_gap38.ForeColor = System.Drawing.Color.Blue;
            lab_Eff_38.Text = "--";
            lab_Pot_38.Text = "--";
        }

        if (lab_gap39.Text == "Y")
        {
            lab_gap39.Text = "Y";
            lab_gap39.ForeColor = System.Drawing.Color.Red;
            keyitem_put_data2(Panel_Lv_39, Panel_Eff_39, Panel_Pot_39, lab_Eff_39, lab_Pot_39, Lab_keyitem_39.Text);
        }
        else
        {
            lab_gap39.Text = "N";
            lab_gap39.ForeColor = System.Drawing.Color.Blue;
            lab_Eff_39.Text = "--";
            lab_Pot_39.Text = "--";
        }


        if (lab_gap40.Text == "Y")
        {
            lab_gap40.Text = "Y";
            lab_gap40.ForeColor = System.Drawing.Color.Red;
            keyitem_put_data2(Panel_Lv_40, Panel_Eff_40, Panel_Pot_40, lab_Eff_40, lab_Pot_40, Lab_keyitem_40.Text);
        }
        else
        {
            lab_gap40.Text = "N";
            lab_gap40.ForeColor = System.Drawing.Color.Blue;
            lab_Eff_40.Text = "--";
            lab_Pot_40.Text = "--";
        }


        if (lab_gap41.Text == "Y")
        {
            lab_gap41.Text = "Y";
            lab_gap41.ForeColor = System.Drawing.Color.Red;
            keyitem_put_data2(Panel_Lv_41, Panel_Eff_41, Panel_Pot_41, lab_Eff_41, lab_Pot_41, Lab_keyitem_41.Text);
        }
        else
        {

            lab_gap41.Text = "N";
            lab_gap41.ForeColor = System.Drawing.Color.Blue;
            lab_Eff_41.Text = "--";
            lab_Pot_41.Text = "--";
        }

        if (lab_gap42.Text == "Y")
        {
            lab_gap42.Text = "Y";
            lab_gap42.ForeColor = System.Drawing.Color.Red;
            keyitem_put_data2(Panel_Lv_42, Panel_Eff_42, Panel_Pot_42, lab_Eff_42, lab_Pot_42, Lab_keyitem_42.Text);
        }
        else
        {
            lab_gap42.Text = "N";
            lab_gap42.ForeColor = System.Drawing.Color.Blue;
            lab_Eff_42.Text = "--";
            lab_Pot_42.Text = "--";
        }

        if (lab_gap43.Text == "Y")
        {
            lab_gap43.Text = "Y";
            lab_gap43.ForeColor = System.Drawing.Color.Red;
            keyitem_put_data2(Panel_Lv_43, Panel_Eff_43, Panel_Pot_43, lab_Eff_43, lab_Pot_43, Lab_keyitem_43.Text);
        }
        else
        {
            lab_gap43.Text = "N";
            lab_gap43.ForeColor = System.Drawing.Color.Blue;
            lab_Eff_43.Text = "--";
            lab_Pot_43.Text = "--";
        }

        if (lab_gap44.Text == "Y")
        {
            lab_gap44.Text = "Y";
            lab_gap44.ForeColor = System.Drawing.Color.Red;
            keyitem_put_data2(Panel_Lv_44, Panel_Eff_44, Panel_Pot_44, lab_Eff_44, lab_Pot_44, Lab_keyitem_44.Text);
        }
        else
        {
            lab_gap44.Text = "N";
            lab_gap44.ForeColor = System.Drawing.Color.Blue;
            lab_Eff_44.Text = "--";
            lab_Pot_44.Text = "--";
        }

        if (lab_gap45.Text == "Y")
        {
            lab_gap45.Text = "Y";
            lab_gap45.ForeColor = System.Drawing.Color.Red;
            keyitem_put_data2(Panel_Lv_45, Panel_Eff_45, Panel_Pot_45, lab_Eff_45, lab_Pot_45, Lab_keyitem_44.Text);
        }
        else
        {
            lab_gap45.Text = "N";
            lab_gap45.ForeColor = System.Drawing.Color.Blue;
            lab_Eff_45.Text = "--";
            lab_Pot_45.Text = "--";
        }

        if (lab_gap46.Text == "Y")
        {
            lab_gap46.Text = "Y";
            lab_gap46.ForeColor = System.Drawing.Color.Red;
            keyitem_put_data2(Panel_Lv_46, Panel_Eff_46, Panel_Pot_46, lab_Eff_46, lab_Pot_46, Lab_keyitem_44.Text);
        }
        else
        {
            lab_gap46.Text = "N";
            lab_gap46.ForeColor = System.Drawing.Color.Blue;
            lab_Eff_46.Text = "--";
            lab_Pot_46.Text = "--";
        }


        if (lab_gap47.Text == "Y")
        {
            lab_gap47.Text = "Y";
            lab_gap47.ForeColor = System.Drawing.Color.Red;
            keyitem_put_data2(Panel_Lv_47, Panel_Eff_47, Panel_Pot_47, lab_Eff_47, lab_Pot_47, Lab_keyitem_44.Text);
        }
        else
        {
            lab_gap47.Text = "N";
            lab_gap47.ForeColor = System.Drawing.Color.Blue;
            lab_Eff_47.Text = "--";
            lab_Pot_47.Text = "--";

        }

        if (lab_gap48.Text == "Y")
        {
            lab_gap48.Text = "Y";
            lab_gap48.ForeColor = System.Drawing.Color.Red;
            keyitem_put_data2(Panel_Lv_48, Panel_Eff_48, Panel_Pot_48, lab_Eff_48, lab_Pot_48, Lab_keyitem_44.Text);
        }
        else
        {
            lab_gap48.Text = "N";
            lab_gap48.ForeColor = System.Drawing.Color.Blue;
            lab_Eff_48.Text = "--";
            lab_Pot_48.Text = "--";
        }

        if (lab_gap49.Text == "Y")
        {
            lab_gap49.Text = "Y";
            lab_gap49.ForeColor = System.Drawing.Color.Red;
            keyitem_put_data2(Panel_Lv_49, Panel_Eff_49, Panel_Pot_49, lab_Eff_49, lab_Pot_49, Lab_keyitem_44.Text);
        }
        else
        {
            lab_gap49.Text = "N";
            lab_gap49.ForeColor = System.Drawing.Color.Blue;
            lab_Eff_49.Text = "--";
            lab_Pot_49.Text = "--";
        }






        if (lab_gap51.Text == "Y")
        {
            lab_gap51.Text = "Y";
            lab_gap51.ForeColor = System.Drawing.Color.Red;
            keyitem_put_data2(Panel_Lv_51, Panel_Eff_51, Panel_Pot_51, lab_Eff_51, lab_Pot_51, Lab_keyitem_45.Text);
        }
        else
        {
            lab_gap51.Text = "N";
            lab_gap51.ForeColor = System.Drawing.Color.Blue;
            lab_Pot_51.Text = "--";
            lab_Eff_51.Text = "--";
        }

        if (lab_gap52.Text == "Y")
        {
            lab_gap52.Text = "Y";
            lab_gap52.ForeColor = System.Drawing.Color.Red;
            keyitem_put_data2(Panel_Lv_52, Panel_Eff_52, Panel_Pot_52, lab_Eff_52, lab_Pot_52, Lab_keyitem_45.Text);
        }
        else
        {
            lab_gap52.Text = "N";
            lab_gap52.ForeColor = System.Drawing.Color.Blue;
            lab_Eff_52.Text = "--";
            lab_Pot_52.Text = "--";
        }

        if (lab_gap53.Text == "Y")
        {
            lab_gap53.Text = "Y";
            lab_gap53.ForeColor = System.Drawing.Color.Red;
            keyitem_put_data2(Panel_Lv_53, Panel_Eff_53, Panel_Pot_53, lab_Eff_53, lab_Pot_53, Lab_keyitem_45.Text);
        }
        else
        {
            lab_gap53.Text = "N";
            lab_gap53.ForeColor = System.Drawing.Color.Blue;
            lab_Eff_53.Text = "--";
            lab_Pot_53.Text = "--";
        }

        if (lab_gap54.Text == "Y")
        {
            lab_gap54.Text = "Y";
            lab_gap54.ForeColor = System.Drawing.Color.Red;
            keyitem_put_data2(Panel_Lv_54, Panel_Eff_54, Panel_Pot_54, lab_Eff_54, lab_Pot_54, Lab_keyitem_45.Text);
        }
        else
        {
            lab_gap54.Text = "N";
            lab_gap54.ForeColor = System.Drawing.Color.Blue;
            lab_Eff_54.Text = "--";
            lab_Pot_54.Text = "--";
        }

        if (lab_gap55.Text == "Y")
        {
            lab_gap55.Text = "Y";
            lab_gap55.ForeColor = System.Drawing.Color.Red;
            keyitem_put_data2(Panel_Lv_55, Panel_Eff_55, Panel_Pot_55, lab_Eff_55, lab_Pot_55, Lab_keyitem_46.Text);
        }
        else
        {
            lab_gap55.Text = "N";
            lab_gap55.ForeColor = System.Drawing.Color.Blue;
            lab_Eff_55.Text = "--";
            lab_Pot_55.Text = "--";
        }

        if (lab_gap56.Text == "Y")
        {
            lab_gap56.Text = "Y";
            lab_gap56.ForeColor = System.Drawing.Color.Red;
            keyitem_put_data2(Panel_Lv_56, Panel_Eff_56, Panel_Pot_56, lab_Eff_56, lab_Pot_56, Lab_keyitem_47.Text);
        }
        else
        {
            lab_gap56.Text = "N";
            lab_gap56.ForeColor = System.Drawing.Color.Blue;
            lab_Eff_56.Text = "--";
            lab_Pot_56.Text = "--";
        }

        if (lab_gap57.Text == "Y")
        {
            lab_gap57.Text = "Y";
            lab_gap57.ForeColor = System.Drawing.Color.Red;
            keyitem_put_data2(Panel_Lv_57, Panel_Eff_57, Panel_Pot_57, lab_Eff_57, lab_Pot_57, Lab_keyitem_48.Text);
        }
        else
        {
            lab_gap57.Text = "N";
            lab_gap57.ForeColor = System.Drawing.Color.Blue;
            lab_Eff_57.Text = "--";
            lab_Pot_57.Text = "--";
        }

        if (lab_gap58.Text == "Y")
        {
            lab_gap58.Text = "Y";
            lab_gap58.ForeColor = System.Drawing.Color.Red;
            keyitem_put_data2(Panel_Lv_58, Panel_Eff_58, Panel_Pot_58, lab_Eff_58, lab_Pot_58, Lab_keyitem_49.Text);
        }
        else
        {
            lab_gap58.Text = "N";
            lab_gap58.ForeColor = System.Drawing.Color.Blue;
            lab_Eff_58.Text = "--";
            lab_Pot_58.Text = "--";
        }


        if (lab_gap59.Text == "Y")
        {
            lab_gap59.Text = "Y";
            lab_gap59.ForeColor = System.Drawing.Color.Red;
            keyitem_put_data2(Panel_Lv_59, Panel_Eff_59, Panel_Pot_59, lab_Eff_59, lab_Pot_59, Lab_keyitem_59.Text);
        }
        else
        {
            lab_gap59.Text = "N";
            lab_gap59.ForeColor = System.Drawing.Color.Blue;
            lab_Eff_59.Text = "--";
            lab_Pot_59.Text = "--";
        }


        if (lab_gap60.Text == "Y")
        {
            lab_gap60.Text = "Y";
            lab_gap60.ForeColor = System.Drawing.Color.Red;
            keyitem_put_data2(Panel_Lv_60, Panel_Eff_60, Panel_Pot_60, lab_Eff_60, lab_Pot_60, Lab_keyitem_60.Text);
        }
        else
        {
            lab_gap60.Text = "N";
            lab_gap60.ForeColor = System.Drawing.Color.Blue;
            lab_Eff_60.Text = "--";
            lab_Pot_60.Text = "--";
        }

        if (lab_gap61.Text == "Y")
        {
            lab_gap61.Text = "Y";
            lab_gap61.ForeColor = System.Drawing.Color.Red;
            keyitem_put_data2(Panel_Lv_61, Panel_Eff_61, Panel_Pot_61, lab_Eff_61, lab_Pot_61, Lab_keyitem_61.Text);
        }
        else
        {
            lab_gap61.Text = "N";
            lab_gap61.ForeColor = System.Drawing.Color.Blue;
            lab_Eff_61.Text = "--";
            lab_Pot_61.Text = "--";
        }

        if (lab_gap62.Text == "Y")
        {
            lab_gap62.Text = "Y";
            lab_gap62.ForeColor = System.Drawing.Color.Red;
            lab_Eff_62.Text = "--";
            lab_Pot_62.Text = "--";
        }
        else
        {
            lab_gap62.Text = "N";
            lab_gap62.ForeColor = System.Drawing.Color.Blue;
            lab_Eff_62.Text = "--";
            lab_Pot_62.Text = "--";
        }

        if (lab_gap63.Text == "Y")
        {
            lab_gap63.Text = "Y";
            lab_gap63.ForeColor = System.Drawing.Color.Red;
            lab_Eff_63.Text = "--";
            lab_Pot_63.Text = "--";
        }
        else
        {
            lab_gap63.Text = "N";
            lab_gap63.ForeColor = System.Drawing.Color.Blue;
            lab_Pot_63.Text = "--";
            lab_Eff_63.Text = "--";
        }

        if (lab_gap64.Text == "Y")
        {
            lab_gap64.Text = "Y";
            lab_gap64.ForeColor = System.Drawing.Color.Red;
            lab_Eff_64.Text = "--";
            lab_Pot_64.Text = "--";
        }
        else
        {
            lab_gap64.Text = "N";
            lab_gap64.ForeColor = System.Drawing.Color.Blue;
            lab_Eff_64.Text = "--";
            lab_Pot_64.Text = "--";
        }

        if (lab_gap65.Text == "Y")
        {
            lab_gap65.Text = "Y";
            lab_gap65.ForeColor = System.Drawing.Color.Red;
            lab_Eff_65.Text = "--";
            lab_Pot_65.Text = "--";
        }
        else
        {
            lab_gap65.Text = "N";
            lab_gap65.ForeColor = System.Drawing.Color.Blue;
            lab_Eff_65.Text = "--";
            lab_Pot_65.Text = "--";
        }

    }







    protected void Button_Cancel_Click(object sender, EventArgs e)
    {

    }
}