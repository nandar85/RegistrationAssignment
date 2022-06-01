var dataTable;

$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        //responsive: true,
        //processing: true, // for show progress bar
        //serverSide: true, // for process server side
        //filter: false, // this is for disable filter (search box)
        //orderMulti: false, // for disable multiple column at once
        //pageLength: 10,
        searching: false,
        //order: [[0, "asc"]],
        "ajax": {
            "url": "/api/RegisterUser"
        },
        "columns": [
            { "data": "regId", "width": "15%" },
            { "data": "name", "width": "15%" },
            { "data": "email", "width": "15%" },
            { "data": "gender", "width": "15%" },
            { "data": "registerDate", "width": "15%" },
            { "data": "eventDays", "width": "15%" },
            { "data": "catName", "width": "15%" },
            { "data": "additionalRequest", "width": "15%" }

        ]
    });
}

//function loadDataTable() {
//    var actionurl = '/api/RegisterUser';

//   dataTable= $('#tblData').DataTable({
//        responsive: true,
//        processing: true, // for show progress bar
//        serverSide: true, // for process server side
//        filter: false, // this is for disable filter (search box)
//        orderMulti: false, // for disable multiple column at once
//        pageLength: 10,
//        searching: false,
//        order: [[0, "asc"]],
//        ajax: {
//            url: actionurl,
//            type: 'POST',
//            datatype: 'json'
//        },
       
//        columns: [
//            { data: 'regId', name: 'regId', title: 'NO', autoWidth: true },
//            { data: 'name', name: 'name', title: 'Name', autoWidth: true, },
//            { data: 'email', name: 'email', title: 'Email', autoWidth: true, },
//            { data: 'gender', name: 'gender', title: 'Gender', autoWidth: true, width: '15%' },
//            { data: 'registerDate', name: 'registerDate', title: 'Date Reg', autoWidth: true, width: '15%' },
//            { data: 'eventDays', name: 'eventDays', title: 'Selected Days', autoWidth: true, width: '15%' },
//            { data: 'catName', name: 'catName', title: 'Interest Area', autoWidth: true, width: '15%' },
//            { data: 'additionalRequest', name: 'additionalRequest', title: 'Add. Request', autoWidth: true, width: '15%' }

//        ],
//    });
//}

