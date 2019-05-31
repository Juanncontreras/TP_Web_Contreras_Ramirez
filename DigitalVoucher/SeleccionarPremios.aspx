<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SeleccionarPremios.aspx.cs" Inherits="DigitalVoucher.SeleccionarPremios" %>

<!DOCTYPE html>


 <html class="no-js" runat ="server" > 
	<head>
	<meta charset="utf-8">
	<meta http-equiv="X-UA-Compatible" content="IE=edge">
	<title>Nitro &mdash; Free HTML5 Bootstrap Website Template by FreeHTML5.co</title>
	<meta name="viewport" content="width=device-width, initial-scale=1">
	<meta name="description" content="Pagina para seleccionar uno de los premios obtenidos " />
	<meta name="author" content="Ariel y Juan" />


	<link href='https://fonts.googleapis.com/css?family=Roboto:400,300,600,400italic,700' rel='stylesheet' type='text/css'>
	<link href='https://fonts.googleapis.com/css?family=Montserrat:400,700' rel='stylesheet' type='text/css'>
	
	<!-- Animate.css -->
	<link rel="stylesheet" href="css/animate.css">
	<!-- Icomoon Icon Fonts-->
	<link rel="stylesheet" href="css/icomoon.css">
	<!-- Bootstrap  -->
	<link rel="stylesheet" href="css/bootstrap.css">
	<!-- Owl Carousel -->
	<link rel="stylesheet" href="css/owl.carousel.min.css">
	<link rel="stylesheet" href="css/owl.theme.default.min.css">
	<!-- Theme style  -->
	<link rel="stylesheet" href="css/style.css">

	<!-- Modernizr JS -->
	<script src="js/modernizr-2.6.2.min.js"></script>

	</head>
	<body>
	
       
  <div class="icon-align-justify animate-box" data-animate-effect="fadeInLeft">
      
    <img  src="images/DigitalVoucher.png" alt="logo" >
       <h1 class="fh5co-heading animate-box text-center text-primary" data-animate-effect="fadeInLeft" >PREMIOS</h1>

      </div>

		<form id="form1" runat="server">
        

	<div id="fh5co-main">
                  
			<div class="fh5co-narrow-content  ">
                
				<h2 class="fh5co-heading animate-box" data-animate-effect="fadeInLeft">Click en la imagen..<span> y a disfrutar! </span></h2>
				<div class="row animate-box" data-animate-effect="fadeInLeft">
					<div class="col-md-4 col-sm-6 col-xs-6 col-xxs-12 work-item">
						<a >
                            <asp:ImageButton ID="ibMonitorMac" runat="server" src="/Images/mac-screen.jpg" alt="Premio1" Cssclass="img-responsive" OnClick="ibMonitorMac_Click" Width="400" height="300" />
							<h3 class="fh5co-work-title">Monitor MAC  </h3>
                           
                            <p >Hacete un maraton de series, en ultra HD</p>
                            
						</a>
                        <div class="clearfix visible-sm-block"></div>
					</div>
					<div class="col-md-4 col-sm-6 col-xs-6 col-xxs-12 work-item">
						<a >
                            <asp:ImageButton ID="ibPS4" runat="server" src="/Images/ps4.jpg" alt="Premio2" Cssclass="img-responsive"  OnClick="ibPS4_Click"  Width="400" height="300"/>
							<h3 class="fh5co-work-title"> PS4 Sony</h3>
							<p >Vicea como un campeon! Siempre PES!</p>
						</a>
					</div>
					<div class="clearfix visible-sm-block"></div>
					<div class="col-md-4 col-sm-6 col-xs-6 col-xxs-12 work-item">
						<a>
                            <asp:ImageButton ID="ibMiniComponente" runat="server" src="/Images/minicomponente.jpg" alt="Premio3" Cssclass="img-responsive"  OnClick="ibMiniComponente_Click"  Width="400" height="300"/>
							<h3 class="fh5co-work-title">Minicomponente</h3>
							<p>Rompe todo, a todo volumen, siempre ROCK!</p>
						</a>
					</div>
					<div class="clearfix visible-md-block"></div>
					<div class="col-md-4 col-sm-6 col-xs-6 col-xxs-12 work-item">
						<a >
                            <asp:ImageButton ID="ibLenovo" runat="server" src="/Images/lenovo.jpg" alt="Premio4" Cssclass="img-responsive"  OnClick="ibLenovo_Click"  Width="400" height="300"/>
							<h3 class="fh5co-work-title">Notebook i3 Lenovo</h3>
							<p>Codea como un campeon, siempre LINUX!</p>
						</a>
					</div>
					 <div class="clearfix visible-md-block"></div>
					</div>
					
					
				</div>
			</div>

    </form>

	<!-- jQuery -->
	<script src="js/jquery.min.js"></script>
	<!-- jQuery Easing -->
	<script src="js/jquery.easing.1.3.js"></script>
	<!-- Bootstrap -->
	<script src="js/bootstrap.min.js"></script>
	<!-- Carousel -->
	<script src="js/owl.carousel.min.js"></script>
	<!-- Stellar -->
	<script src="js/jquery.stellar.min.js"></script>
	<!-- Waypoints -->
	<script src="js/jquery.waypoints.min.js"></script>
	<!-- Counters -->
	<script src="js/jquery.countTo.js"></script>
	
	
	<!-- MAIN JS -->
	<script src="js/main.js"></script>

	</body>
</html>
