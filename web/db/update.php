<?php
	session_start(); 
	include_once 'koneksi.php';
	$user_id = $_SESSION['user_id'];
	$nama = $_POST['nama'];
	$email = $_POST['email'];
	$no_identitas = $_POST['no_identitas'];
	$jenis = $_POST['jenis'];
	$alamat = $_POST['alamat'];
	$sql ="UPDATE user SET nama='$nama', email='$email', no_identitas=$no_identitas, level='$jenis', alamat='$alamat' WHERE id=$user_id";
	mysql_query($sql)or die(mysql_error());
	echo "<script>
				window.location.href='../user/home.php';
			</script>";

 ?>