var productController = function () {
    this.initialize = function () {
        loadData();
    }
    function RegisterEvents() {

    }
    function loadData() {
        var template = $('#table-template').html();
        var render = "";
        $.ajax({
            type: 'GET',
            url: '/admin/product/GetAll',
            dataType: 'json',
            success: function (response) {
                $.each(response, function (i, item) {
                    render += Mustache.render(template, {
                        Id: item.Id,
                        Name: item.Name,
                        Image: item.Image == null ? '<img src="/admin-side/images/user.png" width=25' : '<img src="' + item.Image + '" width=25 />',
                        CategoryName: item.CategoryId,
                        Price: shared.formatNumber(item.Price, 0),
                        CreatedDate: shared.dateTimeFormatJson(item.DateCreated),
                        Status: shared.getStatus(item.Status)
                    });
                    if (render != '') {
                        $('#tbl-content').html(render);
                    }
                });
            },
            error: function (status) {
                console.log(status);
                shared.notify('Cannot loading data', 'error');
            }
        })
    }
 }
