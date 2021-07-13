<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QueryList.aspx.cs" Inherits="DataV4.V4.Query.QueryList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            表名：<input type="text" id="tablename" runat="server" />
            交易平台编号（SYSTEM_NO）：<input type="text" id="system_no" runat="server" />
            type：<select id="type" runat="server">
                <option value="1">通用</option>
                <option value="2">专项</option>
            </select>
            <button id="submit" value="查询" runat="server" OnServerClick="submit_OnServerClick">查询</button>
        </div>
        <div runat="server" id="result"></div>
    </form>
</body>
</html>
