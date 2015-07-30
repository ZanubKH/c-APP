<?php
session_start();

//检测是否登录，若没登录则转向登录界面
if(!isset($_SESSION['Customer_Id'])){
    header("Location:login.html");
    exit();
}

//包含数据库连接文件
include('conn.php');
$userid = $_SESSION['Customer_Id'];
$username = $_SESSION['User_Name'];
$user_query = mysql_query("select * from `user_reservation` where Customer_Id=$userid limit 1");
$row = mysql_fetch_array($user_query);
echo '<h1>My profile</h1><br />';
	 echo '<br />';
echo 'CustomerId:',$userid,'<br />';
echo 'Username:',$username,'<br />';
echo 'Email:',$row['Email'],'<br />';
echo 'FirstName:',$row['First_Name'],'<br />';
echo 'LastName:',$row['Last_Name'],'<br />';
echo 'Address:',$row['Address'],'<br />';
echo '<br />';
echo '<a target="_blank" href="tf.html"><img src="./images/tf.gif" alt="Transfer Money To your account! "></a>
      <a target="_blank" href="tent.php"><img src="./images/tent.gif" alt="To see tent info! "></a>
	  <a target="_blank" href="buyticket.php"><img src="./images/ticket.gif" alt="To buy ticket! "></a>
      <br />';
	 echo '<br />';

// echo '<a href="login.php?action=logout">Logout</a> <br />';
?>