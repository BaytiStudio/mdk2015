<?php 
	include_once '../db/koneksi.php';
	
	$id_propinsi = $_GET["p"];
	$id_kabkot = $_GET["k"];
	$sql = "SELECT * FROM inf_lokasi WHERE lokasi_propinsi=$id_propinsi AND lokasi_kabupatenkota=$id_kabkot AND lokasi_kecamatan!=0 AND lokasi_kelurahan=0";
	$result = mysql_query($sql)or die(mysql_error());

	$arr = array();
	while ($hasil = mysql_fetch_assoc($result)) {
		$temp = array(
		    "lokasi_kec" => $hasil["lokasi_kecamatan"],
		    "lokasi_kode" => $hasil["lokasi_kode"], 
		    "lokasi_nama" => $hasil["lokasi_nama"],
		);
	    array_push($arr, $temp);
	}
	$data = json_encode($arr);

	echo "{\"list_kecamatan\":" . $data . "}";

 ?>