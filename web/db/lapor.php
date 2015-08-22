<?php 

	include_once 'koneksi.php';
	$pasar = $_POST['nama_pasar'];
	$komoditas = $_POST['nama_komoditas'];
	$jenis_komoditas = $_POST['jenis_komoditas'];
	$provinsi = $_POST['prop'];
	$kota = $_POST['kota'];
	$kecamatan = $_POST['kec'];
	$kelurahan = $_POST['kel'];
	$harga = $_POST['harga'];

	$sql = "INSERT INTO harga_komoditas (nama_pasar, nama_komoditas, jenis_komoditas, id_propinsi, id_kabkota, id_kecamatan, id_kelurahan, harga, create_at)
			VALUES ('$pasar','$komoditas','jenis_komoditas','$provinsi','$kota','$kecamatan','$kelurahan',$harga,now())";
	mysql_query($sql)or die(mysql_error());
	echo "<script>
				window.location.href='../user/index.php';
			</script>";
 ?>