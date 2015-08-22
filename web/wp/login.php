<?php 
	include_once '../db/koneksi.php';
	$email = $_POST['sUsername'];
	$passwotd = $_POST['sPassword'];

	$sql = "SELECT * FROM user WHERE email='$email' AND password='$password'";
	$result = mysql_query($sql)or die(mysql_error());
	if (mysql_num_rows($result)==1) {
		echo "1|Berhasil";
	} else {
		echo "0|Gagal";
	}
	

 ?>