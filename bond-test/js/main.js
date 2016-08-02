$(function() {
   var charLimit = 1;
    $(".inputs").keydown(function(e) {
	    
	    console.log(e.keyCode)
        
        var keys = [8, 9, 16, 17, 18, 19, 20, 27, 33, 34, 35, 36, 37, 38, 39, 40, 45, 46, 144, 145];
        if (e.which == 8 && this.value.length == 0) {
            $(this).prev('.inputs').focus();
        } else if ($.inArray(e.which, keys) >= 0) {
            return true;
        } else if (this.value.length >= charLimit) {
            $(this).next('.inputs').focus();
            return false;
        } else if (e.shiftKey || e.which <= 48 || e.which >= 58) {
            return false;
        }
    }).keyup (function () {
        if (this.value.length >= charLimit) {
	        $(this).next('.inputs').focus();
            return false;
        }
        
    });
});





$('.sbmt').click(function(){
	var cal = $('#i1').val()+$('#i2').val()+$('#i3').val()+$('#i4').val()+$('#i5').val()+$('#i6').val();
	if(cal.length<6){
		alert('wrong');
	}else{
	  
 $.ajax({
 	url: 'php/check.php',
 	data: {code:cal},
 	success : function(data){
 		
    
 	if (data == 'ok'){
    $('.step_0').fadeOut(100);
    $('.step_1_ok').fadeIn(100);
  }else{
    $('.step_0').fadeOut(100);
    $('.step_1_notok').fadeIn(100);
  }
  

    }
   });
	
	

	
		
		
	}
	
});







$('.to_step_0').click(function(){
	$('#i1,#i2,#i3,#i4,#i5,#i6').val('');
	$('.step_1_notok').fadeOut(100);
	$('.video_block').fadeOut(100);
	$('.step_0').fadeIn(100);
});


$('.to_video').click(function(){
	$('.step_1_notok').fadeOut(100);
	$('.video_block').fadeIn(100);
});



$('.new_user').click(function(){
	$('.step_1_ok').fadeOut(100);
	$('.auth_ok').fadeIn(100);
});

$('.old_user').click(function(){
	$('.step_1_ok').fadeOut(100);
	$('.auth_alredy_exist').fadeIn(100);
});














//form ajax
/*
$("#go").submit(function(e) {

    var url = "php/check.php"; // the script where you handle the form input.

    $.ajax({
           type: "POST",
           url: url,
           data: $("#go").serialize(), // serializes the form's elements.
           success: function(data)
           {
               if(data == 'YES'){
               	$('.next').removeClass('off');
               		$('.next_back').addClass('off');
               }else{
               	$('.next_back').removeClass('off');
               		$('.next').addClass('off');
               }
               //alert(data); // show response from the php script.
           }
         });

    e.preventDefault(); // avoid to execute the actual submit of the form.
});
*/		
	
	
//vk init	
  window.vkAsyncInit = function() {
    VK.init({
      apiId: vk_key
    });
  };

  setTimeout(function() {
    var el = document.createElement("script");
    el.type = "text/javascript";
    el.src = "//vk.com/js/api/openapi.js";
    el.async = true;
    document.getElementById("vk_api_transport").appendChild(el);
  }, 0);


function LoginVK() {
VK.Auth.login(function(response) {
  if (response.session) {

  	function authInfo(response) {
        if (response.session) {
            console.log(response.session.mid);
            userid = response.session.mid;
            $.ajax({
 	url: 'php/vkdata.php',
 	data: {vkuser:userid},
 	success : function(data){
 		
    if(data == 'ok'){
      $('.step_1_ok').fadeOut(100);
      $('.auth_ok').fadeIn(100);
    }else{
      $('.step_1_ok').fadeOut(100);
      $('.auth_alredy_exist').fadeIn(100);
    }

 	}
 });
        }
    }
    VK.Auth.getLoginStatus(authInfo);
    /* Пользователь успешно авторизовался */
    if (response.settings) {
      /* Выбранные настройки доступа пользователя, если они были запрошены */
    }
  } else {
    /* Пользователь нажал кнопку Отмена в окне авторизации */
  }
});







}


	
	
//FB init	
	
	window.fbAsyncInit = function () {
  FB.init({
    appId: app_key,
    status: true,
    cookie: true,
    xfbml: true
  });
};

(function (doc) {
  var js;
  var id = 'facebook-jssdk';
  var ref = doc.getElementsByTagName('script')[0];
  if (doc.getElementById(id)) {
    return;
  }
  js = doc.createElement('script');
  js.id = id;
  js.async = true;
  js.src = "//connect.facebook.net/en_US/all.js";
  ref.parentNode.insertBefore(js, ref);
}(document));

function Login() {
  FB.login(function (response) {
    if (response.authResponse) {
      FB.api('/me', function (response) {
        //console.log(response.name);
        //console.log(response.id);
        //document.getElementById('userid').value=response.id;
        userid = response.id;
        //alert(userid);
       
         $.ajax({
 	url: 'php/fbdata.php',
 	data: {fbuser:userid},
 	success : function(data){
 		if(data == 'ok'){
      $('.step_1_ok').fadeOut(100);
      $('.auth_ok').fadeIn(100);
    }else{
      $('.step_1_ok').fadeOut(100);
      $('.auth_alredy_exist').fadeIn(100);
    }
 	}
 });
      });


    } else {
      console.log("Login attempt failed!");
    }
  }, { scope: 'email,user_photos,publish_actions' });
}




	/*
    if(data == 'ok'){
      $('.step_1_ok').fadeOut(100);
      $('.auth_ok').fadeIn(100);
    }else{
      $('.step_1_ok').fadeOut(100);
      $('.auth_alredy_exist').fadeIn(100);
    }

    */