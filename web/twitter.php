<?php 

	require_once 'lib/twitteroauth/twitteroauth.php';
	define('CONSUMER_KEY', 'kHhH8UuuqBUBOe3M1882zIgym'); //isikan dengan CONSUMER_KEY anda
	define('CONSUMER_SECRET', '1xwEc9I2qodTLr5SauCf99aNQzeieuQrf06vEjwmyJAAnHn2yv'); //isikan dengan CONSUMER_KEY anda
	define('ACCESS_TOKEN', '1607352589-V2G2Hi27eSzbhYaeIgotwKSpgnOZAYBZs6BohFh'); //isikan dengan CONSUMER_KEY anda
	define('ACCESS_TOKEN_SECRET', 'jn0RTR8aOl7NyHsNz0wZGiK8RLBAVTT8q6VnSYfct8v6d'); //isikan dengan CONSUMER_KEY anda

	$connection = new TwitterOAuth(CONSUMER_KEY, CONSUMER_SECRET, ACCESS_TOKEN, ACCESS_TOKEN_SECRET);
	$query = array(
	  "q" => "Harga Beras", // bisa #jogja atau @jogja
	  // "geocode" => "-6.121435, 106.774124, 50",
	  "count"=>100
	);
	$results = $connection->get('search/tweets', $query);
  	print_r($results);

  	foreach ($results->statuses as $result) {
	  echo $result->user->screen_name . " => " . $result->text . "<br/><br/>";
	}
 ?>