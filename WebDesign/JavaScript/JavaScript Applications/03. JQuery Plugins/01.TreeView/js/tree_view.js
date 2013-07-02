
(function ($, window, document, undefined) {
  'use strict';

  $.fn.treeView = function (options) {
    options = options || {};

    var visibilityStateFnName = options.expand ?
      'show' :
      'hide';

    this.
      addClass('tree_view').
      find('ul').
        addClass('subtree_view')
        [visibilityStateFnName]().
        prev().
          addClass('subtree_root');

    this.on('click', 'a[href=#]', function (event) {
      event.preventDefault();
    });

    this.on('click', '.subtree_root', function () {
      $(this).next().slideToggle();
    });

    return this;
  };
})(jQuery, window, document);
