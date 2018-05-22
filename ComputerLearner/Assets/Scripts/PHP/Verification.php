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
	
	$insertedUsername=$_REQUEST['username'];
    $insertedEmail=$_REQUEST['email'];
     
     $sqlCheckUsername="SELECT 1 FROM users WHERE username = '" . mysqli_real_escape_string($conn, $insertedUsername) . "'";
     $sqlCheckEmail="SELECT 1 FROM users WHERE email = '" . mysqli_real_escape_string($conn, $insertedEmail) . "'";
     
     $queryUsername=mysqli_query($conn,$sqlCheckUsername) or die('error');
     $queryEmail=mysqli_query($conn, $sqlCheckEmail) or die('error');
     
     $Username = mysqli_fetch_assoc($queryUsername);
       if(mysqli_num_rows($queryUsername)!=0){
         echo "Username already exists, choose a different one";
     }elseif(mysqli_num_rows($queryEmail)!=0){
         echo "E-Mail already registered";
     }else{
         echo "true";
     }
	
?>