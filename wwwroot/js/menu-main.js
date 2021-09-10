$(document).ready(function () {
	"use strict";
	var arrow_up = '<i class="fa fa-angle-up" aria-hidden="true"></i>';
	var arrow_down = '<i class="fa fa-angle-down" aria-hidden="true"></i>';
	var arrow_span = '<span class="ga-menu-parent">' + arrow_down + '</span>';
	var close_button = '<div class="sub-menu-close"><i class="fa fa-times" aria-hidden="true"></i>Close</div>';
	
	// arrow down element
	$('.nav-menu .ga-mega-menu').append(arrow_span);
	$('.nav-menu > .mymenu-has-child').append(arrow_span);
	$('.nav-menu > .mymenu-has-child .sub-menu > .mymenu-has-child').append(arrow_span);
	
	// close button element
	$('.nav-menu .mymenu-has-child .sub-menu').append(close_button);
	$('.nav-menu .ga-mega-menu .mega-menu').append(close_button);

	/*SUB MENU*/
	$('span.ga-menu-parent').on('click', function(e){
		e.preventDefault();
		
		var t = $(this);
		var menu = t.siblings('ul');	
		var parent = t.parent('li');
		var siblings = parent.siblings('li');
		var arrow_target = 'span.ga-menu-parent';
		
		if (menu.hasClass('sub-menu')) { 
			var menu = t.siblings('ul.sub-menu'); 
		} else if(menu.hasClass('mega-menu')) {
			var menu = t.siblings('ul.mega-menu');
		}
		
		if (menu.hasClass('visible')) {
			setTimeout(function() { menu.removeClass('visible'); }, 10);	
			t.html(arrow_down);		
		} else {
			setTimeout(function() { menu.addClass('visible'); }, 10);
			t.html(arrow_up);
		}
			
		//Close sub menus
		parent.find('ul.visible').removeClass('visible');	
		
		//Close sub menus parents
		parent.siblings('li').children('ul').removeClass('visible');	
		
		//Close sub menus child parents 
		siblings.find('ul.visible').removeClass('visible');	
	
		
		//arrow down in sub menu
		parent.children('ul').find(arrow_target).html(arrow_down);
		
		//arrow down in sub menu parents
		siblings.children(arrow_target).html(arrow_down);
		
		//arrow down in sub menu child parents 
		siblings.find(arrow_target).html(arrow_down);
	}); 
	

	$('ul.nav-menu div.sub-menu-close').on('click', function(e){
	   e.preventDefault();
		  
	   var a = $(this).parent('ul');      
	   a.removeClass('visible');
	   a.siblings('span.ga-menu-parent').html(arrow_down);
	}); 
	
	/* TOGGLE */ 
	$('a.ga-menu-toggle').on('click', function(e){
		e.preventDefault();	
		var menu_height = $('.ga-menu ul').height();
		
		if ($(this).hasClass('ga-menu-toggle-open')) {		
			$(this).removeClass('ga-menu-toggle-open').addClass('ga-menu-toggle-close');
			$('.ga-menu').animate({height:'0px'},{queue:false, duration:300}).addClass('ga-menu-close');	
		} else {			
			$(this).removeClass('ga-menu-toggle-close').addClass('ga-menu-toggle-open');
			$('.ga-menu').animate({height:menu_height},{queue:false, duration:300}).removeClass('ga-menu-close');
		}
	});	
	

	/*	CLOSE ON RESIZE */ 
	var window_width = 0;
	 
	$(window).on('load', function () {	
		window_width = $(window).width();
		$('.ga-menu').addClass( "ga-menu-close" );
	});
	
	$(window).resize( function(){    
		if(window_width !== $(window).width()){		
			$('.visible').removeClass('visible');	
			$('.ga-menu-toggle').removeClass('ga-menu-toggle-open').addClass( "ga-menu-toggle-close" );	
			$('.ga-menu').css( "height", "0" ).addClass( "ga-menu-close" );		
		
			$('span.ga-menu-parent').html( arrow_down );		
			window_width = $(window).width();	
		}
	});	
	
});