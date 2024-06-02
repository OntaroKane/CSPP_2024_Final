
$(document).ready(function () {
    $.getJSON("https://localhost:7126/api/actors/nm0000001", function (data) {

        var viewModel = new actorViewModel();
        console.log(data.nconst);

        viewModel = data;

        viewModel.userUserid(data.userUserid);
        viewModel.userUsername(data.userUsername);
        viewModel.userPassword(data.userPassword);
        viewModel.userEmail(data.userEmail);


        console.log(JSON.stringify(viewModel));
        ko.cleanNode(viewModel);
    });
});

$(document).ready(function () {
    $('#myTable').DataTable({
        paging: true,
        searching: true
    });
});

$(document).ready(function () {
    var t = $('#myTable').DataTable();
    var counter = 1;
    $('#addRow').on('click', function () {
        t.row.add([new userViewModel().userUserid, new userViewModel().userUsername, new userViewModel().userPassword,
        new userViewModel().userEmail, new userViewModel().createdAt, new userViewModel().lastLogin]).draw(false);
        counter++;
    });
    $('#addRow').onclick;
});
