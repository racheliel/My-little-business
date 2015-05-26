$(document).ready(function() {
  $.ajaxSetup({ cache: true });
  $('#loginFacebook').on('click', loginFacebook);
  $.getScript('//connect.facebook.net/en_US/sdk.js', function(){
    FB.init({
      appId: '1455131861452263',
      version: 'v2.3'
    });     
    $('#login,#feedbutton').removeAttr('disabled');
    FB.getLoginStatus(updateStatusCallback);
  });
  render();
});


function render() {

   var additionalParams = {
     'callback': signinCallback
   };


   var signinButton = document.getElementById('googleLogin');
   signinButton.addEventListener('click', function() {
     gapi.auth.signIn(additionalParams);
   });
}

function signinCallback(authResult) {
  if (authResult['status']['signed_in']) {
    if (authResult['status']['method'] == 'PROMPT') {
		gapi.client.load('plus','v1', function(){
		var request = gapi.client.plus.people.get({
			'userId': 'me'
			});
			request.execute(function(resp) {
				console.log('Retrieved profile for:' + resp.emails[0].value);
				var email = resp.emails[0].value;
				$.ajax({
				url:'/',
				type:'GET',
				dataType:'text',
				data:{email:email},
				success:function(data, status, xhr) {
					window.location.replace("/homeUserIn");
				},
				error:function(xhr, status, error) {
				alert(xhr.responseText);
				console.error(xhr, status, error);
				}
				});
			});
		});
	}
  } else {
    console.log('Sign-in state: ' + authResult['error']);
  }
}

  
function loginFacebook() {
	FB.getLoginStatus(function(response) {
		if (response.status === 'connected') {
			connected();
		}
		else {
			FB.login(function(response) {
				if (response.authResponse) {
					connected();
				} else {
					console.log('User cancelled login or did not fully authorize.');
				}
			}, {scope: 'email'});
		}
	});
};  

function connected() {
    console.log('Welcome!  Fetching your information.... ');
    FB.api('/me', function(response) {
      console.log('Successful login for: ' + response.name + ' ' + response.email);
	  var email = response.email;
	  $.ajax({
		url:'/',
		type:'GET',
		dataType:'text',
        data:{email:email},
		success:function(data, status, xhr) {
            window.location.replace("/homeUserIn");
		},
		error:function(xhr, status, error) {
            alert(xhr.responseText);
			console.error(xhr, status, error);
		}
	});
    });
}