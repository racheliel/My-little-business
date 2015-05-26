
$(function() {  
    $('#login').on('click', submitLogin);
    $('#register').on('click', submitRegister);
});

$(".modal-wide").on("show.bs.modal", function() {
  var height = $(window).height() - 200;
  $(this).find(".modal-body").css("max-height", height);
});

function submitLogin() {
    var email = $('#login_email').val();
    var password = $('#login_password').val();
    $.ajax({
		url:'/login',
		type:'GET',
		dataType:'json',
        data:{email:email, password:password},
		success:function(data, status, xhr) {
            location.reload();
            window.location.href = "/homeUserIn";	
		},
		error:function(xhr, status, error) {
            alert("the login faild!!");
			console.error(xhr, status, error);
			window.location.href = "/sign";	
		}
	});
}

function submitRegister() {
    var email = $('#reg_email').val();
    var password = $('#reg_password').val();
	$.ajax({
		url:'/signUp',
		type:'GET',
		dataType:'json',
        data:{email:email, password:password},
		success:function(data, status, xhr) {
           alert("success");
		   window.location.href = "/homeUserIn";	
		},
		error:function(xhr, status, error) {
            alert("sign up faild");
			console.error(xhr, status, error);
		}
	});
}