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
	
	
    $insertedUsername = $_POST['username'];
	$sql = "SELECT Lesson FROM users WHERE username = '".$insertedUsername."'";
	$result = mysqli_query($conn ,$sql);

	//show user lesson data
	if(mysqli_num_rows($result) > 0)
	{
		while($row = mysqli_fetch_assoc($result))
		{
			echo $row['Lesson'];
		}
	}




	
?>