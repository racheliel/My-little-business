var pageID = '';
$(function() {
    pageID = $('#page_id').val();
	if(pageID)
		refreshMembers();
   $('#add_member').on('click', addMember);
});


function addMember() {

}        
   


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

