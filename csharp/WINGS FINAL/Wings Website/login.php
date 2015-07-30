<html> 
<head> 
<meta charset="utf-8" /> 
<title>Camping Fun</title> 
<style type="text/css"> 
#head,#mid,#foot{margin:0 auto;width:800px; height:141px} 
#head{text-align:center; border:1px solid #000} 
#mid{ text-align:left; border:1px solid #fff; height:1050px} 
#foot{text-align:center; border:0px solid #000; height:5px} 


body{background-image:url(images/bg.GIF); 
background-repeat: repeat } 
.logo{ margin:0 auto; width:500px; height:81px; border:0px solid #00F} 

ul#nav{ width:760px; height:60px; background:#00A2CA;margin:0 auto} 
ul#nav li{display:inline; height:60px} 
ul#nav li a{display:inline-block; padding:0 20px; height:60px; line-height:60px;
 color:#FFF; font-family:"\5FAE\8F6F\96C5\9ED1"; font-size:16px} 
ul#nav li a:hover{background:#0095BB}


#intr,#football,#music,#shop{margin:0 auto;width:800px; height:150px}
#intr{border:0px solid #FFF}
#shop{border:0px solid #FFF}
#football{border:0px solid #FFF}
#music{border:0px solid #FFF}


/* login */
.feed{
	padding:50px 0;
	margin-bottom:30px;
}
.feedback{
	font-size:16px;
	padding-bottom:10px;
	color:#464646;
	margin:0 0 0 30px;
	float:left;
}
.feedback h1{
font-family: "Verdana" , Geneva, Arial, Helvetica, sans-serif;
	font-size:28px;
	padding-bottom:10px;
	color:#999;
}
.feedback div{
	padding:10px;
}
.feedback label{
	color: #888;
}
.feedback span{	
	display:block;
	padding:3px 0;
}
.feedback input[type="text"]{
	width:250px;
	padding:5px 2px;
	font-size:12px;
	color:#444;
	border:1px solid #ddd;
	outline: none;
	font-family: "Verdana" , Geneva, Arial, Helvetica, sans-serif;
}
.feedback input[type="password"]{
	width:250px;
	padding:5px 2px;
	font-size:12px;
	color:#444;
	border:1px solid #ddd;
	outline: none;
	font-family: "Verdana" , Geneva, Arial, Helvetica, sans-serif;
}

.feedback textarea{
	width:450px;
	height:100px;
	padding:5px 2px;
	font-size:16px;
	border:1px solid #ddd;
	font-size:12px;
	color:#444;
	outline: none;
	resize: none;
	font-family: "Verdana" , Geneva, Arial, Helvetica, sans-serif;
}
.feedback input[type="submit"]{
	width:100px;
	padding:7px 0;
	font-size:16px;
	color:#666;
	background: #eeeeee;
	background: -moz-linear-gradient(top,  #eeeeee 0%, #cccccc 100%);
	background: -webkit-gradient(linear, left top, left bottom, color-stop(0%,#eeeeee), color-stop(100%,#cccccc));
	background: -webkit-linear-gradient(top,  #eeeeee 0%,#cccccc 100%);
	background: -o-linear-gradient(top,  #eeeeee 0%,#cccccc 100%);
	background: -ms-linear-gradient(top,  #eeeeee 0%,#cccccc 100%);
	background: linear-gradient(to bottom,  #eeeeee 0%,#cccccc 100%);
	filter: progid:DXImageTransform.Microsoft.gradient( startColorstr='#eeeeee', endColorstr='#cccccc',GradientType=0 );
	box-shadow:0 0 5px #666;
	border-bottom: 1px solid #060000;
	border:none;
	font-size:12px;
	cursor:pointer;
	font-family: "Verdana" , Geneva, Arial, Helvetica, sans-serif;
}
.feedback input[type="submit"]:hover{
	color: #222;
}
	
/*--form--*/	
.form{
	margin:10px 0 5px 0;
	font-family: 'Playfair Display SC', serif;

}
.form-1,{
	float:left;
	width: 315px;
	margin:0 13px 0 13px; 
	padding-bottom: 10px;

}
.form-1 img{
	display: block;	
	margin-top:15px;
}
.form-1 p{
	color: #aaa;
	padding:8px 0;
	line-height: 1.8em;
	font-family: "Verdana" , Geneva, Arial, Helvetica, sans-serif;
}
	

/* bot*/ 

.copy{
font-family: "Verdana" , Geneva, Arial, Helvetica, sans-serif;
	text-align: center;
	word-spacing:3px;
	padding:30px 0;
	color:#444;
}
.copy a{
	color:#666;
}
.copy a:hover{
	color: #fff;
	border-bottom:1px solid #A90329;
</style> 
</head> 
<body> 
<div id="head">
<div class="logo"><a href="index.html"><img src="./images/logo.png" alt="Camping Fun!" /></a></div>

<ul id="nav"> 
    <li><a href="index.html">Home</a></li> 
    <li><a href="support.html">Support</a></li> 
    <li><a href="register.html">Register</a></li> 
    <li><a href="login.html">login</a></li> 
</ul> 
</div> 

<div id="mid">
<div class="feed">
<div class="feedback">
<?php
session_start();

$str = 'action';
function _get($str){
    $val = !empty($_GET[$str])? $_GET[$str] : null;
    return $val;
}
//注销登录
if(_get($str) == "logout"){
    unset($_SESSION['Customer_Id']);
    unset($_SESSION['User_Name']);
    echo 'You already Log out！Here to <a href="login.html">login</a>';
    exit;
}

//登录
if(!isset($_POST['submit'])){
    exit('非法访问!');
}
$username = htmlspecialchars($_POST['username']);
$password = MD5($_POST['password']);

//包含数据库连接文件
include('conn.php');
//检测用户名及密码是否正确
$check_query = mysql_query("select Customer_Id from `user_reservation` where User_Name='$username' and Password='$password' 
limit 1");
if($result = mysql_fetch_array($check_query)){
    //登录成功
    $_SESSION['User_Name'] = $username;
    $_SESSION['Customer_Id'] = $result['Customer_Id'];
    echo $username,' Wlecome! Here to see  <a href="my.html">My profile</a><br />';
    echo 'here for <a href="login.php?action=logout"> Log out</a> your account!<br />';
    exit;
} else {
    exit('登录失败！点击此处 <a href="javascript:history.back(-1);">返回</a> 重试');
}
?>
</div>
</div>
</div>

<div id="foot"> 
    <div class="copy">
    	<p>&copy; 2015 | Design by <b>WINGS</b> </p>
    </div>


</div>




</body> 
</html> 