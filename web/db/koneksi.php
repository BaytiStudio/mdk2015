<?php 

	$database_host = "localhost";
	$database_name = "u961088667_mdk";
	$database_user = "u961088667_root";
	$database_pass = "Bismillah";

	mysql_connect($database_host, $database_user, $database_pass) or die("Error on database connecction\n".mysql_error());
	mysql_select_db($database_name) or die("Error on database selection\n".mysql_error());
 ?>