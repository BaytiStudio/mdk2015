<?php if ( ! defined('BASEPATH')) exit('No direct script access allowed');

class Curl
{
  protected 	$ci;

	function __construct()
	{
        $this->ci =& get_instance();
	}

	function bacaHTML($url){
	    // inisialisasi CURL
	    $data = curl_init();
	    // setting CURL
	    curl_setopt($data, CURLOPT_RETURNTRANSFER, 1);
	    curl_setopt($data, CURLOPT_URL, $url);
	    curl_setopt($data, CURLOPT_HEADER, 0);
	    curl_setopt($data, CURLOPT_FOLLOWLOCATION, 1);
	    // menjalankan CURL untuk membaca isi file
	    $hasil = curl_exec($data);
	    curl_close($data);
    	return $hasil;
	}

	//membuat fungsi explode dengan multiple delimiter (pembatas)
	function explodeX( $delimiters, $string ){
	    return explode( chr( 1 ), str_replace( $delimiters, chr( 1 ), $string ) );
	}

	function gabung($array, $jumlah)
	{
		$data;
		for ($i=0; $i < jumlah; $i++) { 
			$data .=" ".$array[$i];
		}
		return $data;
	}

	

}

/* End of file curl.php */
/* Location: ./application/libraries/curl.php */
