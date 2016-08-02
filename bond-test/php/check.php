<?php
$real_code = '555555';
$code = $_GET['code'];

if($code === $real_code){
	echo 'ok';
}

/*
$code = $_POST['code'];


if (isset($_POST["code"]) && !empty($_POST["code"])){
	if($code === $real_code){
		
		echo 'YES';

	}else{
		echo 'wrong code';
	}
}else{
	die();
}
*/