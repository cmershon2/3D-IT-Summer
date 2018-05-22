<?php
//Varibles for the connection
	$servername = "fdb18.runhosting.com";
	$server_username = "2595479_3dit";
	$server_password = "papercut1";
	$dbName = "2595479_3dit";

//Varibles from the user
	$user_username = $_POST["usernamePost"]; 
	$lesson = $_POST["newLesson"];

	echo (int)$lesson;

	//Make connection
	$conn = new mysqli($servername, $server_username, $server_password, $dbName);
	//Check connection
	if(!$conn)
	{
		die("Connction Failed...". mysqli_connect_error());
	}
	
	$sql = "UPDATE users SET Lesson = '".(int)$lesson."' WHERE username = '".$user_username."'";
	$result = mysqli_query($conn ,$sql);

	if (mysqli_query($conn, $sql)) {
		echo "Record updated successfully";
	} else {
		echo "Error updating record: " . mysqli_error($conn);
	}

	mysqli_close($conn);
?>