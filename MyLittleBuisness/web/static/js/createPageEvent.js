$(function() {
    refreshEvents();
    $('#createPageE').on('click', create_Event);
});


function create_Event() {
    $('#page_title1').css('background', '#FFF');
    var title = $('#page_title1').val();
    if(!title) {
        $('#page_title1').css('background', '#FAA');
        return;
        }
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
    var category = $('#page_category').val();
    if(!category) {
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
            $('#page_title1').val('');
            $('#page_date').val('');
            $('#page_place').val('');
            $('#page_category').val('');
            populateEvents(data.events);
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
            populateEvents(data.events);
		},
		error:function(xhr, status, error) {
        alert(xhr.responseText);
        console.error(xhr, status, error);
		}
	});
}

function populateEvents(events) {
    console.log(events);
    var events_str = '';
    for(var event in events) {
        events_str += '<a href="/events/'+events[event].id+' '+events[event].title+'"></a> '+events[event].date+' '+events[event].place+' '+events[event].category+'<br>';
    }
    $('#events').html(events_str);
}

