$(function() {
    refreshPages();
    $('#createPageB').on('click', create_PageBus);
});


function create_PageBus() {
    $('#page_title').css('background', '#FFF');
    var title = $('#page_title').val();
    if(!title) {
        $('#page_title').css('background', '#FAA');
        return;
    }


    $.ajax({
		url:'/api/createPageBus',
		type:'GET',
		dataType:'json',
        data:{title:title},
		success:function(data, status, xhr) {
            $('#page_title').val('');
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
<<<<<<< HEAD
<<<<<<< HEAD:MyLittleBuisness/web/static/js/userIN.js
        //console.log(pages[page]);
<<<<<<< HEAD:MyLittleBuisness/web/static/js/createPageBus.js
        Pages_str += '<a href="/myBusiness/'+pages[page].id+'">'+pages[page].title+'</a>'+(pages[page].admin ? '<span>(admin)</span>': '')+'<br>';
=======
        Pages_str += '<a href="/pages/'+pages[page].id+'">'+pages[page].title+'</a>'+(pages[page].admin ? '<span>(admin)</span>': '')+'<br>';
>>>>>>> origin/master:MyLittleBuisness/web/static/js/createPageBus.js
=======
        Pages_str += '<a href="/pages/'+pages[page].id+'">'+pages[page].title+'</a>'+(pages[page].admin ? '<span>(admin)</span>': '')+'<br>';
>>>>>>> parent of 7620a93... uodate:MyLittleBuisness/web/static/js/userIN.js
=======
        Pages_str += '<a href="/pages/'+pages[page].id+'">'+pages[page].title+'</a>'+(pages[page].admin ? '<span>(admin)</span>': '')+'<br>';

>>>>>>> origin/master
    }
    $('#pages').html(Pages_str);
}
