$(document).ready(function() {
	$('#loginGoogle').on('click', loginGoogle);
});

function loginGoogle() {
	console.log('Test');
	document.location.href = '/loginGoogle';
	
};

