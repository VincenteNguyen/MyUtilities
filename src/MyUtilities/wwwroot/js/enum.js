$(document).ready(function () {
    $('#btnAddField').click(function (e) {
        e.preventDefault();
        var html = [];
        html.push(
            '<div class="row form-group">',
            '<div class="col-lg-6">',
            '<div class="input-group" style="width: 100%;">',
            '<input class="form-control" type="text" data-val="true" data-val-required="The Key field is required." name="dynamicName" value="">',
            '</div>',
            '</div>',
            '<div class="col-lg-6">',
            '<div class="input-group" style="width: 100%;">',
            '<input class="form-control" type="number" min="0" data-val="true" data-val-required="The Value field is required." name="dynamicValue" value="">',
            '</div>',
            '</div>',
            '</div>'
);
        var inputHtml = html.join("");
        $('#dynamic-div').before(inputHtml);
    });
    //for (var i = 0; i < 3; i++) {
    //    $('#btnAddField').click();
    //}
});