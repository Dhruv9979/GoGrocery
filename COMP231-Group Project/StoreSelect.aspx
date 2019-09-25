<%@ Page Title="" Language="C#" MasterPageFile="~/GoMaster.Master" AutoEventWireup="true" CodeBehind="StoreSelect.aspx.cs" Inherits="COMP231_Group_Project.StoreSelect" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript">
    function Func() {
        alert("hello!")
    }
</script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       
        <h1>Hello</h1>
        <div class="parentDiv" style="position:absolute">
        <div id="storeDiv1">
            <asp:GridView ID="gridStore1" runat="server" AutoGenerateColumns="False" Width="275px" HeaderStyle-BackColor="#6699ff" HeaderStyle-ForeColor="WhiteSmoke" >
                <Columns>
                    <asp:BoundField DataField="ItemName" HeaderText="Name" />
                    <asp:BoundField DataField="Price" HeaderText="Price" />
                    <asp:BoundField DataField="Quantity" HeaderText="Quanity" />
                    <asp:TemplateField HeaderText="Select" >
                        <ItemTemplate>
                            <asp:TextBox ID="TextBox1" TextMode="Number" runat="server" min="0" max='<%# Eval("Quantity") %>'></asp:TextBox>
            </ItemTemplate>
                        </asp:TemplateField>
                </Columns>
            </asp:GridView>
            </div>
        <div id="storeDiv2">
            <asp:GridView ID="gridStore2" runat="server" AutoGenerateColumns="False" HeaderStyle-BackColor="#6699ff" HeaderStyle-ForeColor="WhiteSmoke">
                <Columns>
                    <asp:BoundField DataField="ItemName" HeaderText="Name" />
                    <asp:BoundField DataField="Price" HeaderText="Price" />
                    <asp:BoundField DataField="Quantity" HeaderText="Quanity" />
                    <asp:TemplateField HeaderText="Select" >
                        <ItemTemplate>
                            <asp:TextBox ID="TextBox1" TextMode="Number" runat="server" min="0" max='<%# Eval("Quantity") %>'></asp:TextBox>
            </ItemTemplate>
                        </asp:TemplateField>
                </Columns>

            </asp:GridView>
            </div>
        <div id="storeDiv3">
             <asp:GridView ID="gridStore3" runat="server" AutoGenerateColumns="False" HeaderStyle-BackColor="#6699ff" HeaderStyle-ForeColor="WhiteSmoke" >
                <Columns>
                    <asp:BoundField DataField="ItemName" HeaderText="Name" />
                    <asp:BoundField DataField="Price" HeaderText="Price" />
                    <asp:BoundField DataField="Quantity" HeaderText="Quanity" />
                    <asp:TemplateField HeaderText="Select" >
                        <ItemTemplate>
                            <asp:TextBox ID="TextBox1" TextMode="Number" runat="server" min="0" max='<%# Eval("Quantity") %>'></asp:TextBox>
            </ItemTemplate>
                        </asp:TemplateField>
                </Columns>

            </asp:GridView>
        </div>

         
            
        </div>
    <br />
    <br />
</asp:Content>
