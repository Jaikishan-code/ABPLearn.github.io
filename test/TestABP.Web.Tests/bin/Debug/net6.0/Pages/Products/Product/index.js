$(function () {

    $("#ProductFilter :input").on('input', function () {
        dataTable.ajax.reload();
    });

    $('#ProductFilter div').addClass('col-sm-3').parent().addClass('row');

    var getFilter = function () {
        var input = {};
        $("#ProductFilter")
            .serializeArray()
            .forEach(function (data) {
                if (data.value != '') {
                    input[abp.utils.toCamelCase(data.name.replace(/ProductFilter./g, ''))] = data.value;
                }
            })
        return input;
    };

    var l = abp.localization.getResource('TestABP');

    var service = testABP.products.product;
    var createModal = new abp.ModalManager(abp.appPath + 'Products/Product/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'Products/Product/EditModal');

    var dataTable = $('#ProductTable').DataTable(abp.libs.datatables.normalizeConfiguration({
        processing: true,
        serverSide: true,
        paging: true,
        searching: false,//disable default searchbox
        autoWidth: false,
        scrollCollapse: true,
        order: [[0, "asc"]],
        ajax: abp.libs.datatables.createAjax(service.getList,getFilter),
        columnDefs: [
            {
                rowAction: {
                    items:
                        [
                            {
                                text: l('Edit'),
                                visible: abp.auth.isGranted('TestABP.Product.Update'),
                                action: function (data) {
                                    editModal.open({ id: data.record.id });
                                }
                            },
                            {
                                text: l('Delete'),
                                visible: abp.auth.isGranted('TestABP.Product.Delete'),
                                confirmMessage: function (data) {
                                    return l('ProductDeletionConfirmationMessage', data.record.id);
                                },
                                action: function (data) {
                                    service.delete(data.record.id)
                                        .then(function () {
                                            abp.notify.info(l('SuccessfullyDeleted'));
                                            dataTable.ajax.reload();
                                        });
                                }
                            }
                        ]
                }
            },
            {
                title: l('Product Name'),
                data: "product_Name"
            },
            {
                title: l('Product Description'),
                data: "product_Description"
            },
            {
                title: l('Product Category'),
                data: "product_Category"
            },
            {
                title: l('Product Code'),
                data: "product_code"
            },
            {
                title: l('Product Keywords'),
                data: "product_keywords"
            },
            {
                title: l('Product Price'),
                data: "product_Price"
            },
        ]
    }));

    createModal.onResult(function () {
        dataTable.ajax.reload();
    });

    editModal.onResult(function () {
        dataTable.ajax.reload();
    });

    $('#NewProductButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});
