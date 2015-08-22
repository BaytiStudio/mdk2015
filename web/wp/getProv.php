<?php 
	include_once '../db/koneksi.php';
	
	$sql = "SELECT * FROM inf_lokasi WHERE lokasi_kabupatenkota=0 AND lokasi_kecamatan=0 AND lokasi_kelurahan=0";
	$result = mysql_query($sql)or die(mysql_error());
	$arr = array();
	while ($hasil = mysql_fetch_array($result)) {
		$temp = array(
		    "lokasi_prov" => $hasil["lokasi_propinsi"],
		    "lokasi_kode" => $hasil["lokasi_kode"], 
		    "lokasi_nama" => $hasil["lokasi_nama"]
		);
	    array_push($arr, $temp);
	}
	$data = json_encode($arr);

	echo "{\"list_provinsi\":" . $data . "}";


 ?>

