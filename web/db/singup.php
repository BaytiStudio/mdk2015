<?php 
	include_once 'koneksi.php';

	$nama = $_POST['nama'];
	$no = $_POST['no_identitas'];
	$email = $_POST['email'];
	$password = $_POST['pass'];
	$level = $_POST['jenis'];
	$sql = "INSERT INTO user (no_identitas, email, nama, password, level, created_at)
		 VALUES ($no,'$email','$nama','$password','$level',now())";
	mysql_query($sql)or die(mysql_error());
	echo "<script>
				window.location.href='../index.php';
			</script>";
 ?>