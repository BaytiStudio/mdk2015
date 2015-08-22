 <?php 
	include_once '../db/koneksi.php';
	$id_propinsi = $_GET["p"];
	// $id_propinsi = 15;
	$sql = "SELECT * FROM inf_lokasi WHERE lokasi_propinsi=$id_propinsi AND lokasi_kabupatenkota!=0 AND lokasi_kecamatan=0 AND lokasi_kelurahan=0";
	$result = mysql_query($sql)or die(mysql_error());
	$arr = array();
	while ($hasil = mysql_fetch_array($result)) {
		$temp = array(
		    "lokasi_kabkota" => $hasil["lokasi_kabupatenkota"],
		    "lokasi_kode" => $hasil["lokasi_kode"], 
		    "lokasi_nama" => $hasil["lokasi_nama"]
		);
	    array_push($arr, $temp);
	}
	$data = json_encode($arr);

	echo "{\"list_kota\":" . $data . "}";


 ?>

