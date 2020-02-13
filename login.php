$username = isset($_POST['username'])?$_POST['username']: '';
$password = isset($_POST['password'])?$_POST['password']: '';

$ok = true;
$messages = array();

if(!isset($username) || empty($username)){
	$ok = false;
	$message[] = 'username cannot be empty';

}
if(!isset($password) || empty($password)){
	$ok = false;
	$message[] = 'password cannot be empty';
	
}
if($ok) {
	if($username == 'kushal' && password =='kushal') {
	$ok = true;
	$message[] = 'successful login';

	}
	else {
	$ok = false;
	$message[] = 'incorrect username password combination';
}
}

echo json encode{
	array(
	'ok' => $ok,
	'message' => $message);
}

