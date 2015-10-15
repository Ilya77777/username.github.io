var login = prompt('Enter your login',''), pass;

if (login == 'Admin') {

  var pass = prompt('Enter your password?', '');

  if (pass == 'passw0rd') {
    alert( 'Welcome home!' );
  } else if (pass == null) { 
    alert( 'Canceled' );
  } else {
    alert( 'Wrong password' );
  }
}
 else if (login == null) { 
  alert( 'Canceled' );

} else {

  alert( 'Access denied' );

};