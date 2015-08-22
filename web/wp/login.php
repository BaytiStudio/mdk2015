<?php 
	include_once '../db/koneksi.php';
	$email = "";
	$passwotd = "";

	$sql = "SELECT * FROM user WHERE email='' AND password=''";
	$result = mysql_query($sql)or die(mysql_error());
	if (mysql_num_rows($result)==1) {
		echo "1|Berhasil";
	} else {
		echo "0|Gagal";
	}
	

 ?>