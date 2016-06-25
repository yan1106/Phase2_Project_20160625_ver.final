<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EPTRA_TRA_SignOff.aspx.cs" Inherits="EPTRA_TRA_SignOff" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<link href="../css/styles.css" rel="stylesheet" type="text/css" />
<link rel="stylesheet" href="//code.jquery.com/ui/1.11.4/themes/smoothness/jquery-ui.css" />
<link rel="stylesheet" href="http://code.jquery.com/ui/1.9.0/themes/base/jquery-ui.css" />    
<script src="http://code.jquery.com/jquery-1.8.2.js"></script>    
<script src="http://code.jquery.com/ui/1.9.0/jquery-ui.js"></script>
    <script type="text/javascript">



        var text_val;
        function AddWork_acc() {
       
            $(function () {
            
                document.getElementById("TextBox1").style.display = "block";

                $("#dialog").dialog({
                    autoOpen: false,
                    width: 350,
                    height: 400,
                    title: "簽核人建議(接受)",              
                    modal: true,/*background disable*/
                    buttons: {
                        "確認": function () {
                            if (confirm("你確定將Command送出?")) {
                                text_val = document.getElementById("TextBox1").value;
                                document.getElementById('hf_command_value').value = text_val;
                                __doPostBack('cmdFilter', '')
                                $(this).dialog("close");
                            }
                        },
                        "取消": function () {
                            $(this).dialog("close");
                        }
                    }




                });
            
                $("#dialog").dialog("open");
                return false;

            

            });
         
        }




        function AddWork_rej() {

            $(function () {

                document.getElementById("TextBox1").style.display = "block";

                $("#dialog").dialog({
                    autoOpen: false,
                    width: 350,
                    height: 400,
                    title: "簽核人建議(拒絕)",
                    modal: true,/*background disable*/
                    buttons: {
                        "確認": function () {

                            if (confirm("你確定將Command送出?")) {
                                text_val = document.getElementById("TextBox1").value;
                                document.getElementById('hf_command_value').value = text_val;
                                __doPostBack('cmdFilter', '')
                                $(this).dialog("close");
                            }
                        },
                        "取消": function () {
                            $(this).dialog("close");
                        }
                    }




                });

                $("#dialog").dialog("open");
                return false;



            });

        }
 </script>
    
    
    
        
    <title>TRA_SignOff</title>
</head>
<body>
    <form id="form1" runat="server">
         <asp:Label ID="lblError" runat="server" ForeColor="Red" Font-Size="Large"></asp:Label>
    <div style="width:60%;">
                   
                <fieldset style="margin:auto;" class="fieldset">
                <legend class="legend" style="font-size:medium;"><strong>TRA_SignOff</strong></legend>
               <table cellpadding="2" cellspacing="2">
                    
                  <tr>
                   <th >Customer:</th>
                        <td  class="td_newDevice"><asp:TextBox ID="Customer_TB" runat="server" Height="20px" 
                                  Width="160px"></asp:TextBox></td>
                         <th >New_Device:</th>
                        <td class="td_newDevice">
                            <asp:TextBox ID="ND_TB" runat="server" Height="20px" 
                            Width="160px"></asp:TextBox>
                        </td>
                         <th >
                             <asp:Button ID="Search_Lv" runat="server" class="blueButton button2" 
                                Height="25px"  Text="Search" Width="90px" OnClick="Search_Lv_Click1" />

                         </th>                                                                                      
                    </tr>
                </table>
            </fieldset>

        <asp:HiddenField ID="hf_command_value" runat="server" Value="1" />
        <asp:HiddenField ID="Lv_sign" runat="server" Value="f" />
        <br />


        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        
        <br />
        </div>

         <div>
            <asp:Panel ID="Panel_gv1" runat="server">
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" OnRowCommand="GridView1_RowCommand">
                <Columns>
                    <asp:TemplateField HeaderText="內容">
                        <ItemTemplate>
                             <asp:ImageButton ID="ImageButton_View" runat="server" CommandArgument="<%# ((GridViewRow) Container).RowIndex %>" CommandName="View" ImageUrl="icon/view.png" />
                            
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="狀態">
                              <ItemTemplate>
                                  <asp:Label ID="Label_sta" runat="server" ></asp:Label>
                              </ItemTemplate>              
                    </asp:TemplateField>
                    <asp:BoundField HeaderText="EPTRAName" DataField="Ver_Name" />
                    <asp:BoundField HeaderText="Ver" DataField="Ver_No" />
                    <asp:BoundField HeaderText="送審人員" DataField="Signoff_SendName" />
                    <asp:BoundField HeaderText="送審時間" DataField="Signoff_SendTime" />
                    <asp:TemplateField HeaderText="審核">
                            <ItemTemplate>                             
                                <asp:Button ID="butt_Acc"  runat="server" Text="Accept" CommandName="Acc"   OnClick="butt_Acc_Click1" />
                                <asp:Button ID="butt_Rej" runat="server" Text="Rejcet" CommandName="Rej"   OnClick="butt_Rej_Click"/>                              
                            </ItemTemplate>

                    </asp:TemplateField>
                    
                </Columns>
                <FooterStyle BackColor="White" ForeColor="#000066" />
                <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" Height="40" />
                <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                <RowStyle ForeColor="#000066" />
                <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#007DBB" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#00547E" />
            </asp:GridView>
          </asp:Panel>
            <asp:Button ID="cmdFilter" runat="server"  Text="Button" ClientIDMode="Static" Style="display: none;"    OnClick="cmdFilter_Click1"/>
        
        <asp:Panel ID="Panel_gv2" runat="server">
        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" OnRowCommand="GridView2_RowCommand">
            <Columns>
               <asp:TemplateField HeaderText="內容">
                        <ItemTemplate>
                             <asp:ImageButton ID="ImageButton_View" runat="server" CommandArgument="<%# ((GridViewRow) Container).RowIndex %>" CommandName="View" ImageUrl="icon/view.png" />
                        </ItemTemplate>
                    </asp:TemplateField>
                <asp:TemplateField HeaderText="狀態">
                              <ItemTemplate>
                                  <asp:Label ID="Label_sta" runat="server" ></asp:Label>
                              </ItemTemplate>              
                </asp:TemplateField>
                <asp:BoundField HeaderText="EPTRAName" DataField="Ver_Name" />
                <asp:BoundField HeaderText="Ver" DataField="Ver_No" />
                <asp:BoundField HeaderText="送審人員" DataField="Signoff_SendName" />
                <asp:BoundField HeaderText="送審時間" DataField="Signoff_SendTime" />
                <asp:BoundField HeaderText="審核人員" DataField="Signoff_Name" />
                <asp:BoundField HeaderText="審核時間" DataField="Signoff_Time" />
                <asp:BoundField HeaderText="審核意見" DataField="Signoff_Command" />
                
                  
            </Columns>
            
            <FooterStyle BackColor="White" ForeColor="#000066" />
            <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White"  Height="40"/>
            <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
            <RowStyle ForeColor="#000066" />
            <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#007DBB" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#00547E" />
        </asp:GridView>
      </asp:Panel>
    </div>



        <div id="dialog" >

            
        <asp:TextBox ID="TextBox1" runat="server" Height="200px" TextMode="MultiLine" Width="300px"  Columns="20" Rows="5" style="display:none;"></asp:TextBox>
            
                             
        </div>





    </form>
</body>
</html>
