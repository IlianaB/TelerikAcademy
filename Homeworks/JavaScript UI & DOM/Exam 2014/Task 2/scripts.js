$.fn.tabs = function (options) {
	/* How to implement options and default options object

	var defaultOpt = {
		time: 200
	};

	options = $.extend({}, defaultOpt, options);

	console.log(options);*/
	var $tabContainer = $(this),
		$tabs = $tabContainer.find('.tab-item');
	$tabContainer.addClass('tabs-container');

	$tabs.on('click', function (e) {
		$tabContainer.find('.current').removeClass('current');
		$(this).addClass('current');
		e.preventDefault();
	});

	$tabs.first().addClass('current');


};