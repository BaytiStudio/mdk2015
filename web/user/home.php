<?php
  include_once '../db/koneksi.php';
  include_once '../lib/curl.php';
 ?>
<!doctype html>
<html lang="en">
<head>
	<meta charset="utf-8" />
	<meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1" />
    <title>MDK</title>

    <link href="../bootstrap3/css/bootstrap.css" rel="stylesheet" />
	<link href="../assets/css/get-shit-done.css" rel="stylesheet" />
    <link href="../assets/css/demo.css" rel="stylesheet" />

    <!--     Font Awesome     -->
    <link href="../bootstrap3/css/font-awesome.css" rel="stylesheet">
    <link href='http://fonts.googleapis.com/css?family=Grand+Hotel' rel='stylesheet' type='text/css'>

</head>

<body>
    <div class="main">
        <div class="container-fluid">
          <div id="navbar">
                        <nav class="navbar navbar-ct-red">
                          <div class="container-fluid">
                            <!-- Brand and toggle get grouped for better mobile display -->
                            <div class="navbar-header">
                              <button type="button" class="navbar-toggle" data-toggle="collapse" data-target="#bs-example-navbar-collapse-1">
                                <span class="sr-only">Toggle navigation</span>
                                <span class="icon-bar"></span>
                                <span class="icon-bar"></span>
                                <span class="icon-bar"></span>
                              </button>
                              <a class="navbar-brand" href="home.php">Qomo</a>
                            </div>

                            <!-- Collect the nav links, forms, and other content for toggling -->
                            <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1">
                              <ul class="nav navbar-nav">
                                <li><a href="home.php">Home</a></li>
                                <li><a href="?module=lapor">Lapor</a></li>
                                <li><a href="?module=profil">Profil</a></li>
                                <li><a href="?module=reward">Reward</a></li>
                                <li><a href="../about.php">About</a></li>
                              </ul>
                              <ul class="nav navbar-nav navbar-right">

																<li><a href="#">Logout</a></li>

                                <li style="margin-top:23px;margin-right:20px;">
                                  <form class="" action="" method="post" role="search">
                                      <i class="fa fa-search" style="color:white;"></i>
                                      <input type="text" name="" placeholder=" Search..." style="outline: 0;border:0px;">
                                  </form>
                                </li>

                              </ul>
                            </div><!-- /.navbar-collapse -->
                          </div><!-- /.container-fluid -->
                        </nav>

                    </div>

				        </div>
                <?php
                if (isset($_GET['module'])) {
                  include "../user/$_GET[module].php";
                  # code...
                }
                else {
                  # code...
                  include "../data.php";
                }

                 ?>
    </div>


</body>

    <script src="../jquery/jquery-1.10.2.js" type="text/javascript"></script>
	<script src="../assets/js/jquery-ui-1.10.4.custom.min.js" type="text/javascript"></script>

	<script src="../bootstrap3/js/bootstrap.js" type="text/javascript"></script>
	<script src="../assets/js/gsdk-checkbox.js"></script>
	<script src="../assets/js/gsdk-radio.js"></script>
	<script src="../assets/js/gsdk-bootstrapswitch.js"></script>
	<script src="../assets/js/get-shit-done.js"></script>

    <script src="../assets/js/custom.js"></script>
    <script src="../assets/js/ajax_kota.js"></script>
</html>
