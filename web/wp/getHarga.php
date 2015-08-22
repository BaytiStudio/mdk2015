<?php 

	include_once '../db/koneksi.php';

	if (@$_GET['p']) {
		$sql = "SELECT * FROM inf_lokasi WHERE lokasi_propinsi=$id_propinsi AND lokasi_kabupatenkota!=0 AND lokasi_kecamatan=0 AND lokasi_kelurahan=0";
	} 

	if (@$_GET['p']&&@$_GET['k']) {
		$sql = "SELECT * FROM inf_lokasi WHERE lokasi_propinsi=$id_propinsi AND lokasi_kabupatenkota=$id_kabkot AND lokasi_kecamatan!=0 AND lokasi_kelurahan=0";
	} 

	if (@$_GET['p']&&@$_GET['k']&&@$_GET['kec']) {
		$sql = "SELECT * FROM inf_lokasi WHERE lokasi_propinsi=$id_propinsi AND lokasi_kabupatenkota=$id_kabkot AND lokasi_kecamatan=$id_kec AND lokasi_kelurahan!=0";
	} 

	
	
 ?>