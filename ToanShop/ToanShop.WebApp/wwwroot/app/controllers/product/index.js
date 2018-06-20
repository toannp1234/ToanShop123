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
                //categoryId: $('#ddlCategoryIdS').combotree('getValue'),
                categoryId:1,
                keyword: $('#txt-search-keyword').val(),
                page: shared.configs.pageIndex,
                pageSize: shared.configs.pageSize
            },
            dataType: "json",
            beforeSend: function () {
                shared.startLoading();
            },
            success: function (response) {
                var template = $('#table-template').html();
                var render = "";
                if (response.RowCount > 0) {
                    $.each(response.Results, function (i, item) {
                        render += Mustache.render(template, {
                            Id: item.Id,
                            Name: item.Name,
                            //Code: item.Code,
                            CategoryName: item.CategoryId,
                            OriginalPrice: shared.formatNumber(item.OriginalPrice),
                            Quantity: shared.formatNumber(item.Quantity, 0),
                            //CategoryName: item.ProductCategory.Name,
                            
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
                shared.stopLoading();
            },
            error: function (status) {
                console.log(status);
            }
        });
    };
    function wrapPaging(recordCount, callBack, changePageSize) {
        var totalsize = Math.ceil(recordCount / shared.configs.pageSize);
        //Unbind pagination if it existed or click change pagesize
        if ($('#paginationUL a').length === 0 || changePageSize === true) {
            $('#paginationUL').empty();
            $('#paginationUL').removeData("twbs-pagination");
            $('#paginationUL').unbind("page");
        }
        //Bind Pagination Event
        $('#paginationUL').twbsPagination({
            totalPages: totalsize,
            visiblePages: 7,
            first: 'Đầu',
            prev: 'Trước',
            next: 'Tiếp',
            last: 'Cuối',
            onPageClick: function (event, p) {
                shared.configs.pageIndex = p;
                setTimeout(callBack(), 200);
            }
        });
    }
    $("#ddl-show-page").on('change', function () {
        shared.configs.pageSize = $(this).val();
        shared.configs.pageIndex = 1;
        loadData(true);
    });
}