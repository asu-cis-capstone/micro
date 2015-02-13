<?php
include_once("connect.php");

$q = strtolower($_GET["term"]);
$query=mysql_query("select * from art where title like '$q%' limit 0,10");

while ($row=mysql_fetch_array($query)) {
	$result[] = array(
		    'id' => $row['id'],
		    'label' => $row['title']
	);
}
echo json_encode($result);
?>