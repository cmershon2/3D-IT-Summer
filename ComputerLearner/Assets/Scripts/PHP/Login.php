<?php
	$servername = "fdb18.runhosting.com";
	$username = "2595479_3dit";
	$password = "papercut1";
	$dbName = "2595479_3dit";

	$user_username = $_POST["usernamePost"];
	$user_password = $_POST["passwordPost"];

	//make connection
	$conn = new mysqli($servername, $username, $password, $dbName);
	//check connection
	if(!$conn)
	{
		die("Connction Failed...". mysqli_connect_error());
	}
	
	$sql = "SELECT password FROM users WHERE username = '".$user_username."' ";
	$result = mysqli_query($conn ,$sql);

	//Get the result and confirm login
	if(mysqli_num_rows($result) > 0)
	{
		//show data for each row
		while($row = mysqli_fetch_assoc($result))
		{
			if($row['password'] == $user_password)
			{
				echo "Login Success";
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