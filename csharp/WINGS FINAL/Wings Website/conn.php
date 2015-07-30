<?php
/*****************************
*��ݿ�����
*****************************/
$conn = @mysql_connect("localhost","dbi298536","SISnLjRGxk");
if (!$conn){
    die("������ݿ�ʧ�ܣ�" . mysql_error());
}
mysql_select_db("dbi298536", $conn);
//�ַ�ת��������
//mysql_query("set character set 'utf-8'");
//д��
//mysql_query("set names 'utf-8'");
?>