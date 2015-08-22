<?php
defined('BASEPATH') OR exit('No direct script access allowed');

class Demo
{
	public function __construct()
	{
        require_once __DIR__ . '/autoload.php';
		$sentiment = new \PHPInsight\Sentiment();
	}

	function getSentimentClass($hasil)
	{
			$sentiment = new \PHPInsight\Sentiment();
			// calculations:
			$scores = $sentiment->score($hasil);
			$class = $sentiment->categorise($hasil);

			if ($class=='neg') {
				$class='buruk';
			}elseif ($class=='pos') {
				$class='baik';
			}elseif ($class=='neu') {
				$class='netral';
			}
			// output:
			// echo "String: $hasil\n";
			// echo "Dominant: $class, scores: ";
			// print_r($scores);
			// echo "\n";
			return $class;
	}

}

/* End of file demo.php */
/* Location: ./application/libraries/demo.php */
