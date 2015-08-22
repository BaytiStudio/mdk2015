<?php 

	require_once 'twitteroauth/twitteroauth.php';
	define('CONSUMER_KEY', 'kHhH8UuuqBUBOe3M1882zIgym'); //isikan dengan CONSUMER_KEY anda
	define('CONSUMER_SECRET', '1xwEc9I2qodTLr5SauCf99aNQzeieuQrf06vEjwmyJAAnHn2yv'); //isikan dengan CONSUMER_KEY anda
	define('ACCESS_TOKEN', '1607352589-V2G2Hi27eSzbhYaeIgotwKSpgnOZAYBZs6BohFh'); //isikan dengan CONSUMER_KEY anda
	define('ACCESS_TOKEN_SECRET', 'jn0RTR8aOl7NyHsNz0wZGiK8RLBAVTT8q6VnSYfct8v6d'); //isikan dengan CONSUMER_KEY anda


						

	function search($query)
	{
	  	$connection = new TwitterOAuth(CONSUMER_KEY, CONSUMER_SECRET, ACCESS_TOKEN, ACCESS_TOKEN_SECRET);
	  	return $connection->get('search/tweets', $query);
	  	// $statusMessage = 'Movie added: '.$title. ' -> ' . $message;
		// $tweet->post('statuses/update', array('status' => $statusMessage));
	}

	function getTrend()
	{
		$con = new TwitterOAuth(CONSUMER_KEY, CONSUMER_SECRET, ACCESS_TOKEN, ACCESS_TOKEN_SECRET);
		return $con->get('https://api.twitter.com/1.1/trends/place.json?id=1047378');
	}

	// $query = array(
	//   "q" => "jogja", // bisa #jogja atau @jogja
	//   "count"=>100
	// );

	// $results = search($query);
	// print_r($results);
	// foreach ($results->statuses as $result) {
	//   echo $result->user->screen_name . " => " . $result->text . "<br/><br/>";
	// }

}

/* End of file twiiter.php */
/* Location: ./application/libraries/twiiter.php */