<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="DigitalVoucher.Index" %>

<!DOCTYPE html>

<html lang="en">
    <head runat="server">

    <meta http-equiv="content-type" content ="text/html;charset=utf-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <meta name="description" content="Pagina para canjear vouchers">
    <meta name="author" content="">

    <title>Digital Voucher</title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">

    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js" integrity="sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js" integrity="sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM" crossorigin="anonymous"></script>


    <link href="https://fonts.googleapis.com/css?family=Mandali&display=swap" rel="stylesheet">
  </head>

 <body class="text-center">

    <form class="form-signin" id ="Form1" runat ="server">
      <img class="mb-4" src="https://image.winudf.com/v2/image1/Y29tLmRpZ2l0YWwuZGlnaXRhbHZvdWNoZXJfaWNvbl8xNTUzNDM5MjEwXzA5OA/icon.png?w=170&fakeurl=1" alt="" width="140" height="140">
      <h1 style="font-family :'Mandali', sans-serif">Voucher</h1>
        <asp:Label  CssClass="sr-only" ID="lblCodigoVoucher" runat="server" Text="Codigo voucher"></asp:Label>
        <asp:TextBox ID="txbCodigoVoucher" runat="server" Cssclass="form-control" placeholder="Codigo de voucher" type="text" ></asp:TextBox>
        
        
        <div>
        <asp:Button   ID="btIngresarVoucher" runat="server" Text="Ingresar Voucher" CssClass="btn btn-lg btn-primary btn-block" OnClick="btIngresarVoucher_Click" />
            </div>
   
    </form>

</body></html>