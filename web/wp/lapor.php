<?php 
	include_once '../db/koneksi.php';
	$nama = $_POST['sNama'];
	$no_identitas = $_POST['sKtp'];
	$email = $_POST['sUsername'];
	$password = $_POST['sPassword'];
	$jenis = $_POST['sJenis'];

	$sql = "INSERT INTO user (no_identitas, email, nama, password, level, created_at)
		 VALUES ($no_identitas,'$email','$nama','$password','$jenis',now())";
	$result = mysql_query($sql);
	if ($result) {
		echo "1|Berhasil Daftar";
	} else {
		echo "0|Gagal Daftar";
	}
	


 ?>