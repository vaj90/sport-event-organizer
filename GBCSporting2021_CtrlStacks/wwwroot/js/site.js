$(document).ready(function () {
    $('[data-bs-toggle="modal"]').click(function (e) {
        var modal = $(this).attr("data-bs-target");
        $(modal).modal('show');
    });
    var removeDataAttr = function (obj) {
        var keys = [];
        var attributes = obj[0].attributes;
        $.each(attributes, function (k, v) {
            if (this.specified) {
                let attr = this.localName;
                if (attr.includes('data') > 0) keys.push(attr);
            }
        });
        for (var i = 0; i < keys.length; i++) {
            obj.removeAttr(keys[i]);
        }
    }
    var validationRemove = function ($this) {
        $this.removeClass("input-validation-error");
        removeDataAttr($this);
        var span = $this.next();
        $(span).removeClass("field-validation-error");
        removeDataAttr($(span));
        $(span).html("");}

    $(".input-validation-error")
        .on("focus", function (e) {
            validationRemove($(this));
    });
    $(document).on("focus", ".input-validation-error", function (e) {
        validationRemove($(this));
    });
})