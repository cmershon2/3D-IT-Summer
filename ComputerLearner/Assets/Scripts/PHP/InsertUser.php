<?php
//Varibles for the connection
	$servername = "fdb18.runhosting.com";
	$server_username = "2595479_3dit";
	$server_password = "papercut1";
	$dbName = "2595479_3dit";

//Varibles from the user
	$username = $_POST["usernamePost"]; //"cmershon";
	$email = $_POST["emailPost"]; //"test";
	$password = $_POST["passwordPost"]; //"1234";

	//Make connection
	$conn = new mysqli($servername, $server_username, $server_password, $dbName);
	//Check connection
	if(!$conn)
	{
		die("Connction Failed...". mysqli_connect_error());
	}
	
	$sql = "INSERT INTO users (username, email, password)
			VALUES('".$username."','".$email."','".$password."')";
	$result = mysqli_query($conn ,$sql);

	if(!result) echo "there was an error";
	else echo "Everything is fine I guess";
?>