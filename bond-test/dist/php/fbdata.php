<?php

$fbid = $_GET['fbuser'];

$txt = file_get_contents('../data.txt');
$search = explode("\r\n", $txt);

if(in_array($fbid, $search)){
	echo 'naher';
}else{
$fp = fopen('../data.txt','a');
$data = $fbid."\r\n";
$cp = fwrite($fp, $data);
     echo 'ok';
}





//echo $fbid;