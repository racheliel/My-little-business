var pageID = '';
$(function() {
    pageID = $('#page_id').val();
	if(pageID)
		refreshMembers();
   $('#add_member').on('click', addMember);
});


function addMember() {
    $('#title').css('background', '#FFF');
    var title = $('#title').val();
    $('#details').css('background', '#FFF');
    var details = $('#details').val();
    $('#address').css('background', '#FFF');
    var address = $('#address').val();
    $('#name').css('background', '#FFF');
    var name = $('#name').val();
    $('#emailBuss').css('background', '#FFF');
    var emailBuss = $('#emailBuss').val();
    
    if(!title) {
        $('#title').css('background', '#FAA');
        return;}
    if(!details) {
        $('#details').css('background', '#FAA');
        return;}
    if(!address) {
        $('#address').css('background', '#FAA');
        return;}
    if(!name) {
        $('#name').css('background', '#FAA');
        return;}
    if(!emailBuss) {
        $('#emailBuss').css('background', '#FAA');
        return;}        
   


    $.ajax({
		url:'/api/add_member',
		type:'GET',
		dataType:'json',
        data:{page_id:pageID, member_email:new_member},
		success:function(data, status, xhr) {
            $('#new_member').val('');
            populateMembers(data.members);
		},
		error:function(xhr, status, error) {
		alert(xhr.responseText);
		console.error(xhr, status, error);
		}
	});
}

function refreshMembers() {
    $.ajax({
		url:'/api/members',
		type:'GET',
		dataType:'json',
        data:{page:pageID},
		success:function(data, status, xhr) {
            populateMembers(data.members);
		},
		error:function(xhr, status, error) {
		alert(xhr.responseText);
		console.error(xhr, status, error);
		}
	});
}

function populateMembers(members) {
    console.log(members);
    var members_str = '';
    for(var member in members) {
       // console.log(members[member]);
        members_str += ''+members[member].email+'<br>';
    }
    //console.log(pages_str)
    $('#members').html(members_str);
    //$('#groups').html(groups_str);
}

