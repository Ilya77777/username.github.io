$(function () {
	var $popupClose = $('.popup_close');
	var $zoomButton1 = $('.button--zoom1');
	var $zoomButton2 = $('.button--zoom2');
	var $zoomButton3 = $('.button--zoom3');
	var $zoomButton4 = $('.button--zoom4');
	var $zoomButton5 = $('.button--zoom5');
	var $zoomButton6 = $('.button--zoom6');
	var $overLay = $('.overlay');
	$popupClose.on('click', function (e){
		e.preventDefault();
		$('.overlay').hide();
		$('.popup').hide();
	});
	$zoomButton1.on('click', function (e){
		e.preventDefault();
		$('.overlay').show();
		$('.popup1').show();
	});
	$zoomButton2.on('click', function (e){
		e.preventDefault();
		$('.overlay').show();
		$('.popup2').show();
	});
	$zoomButton3.on('click', function (e){
		e.preventDefault();
		$('.overlay').show();
		$('.popup3').show();
	});
	$zoomButton4.on('click', function (e){
		e.preventDefault();
		$('.overlay').show();
		$('.popup4').show();
	});
	$zoomButton5.on('click', function (e){
		e.preventDefault();
		$('.overlay').show();
		$('.popup5').show();
	});
	$zoomButton6.on('click', function (e){
		e.preventDefault();
		$('.overlay').show();
		$('.popup6').show();
	});
	$overLay.on('click', function (e){
		e.preventDefault();
		$('.overlay').hide();
		$('.popup').hide();
	});
});