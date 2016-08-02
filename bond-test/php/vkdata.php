<?php
$vkid = $_GET['vkuser'];

$txt = file_get_contents('../data_vk.txt');
$search = explode("\r\n", $txt);

if(in_array($vkid, $search)){
	echo 'naher vk';
}else{
$fp = fopen('../data_vk.txt','a');
$data = $vkid."\r\n";
$cp = fwrite($fp, $data);
     echo 'ok';
}
