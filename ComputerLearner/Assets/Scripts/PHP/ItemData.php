<?php
	$servername = "fdb18.runhosting.com";
	$username = "2595479_3dit";
	$password = "papercut1";
	$dbName = "2595479_3dit";

	//make connection
	$conn = new mysqli($servername, $username, $password, $dbName);
	//check connection
	if(!$conn)
	{
		die("Connction Failed...". mysqli_connect_error());
	}
	
	$sql = "SELECT ID, Name, Type, Cost FROM items";
	$result = mysqli_query($conn ,$sql);

	if(mysqli_num_rows($result) > 0)
	{
		//show data for each row
		while($row = mysqli_fetch_assoc($result))
		{
			echo "ID:".$row['ID']."|Name:".$row['Name']."|Type:".$row['Type']. "|Cost:".$row['Cost'].";";
		}
	}
?>