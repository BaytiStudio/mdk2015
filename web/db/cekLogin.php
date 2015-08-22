<?php 

	include_once 'koneksi.php';
	$email = $_POST["email"];
	$password = $_POST["pass"];

		$sql = "SELECT * FROM user WHERE email='$email' AND password='$password'";
	$result = mysql_query($sql)or die(mysql_error());
	if (mysql_num_rows($result)==1) {
		echo "<script>
				window.location.href='../user/home.php';
			</script>";
	} else {
		echo "<script>
				window.location.href='../index.php';
			</script>";
	} 

 ?>