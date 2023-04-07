$("#StudentFilter :input").on('input', function () {
    dataTable.ajax.reload();
});

$('#StudentFilter div').addClass('col-sm-3').parent().addClass('row');

var getFilter = function () {
    var input = {};
    $("#StudentFilter")
        .serializeArray()
        .forEach(function (data) {
            if (data.value != '') {
                input[abp.utils.toCamelCase(data.name.replace(/StudentFilter./g, ''))] = data.value;
            }
        })
    return input;
};

var l = abp.localization.getResource('TestABP');

var service = testABP.students.student;

var dataTable = $('#StudentTable').DataTable(abp.libs.datatables.normalizeConfiguration({
    processing: true,
    serverSide: true,
    paging: true,
    searching: false,//disable default searchbox
    autoWidth: false,
    scrollCollapse: true,
    order: [[0, "asc"]],
    ajax: abp.libs.datatables.createAjax(service.getList, getFilter),
    columnDefs: [
        {
            rowAction: {
                items:
                    [
                        {
                            text: l('Edit'),
                            visible: abp.auth.isGranted('TestABP.Student.Update'),
                            action: function (data) {
                                location.href = "/Students/Student/EditModal?id=" + data.record.id;
                            }
                        },
                        {
                            text: l('Delete'),
                            visible: abp.auth.isGranted('TestABP.Student.Delete'),
                            confirmMessage: function (data) {
                                return l('StudentDeletionConfirmationMessage', data.record.id);
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
            title: l('Full Name'),
            data: "name"
        },
        {
            title: l('Address'),
            data: "address"
        },
        {
            title: l('City'),
            data: "city"
        },

        {
            title: l('State'),
            data: "state"
        },

        {
            title: l('Pincode'),
            data: "postalcode"
        },
        {
            title: l('Date of Birth'),
            data: "dob"
        },


    ]
}));

$('#NewStudentButton').click(function (e) {
    e.preventDefault();
    location.href = "/Students/Student/CreateModal";
});
