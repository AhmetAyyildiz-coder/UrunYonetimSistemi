<%@ Page Title="Kategori Yonetimi" Language="C#" MasterPageFile="~/MainSablon.Master" AutoEventWireup="true" CodeBehind="KategoriYonetimi.aspx.cs" Inherits="UrunYonetimiStokTakip.WebFormUI.WebForm2" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }

        .auto-style2 {
            height: 28px;
        }

        .auto-style3 {
            width: 357px;
        }

        .auto-style4 {
            height: 28px;
            width: 357px;
        }

        .buttonGroup {
            height: 28px;
            width: 357px;
        }

        .auto-style5 {
            height: 28px;
            width: 528px;
            display: flex;
            justify-content: space-between;
        }
        #lblUyarı{
          color:red;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyContent" runat="server">
    <div>
        <h1>Kategori Yonetimi</h1>
    </div>
    <hr />
    <div id="contextDiv">
        <asp:GridView ID="GridView1" runat="server" OnRowUpdated="GridView1_RowUpdated"></asp:GridView>
        <table class="auto-style1">
            <tr>
                <td id="kategoriAdi" class="auto-style3">Kategori Adı</td>
                <td>
                    <asp:TextBox ID="txtBoxKategoriAdi" runat="server" Height="24px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td id="kategoriAciklama" class="auto-style4">Kategori Aciklama</td>
                <td class="auto-style2">
                    <asp:TextBox ID="txtBoxKategoriAciklama" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>
                    <asp:CheckBox ID="cbDurum" runat="server" Text="Durum" />
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Eklenme Tarihi</td>
                <td>
                    <asp:Label ID="lblTarih" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="lblUyarı" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <div class="auto-style5">
            <asp:Button ID="btnEkle" runat="server" Text="Ekle" Width="127px" OnClick="btnEkle_Click" />
            <asp:Button ID="btnGuncelle" runat="server" Text="Guncelle" Width="123px" OnClick="btnGuncelle_Click" />
            <asp:Button ID="btnSil" runat="server" Text="Sil" Width="140px" BorderColor="#CC99FF" OnClick="btnSil_Click" />
        </div>

    </div>
</asp:Content>
