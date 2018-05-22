<?php
	$servername = "fdb18.runhosting.com";
	$username = "2595479_3dit";
	$password = "papercut1";
	$dbName = "2595479_3dit";

	$user_username = $_POST["usernamePost"];

	//make connection
	$conn = new mysqli($servername, $username, $password, $dbName);
	//check connection
	if(!$conn)
	{
		die("Connction Failed...". mysqli_connect_error());
	}
	
	$sql = "SELECT Lesson FROM users WHERE username = '".$user_username."' ";
	$result = mysqli_query($conn ,$sql);

	//Get the result and confirm login
	if(mysqli_num_rows($result) > 0)
	{
		//show data for each row
		while($row = mysqli_fetch_assoc($result))
		{
			if($row['username'] == $user_username)
			{
				echo "Lesson data found";
			}
			else
			{
				echo "Incorrect password";
			}
		}
	}
	else
	{
		echo "user not found";
	}
?>