$(function() {
    refreshGroups();
    $('#createPageBus').on('click', createPageBus);
});


function createPageBus() {
    $('#buss_title').css('background', '#FFF');
    var title = $('#buss_title').val();
    if(!title) {
        $('#buss_title').css('background', '#FAA');
        return;
    }


    $.ajax({
		url:'/api/createPageBus',
		type:'GET',
		dataType:'json',
        data:{title:title},
		success:function(data, status, xhr) {
            $('#buss_title').val('');
            populateGroups(data.groups);
		},
		error:function(xhr, status, error) {
            alert(xhr.responseText);
			console.error(xhr, status, error);
		}
	});
}

function refreshGroups() {
    $.ajax({
		url:'/api/get_groups',
		type:'GET',
		dataType:'json',
		success:function(data, status, xhr) {
            populateGroups(data.groups);
		},
		error:function(xhr, status, error) {
            alert(xhr.responseText);
			console.error(xhr, status, error);
		}
	});
}

function populateGroups(myPage) {
    console.log(myPage);
    var groups_str = '';
    for(var page in myPage) {
        //console.log(groups[group]);
        groups_str += '<a href="/myPage/'+myPage[page].id+'">'+myPage[page].title+'</a>'+(myPage[page].admin ? '<span>(admin)</span>': '')+'<br>';
    }
    //console.log(groups_str)
    $('#myPage').html(groups_str);
    //$('#groups').html(groups_str);
}

