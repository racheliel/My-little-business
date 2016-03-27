$(function() {
    refreshPages();
    $('#createPageB').on('click', create_PageBus);
});

function create_PageBus() {
    $('#page_title').css('background', '#FFF');
    var title = $('#page_title').val();
    $('#page_details').css('background', '#FFF');
    var details = $('#page_details').val();
    $('#page_address').css('background', '#FFF');
    var address = $('#page_address').val();
    $('#page_name').css('background', '#FFF');
    var name = $('#page_name').val();
    $('#page_emailBuss').css('background', '#FFF');
    var emailBuss = $('#page_emailBuss').val();
    
    if(!title) {
        $('#page_title').css('background', '#FAA');
        return;}
    if(!details) {
        $('#page_details').css('background', '#FAA');
        return;}
    if(!address) {
        $('#page_address').css('background', '#FAA');
        return;}
    if(!name) {
        $('#page_name').css('background', '#FAA');
        return;}
    if(!emailBuss) {
        $('#page_emailBuss').css('background', '#FAA');
        return;}    
    

    $.ajax({
		url:'/api/createPageBus',
		type:'GET',
		dataType:'json',
        data:{title:title,name:name,address:address,details:details,emailBuss:emailBuss},
		success:function(data, status, xhr) {
            $('#page_title').val('');
            $('#page_details').val('');
            $('#page_address').val('');
            $('#page_name').val('');
            $('#page_emailBuss').val('');
            populatePages(data.pages);
		},
		error:function(xhr, status, error) {
		alert(xhr.responseText);
		console.error(xhr, status, error);
		}
	});
}

function refreshPages() {
    $.ajax({
		url:'/api/get_pages',
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

function populatePages(pages) {
    console.log(pages);
    var Pages_str = '';
    for(var page in pages) {
        Pages_str += '<a href="/pages/'+pages[page].id+'">'+pages[page].title+'</a>'+(pages[page].admin ? '<span>(admin)</span>': '')+'<br>';
    }
    $('#pages').html(Pages_str);
}

