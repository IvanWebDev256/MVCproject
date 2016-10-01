
$(function () {

    var ajaxFormSubmit = function () {
        var $form = $(this); // reference to form which is submitted\
        var options = {
            url: $form.attr("action"),
            type: $form.attr("method"),
            data: $form.serialize()
        };

        $.ajax(options).done(function (data) {
            var $target = $($form.attr("data-otf-target")); // DOM elements need to be updated
            var $newHtml = $(data);
            $target.replaceWith($newHtml);
            $newHtml.effect("highlight");
        });

        return false;
    };

    $("form[data-otf-ajax='true']").submit(ajaxFormSubmit);
});