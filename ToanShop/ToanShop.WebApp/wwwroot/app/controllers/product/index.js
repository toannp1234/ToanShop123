var productController = function () {
    this.initialize = function () {
        loadData();
    }

    function registerEvents() {
        //todo: binding events to controls
    }

    function loadData(isPageChanged) {
        $.ajax({
            type: "GET",
            url: "/admin/product/GetAllPaging",
            data: {
                categoryId: $('#ddlCategoryIdS').combotree('getValue'),
                keyword: $('#txt-search-keyword').val(),
                page: tedu.configs.pageIndex,
                pageSize: tedu.configs.pageSize
            },
            dataType: "json",
            beforeSend: function () {
                tedu.startLoading();
            },
            success: function (response) {
                var template = $('#table-template').html();
                var render = "";
                if (response.RowCount > 0) {
                    $.each(response.Results, function (i, item) {
                        render += Mustache.render(template, {
                            Id: item.Id,
                            Name: item.Name,
                            Code: item.Code,
                            OriginalPrice: shared.formatNumber(item.OriginalPrice, 0),
                            Quantity: shared.formatNumber(item.Quantity, 0),
                            CategoryName: item.ProductCategory.Name,
                            Price: shared.formatNumber(item.Price, 0),
                            Image: item.ThumbnailImage == undefined ? '<img src="/admin-side/images/user.png" width=25 />' : '<img src="' + item.ThumbnailImage + '" width=25 />',
                            DateCreated: shared.dateTimeFormatJson(item.DateCreated),
                            Status: shared.getStatus(item.Status)
                        });
                    });
                    $("#lbl-total-records").text(response.RowCount);
                    if (render != undefined) {
                        $('#tbl-content').html(render);

                    }
                    wrapPaging(response.RowCount, function () {
                        loadData();
                    }, isPageChanged);


                }
                else {
                    $('#tbl-content').html('');
                }
                tedu.stopLoading();
            },
            error: function (status) {
                console.log(status);
            }
        });
    };
}