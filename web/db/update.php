<?php 

	$sql ="UPDATE ";
	mysql_query($sql)or die(mysql_error());
	echo "<script>
				window.location.href='home.php';
			</script>";

 ?>