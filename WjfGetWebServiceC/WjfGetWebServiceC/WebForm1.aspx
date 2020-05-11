<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WjfGetWebServiceC.WebForm1" %>
<%--<%@ Import Namespace="WjfGetWebServiceC.WjfWebService" %>--%>
<%@ Import Namespace="WjfGetWebServiceC.WjfWebService" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Value1:<asp:TextBox ID="txtValue1" runat="server"></asp:TextBox>
            Value2:<asp:TextBox ID="txtValue2" runat="server"></asp:TextBox><br />
            Multiple:<asp:TextBox ID="txtMultiple" runat="server"></asp:TextBox><br />
            <asp:Button ID="btnOk" runat="server" Text="WebService" OnClick="btnOk_Click"></asp:Button>
        </div>
    </form>
</body>
</html>
<script runat="server">
    protected void btnOk_Click(object sender, System.EventArgs e){
        WjfGetWebServiceC.WjfWebService.WebService1 wjfWebService = new WjfGetWebServiceC.WjfWebService.WebService1();
        int i = Convert.ToInt32(txtValue1.Text);
        int j = Convert.ToInt32(txtValue2.Text);
        txtMultiple.Text = wjfWebService.Multiple(i, j).ToString();
    }
</script>
