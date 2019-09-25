<%@ Page Title="" Language="C#" MasterPageFile="~/GoMaster.Master" AutoEventWireup="true" CodeBehind="AdminUpdate.aspx.cs" Inherits="COMP231_Group_Project.AdminUpdate" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="Script/bootstrap.min.css" rel="stylesheet" />
    <script src="Script/jquery-1.3.2.min.js"></script>
    <script src="Script/jquery.blockUI.js"></script>
    <link href="StyleSheet1.css" rel="stylesheet" />
    <script type="text/javascript">
        function BlockUI(elementID) {
            var prm = Sys.WebForms.PageRequestManager.getInstance();
            prm.add_beginRequest(function () {
                $("#" + elementID).block({
                    message: '<table align = "center"><tr><td>' +
             '<img src="loading.gif"/></td></tr></table>',
                    css: {},
                    overlayCSS: {
                        backgroundColor: '#000000', opacity: 0.6
                    }
                });
            });
            prm.add_endRequest(function () {
                $("#" + elementID).unblock();
            });
        }
        $(document).ready(function () {

            BlockUI("<%=pnlAddEdit.ClientID %>");
        $.blockUI.defaults.css = {};
    });
        function Hidepopup() {
            $find("popup").hide();
            return false;
        }
    </script>
        <div>
            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <asp:GridView ID="GridView1" runat="server" Width="700px"
                        AutoGenerateColumns="false" PageSize="5" HeaderStyle-BackColor="#6699ff" HeaderStyle-ForeColor="WhiteSmoke" AllowPaging="False">
                        <Columns>
                            <asp:BoundField DataField="StoreID" HeaderText="Store ID" HtmlEncode="true" />
                            <asp:BoundField DataField="ItemID" HeaderText="Item ID" HtmlEncode="true" />
                            <asp:BoundField DataField="ItemName" HeaderText="Item Name" HtmlEncode="true" />
                            <asp:BoundField DataField="Price" HeaderText="Price" HtmlEncode="true" />
                             <asp:BoundField DataField="Quantity" HeaderText="Quantity" HtmlEncode="true" />
                            <asp:TemplateField ItemStyle-Width="80px" HeaderText="Edit">
                                <ItemTemplate>
                                     <asp:LinkButton ID="lnkbtn" runat="server"  OnClick="Edit" CommandArgument='<%# Eval("_id") %>'>Edit</asp:LinkButton>&nbsp;&nbsp;
                                     <asp:LinkButton ID="lnkDel" runat="server"   OnClick="delete" CommandArgument='<%# Eval("_id") %>'>Delete</asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                     <asp:HiddenField ID="hdn" runat="server" />
                    <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="Add" CssClass="btn-success" Width="100px" />
                    <asp:Panel ID="pnlAddEdit" runat="server" CssClass="modalPopup" Style="display: none">
                        <asp:Label Font-Bold="true" ID="Label4" CssClass="lbl" runat="server" Text="Inventory Details"></asp:Label>
                        <br />
                        <table align="center" class="table">
                            <tr>
                                <td>
                                    <asp:Label ID="Label1" runat="server" Text="StoreID"></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="txtStoreId" CssClass="control-group info" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label2" runat="server" Text="Item ID" ></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="txtItemId" runat="server" CssClass="control-group info"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label3" runat="server" Text="Item Name"></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="txtItemName" runat="server" CssClass="control-group info"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label5" runat="server" Text="Price"></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="txtPrice" runat="server" CssClass="control-group info"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label6" runat="server" Text="Quantity"></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="txtQuantity" runat="server" CssClass="control-group info"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Button ID="btnSave" runat="server" Text="Save" CssClass="btn-primary"  OnClick="Save" />
                                </td>
                                <td>
                                    <asp:Button ID="btnCancel" runat="server" Text="Cancel" CssClass="btn-primary" OnClientClick="return Hidepopup()" />
                                </td>
                            </tr>
                        </table>
                    </asp:Panel>
                    <asp:LinkButton ID="lnkFake" runat="server"></asp:LinkButton>
                    <ajaxToolkit:ModalPopupExtender ID="popup" runat="server" DropShadow="false"
                        PopupControlID="pnlAddEdit" TargetControlID="lnkFake"
                        BackgroundCssClass="modalBackground">
                    </ajaxToolkit:ModalPopupExtender>
                </ContentTemplate>
                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="GridView1" />
                    <asp:AsyncPostBackTrigger ControlID="btnSave" />
                </Triggers>
            </asp:UpdatePanel>
        </div>
 </asp:Content>