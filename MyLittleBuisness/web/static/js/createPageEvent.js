$(function() {
    refreshEvents();
    $('#createPageE').on('click',createEvent);
});


function createEvent() {
    $('#page_title').css('background', '#FFF');
    var title = $('#page_title').val();
    if(!title) {
        $('#page_title').css('background', '#FAA');
        return;}
    $('#page_date').css('background', '#FFF');
    var date = $('#page_date').val();
    if(!date) {
        $('#page_date').css('background', '#FAA');
        return;}
    $('#page_place').css('background', '#FFF');
    var place = $('#page_place').val();
    if(!place) {
        $('#page_place').css('background', '#FAA');
        return;}
        $('#page_category').css('background', '#FFF');
    var ategory = $('#page_category').val();
    if(!ategory) {
        $('#page_category').css('background', '#FAA');
        return;
    }


    $.ajax({
		url:'/api/createEvent',
		type:'GET',
		dataType:'json',
        data:{title:title},
        data:{date:date},
        data:{place:place},
        data:{category:category},
		success:function(data, status, xhr) {
            $('#page_title').val('');
            $('#page_date').val('');
            $('#page_place').val('');
            $('#page_category').val('');
            populatePages(data.events);
		},
		error:function(xhr, status, error) {
            alert(xhr.responseText);
            console.error(xhr, status, error);
		}
	});
}

function refreshEvents() {
    $.ajax({
		url:'/api/get_pagesEvent',
		type:'GET',
		dataType:'json',
		success:function(data, status, xhr) {
            populatePages(data.pages);
		},
		error:function(xhr, status, error) {
            alert(xhr.responseText);
            console.error(xhr, status, error);
		}
	});
}

function populatePages(events) {
    console.log(events);
    var Pages_str = '';
    for(var event in events) {
        Pages_str += events[event].id+' '+events[event].title+' '+events[event].date+' '+events[event].place+' '+events[event].category+' '+(pages[event].admin ? '<span>(admin)</span>': '')+'<br>';
    }
    //$('#events').html(Pages_str);'<a href="/events/'"></a>
}

