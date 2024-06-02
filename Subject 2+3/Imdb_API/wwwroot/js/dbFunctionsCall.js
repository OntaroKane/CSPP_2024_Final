
function string_search(movie) {

    let url = '/api/dbfunctions/f1/' + String(movie);

        const requestOptions = {
            method: 'GET',
            headers: { 'Content-Type': 'application/json' }
        };

        fetch(url, requestOptions)
            .then(response => response.json())
            .then(data => {
                console.log('Success:', data);
                alert('Entry successfully created!');
            })
            .catch(error => {
                console.error('Error:', error);
                alert('An error occurred while creating the entry.');
            });
}

function search_actor(actor) {

    let url = '/api/dbfunctions/f2/' + String(actor);

    const requestOptions = {
        method: 'GET',
        headers: { 'Content-Type': 'application/json' }
    };

    fetch(url, requestOptions)
        .then(response => response.json())
        .then(data => {
            console.log('Success:', data);
            alert('Entry successfully created!');
        })
        .catch(error => {
            console.error('Error:', error);
            alert('An error occurred while creating the entry.');
        });
}

function similarmovies(movie) {

    let url = '/api/dbfunctions/f3/' + String(movie);

    const requestOptions = {
        method: 'GET',
        headers: { 'Content-Type': 'application/json' }
    };

    fetch(url, requestOptions)
        .then(response => response.json())
        .then(data => {
            console.log('Success:', data);
            alert('Entry successfully created!');
        })
        .catch(error => {
            console.error('Error:', error);
            alert('An error occurred while creating the entry.');
        });
}

function search_costar(costar) {

    let url = '/api/dbfunctions/f4/' + String(costar);

    const requestOptions = {
        method: 'GET',
        headers: { 'Content-Type': 'application/json' }
    };

    fetch(url, requestOptions)
        .then(response => response.json())
        .then(data => {
            console.log('Success:', data);
            alert('Entry successfully created!');
        })
        .catch(error => {
            console.error('Error:', error);
            alert('An error occurred while creating the entry.');
        });
}

function wtw_query(fk,sk) {

    let url = '/api/dbfunctions/f5/' + String(fk) + '/' + String(sk);

    const requestOptions = {
        method: 'GET',
        headers: { 'Content-Type': 'application/json' }
    };

    fetch(url, requestOptions)
        .then(response => response.json())
        .then(data => {
            console.log('Success:', data);
            alert('Entry successfully created!');
        })
        .catch(error => {
            console.error('Error:', error);
            alert('An error occurred while creating the entry.');
        });
}

function search_4values(movietitle,plot,year,person) {

    let url = '/api/dbfunctions/f6/' + String(movietitle) + '/' + String(plot) + '/' + String(year) + '/' + String(person);

    const requestOptions = {
        method: 'GET',
        headers: { 'Content-Type': 'application/json' }
    };

    fetch(url, requestOptions)
        .then(response => response.json())
        .then(data => {
            console.log('Success:', data);
            alert('Entry successfully created!');
        })
        .catch(error => {
            console.error('Error:', error);
            alert('An error occurred while creating the entry.');
        });
}

function rate_movie(userid,tconst,rating) {

    let url = '/api/dbfunctions/f7/' + String(userid) + '/' + String(tconst) + '/' + String(rating);

    const requestOptions = {
        method: 'GET',
        headers: { 'Content-Type': 'application/json' }
    };

    fetch(url, requestOptions)
        .then(response => response.json())
        .then(data => {
            console.log('Success:', data);
            alert('Entry successfully created!');
        })
        .catch(error => {
            console.error('Error:', error);
            alert('An error occurred while creating the entry.');
        });
}

function popular_actors() {

    let url = '/api/dbfunctions/f8/popular_actors';

    const requestOptions = {
        method: 'GET',
        headers: { 'Content-Type': 'application/json' }
    };

    fetch(url, requestOptions)
        .then(response => response.json())
        .then(data => {
            console.log('Success:', data);
            alert('Entry successfully created!');
        })
        .catch(error => {
            console.error('Error:', error);
            alert('An error occurred while creating the entry.');
        });
}


function name_rating(nconst) {

    let url = '/api/dbfunctions/f9/' + String(nconst);

    const requestOptions = {
        method: 'GET',
        headers: { 'Content-Type': 'application/json' }
    };

    fetch(url, requestOptions)
        .then(response => response.json())
        .then(data => {
            console.log('Success:', data);
            alert('Entry successfully created!');
        })
        .catch(error => {
            console.error('Error:', error);
            alert('An error occurred while creating the entry.');
        });
}

function index_search(movien,genre,actor,moviek,moviek2) {

    let url = '/api/dbfunctions/f10/' + String(movien) + String(genre) + String(actor) + String(moviek) + String(moviek2);

    const requestOptions = {
        method: 'GET',
        headers: { 'Content-Type': 'application/json' }
    };

    fetch(url, requestOptions)
        .then(response => response.json())
        .then(data => {
            console.log('Success:', data);
            alert('Entry successfully created!');
        })
        .catch(error => {
            console.error('Error:', error);
            alert('An error occurred while creating the entry.');
        });
}

function exact_search(movie,genre) {

    let url = '/api/dbfunctions/f11/' + String(movie) + String(genre);

    const requestOptions = {
        method: 'GET',
        headers: { 'Content-Type': 'application/json' }
    };

    fetch(url, requestOptions)
        .then(response => response.json())
        .then(data => {
            console.log('Success:', data);
            alert('Entry successfully created!');
        })
        .catch(error => {
            console.error('Error:', error);
            alert('An error occurred while creating the entry.');
        });
}


function best_search(movien, genre, actor, moviek, moviek2) {

    let url = '/api/dbfunctions/f12/' + String(movien) + String(genre) + String(actor) + String(moviek) + String(moviek2);

    const requestOptions = {
        method: 'GET',
        headers: { 'Content-Type': 'application/json' }
    };

    fetch(url, requestOptions)
        .then(response => response.json())
        .then(data => {
            console.log('Success:', data);
            alert('Entry successfully created!');
        })
        .catch(error => {
            console.error('Error:', error);
            alert('An error occurred while creating the entry.');
        });
}


function best2_search(movien, genre, actor, moviek, moviek2) {

    let url = '/api/dbfunctions/f13/' + String(movien) + String(genre) + String(actor) + String(moviek) + String(moviek2);

    const requestOptions = {
        method: 'GET',
        headers: { 'Content-Type': 'application/json' }
    };

    fetch(url, requestOptions)
        .then(response => response.json())
        .then(data => {
            console.log('Success:', data);
            alert('Entry successfully created!');
        })
        .catch(error => {
            console.error('Error:', error);
            alert('An error occurred while creating the entry.');
        });
}


function movie_bookmark(userid,tconst) {

    let url = '/api/dbfunctions/f14/' + String(userid) + String(tconst);

    const requestOptions = {
        method: 'GET',
        headers: { 'Content-Type': 'application/json' }
    };

    fetch(url, requestOptions)
        .then(response => response.json())
        .then(data => {
            console.log('Success:', data);
            alert('Entry successfully created!');
        })
        .catch(error => {
            console.error('Error:', error);
            alert('An error occurred while creating the entry.');
        });
}


function actor_bookmark(userid, nconst) {

    let url = '/api/dbfunctions/f15/' + String(userid) + String(nconst);

    const requestOptions = {
        method: 'GET',
        headers: { 'Content-Type': 'application/json' }
    };

    fetch(url, requestOptions)
        .then(response => response.json())
        .then(data => {
            console.log('Success:', data);
            alert('Entry successfully created!');
        })
        .catch(error => {
            console.error('Error:', error);
            alert('An error occurred while creating the entry.');
        });
}

function retriveUsers() {
    $.getJSON("https://localhost:7126/api/users", function (data) {

        $('#tableContainer').empty();

        const columns = Object.keys(data[0]);

        let tableHeader = '<tr>';
        columns.forEach(column => {
            tableHeader += `<th>&nbsp;${column}</th>`;
        });
        tableHeader += '</tr>';

        let tableBody = '';
        data.forEach(entry => {
            let row = '<tr>';
            columns.forEach(column => {
                row += `<td>&nbsp;${entry[column]}</td>`;
            });
            row += `<td><button class="btn btn-primary">Edit</button></td>`;
            row += `<td><button class="btn btn-danger">Delete</button></td>`;
            row += '</tr>';
            tableBody += row;
        });

        // Combine the header and body
        const tableHtml = `<table class="table table-fluid display" id="myTable">${tableHeader}${tableBody}</table>`;

        // Append the table to the container
        document.getElementById('tableContainer').innerHTML = tableHtml;

        $(document).ready(function () {
            $('#myTable').DataTable({
                paging: true,
                pageLength: 25,
                lengthMenu: [[10, 25, 50, -1], [10, 25, 50, "All"]],
                columns: columns
            });
        });

        var viewModel = new userViewModel();
        console.log(data);

        viewModel = data;

        console.log(JSON.stringify(viewModel));
    });
}

function retriveMovies() {
    $.getJSON("https://localhost:7126/api/movies", function (data) {

        $('#tableContainer').empty();

        const columns = Object.keys(data[0]);

        let tableHeader = '<tr>';
        columns.forEach(column => {
            tableHeader += `<th>&nbsp;${column}</th>`;
        });
        tableHeader += '</tr>';

        // Start building the table body
        let tableBody = '';
        data.forEach(entry => {
            let row = '<tr>';
            columns.forEach(column => {
                row += `<td>&nbsp;${entry[column]}</td>`;
            });
            row += `<td><button class="btn btn-primary">Edit</button></td>`;
            row += `<td><button class="btn btn-danger">Delete</button></td>`;
            row += '</tr>';
            tableBody += row;
        });

        // Combine the header and body
        const tableHtml = `<table class="table table-fluid display" id="myTable">${tableHeader}${tableBody}</table>`;

        // Append the table to the container
        document.getElementById('tableContainer').innerHTML = tableHtml;

        $(document).ready(function () {
            $('#myTable').DataTable({
                paging: true,
                pageLength: 25,
                lengthMenu: [[10, 25, 50, -1], [10, 25, 50, "All"]],
                columns: columns
            });
        });

        var viewModel = new userViewModel();
        console.log(data);

        viewModel = data;

        console.log(JSON.stringify(viewModel));
    });
}

function retriveActors() {
    $.getJSON("https://localhost:7126/api/actors", function (data) {

        $('#tableContainer').empty();

        const columns = Object.keys(data[0]);

        let tableHeader = '<tr>';
        columns.forEach(column => {
            tableHeader += `<th>&nbsp;${column}</th>`;
        });
        tableHeader += '</tr>';

        // Start building the table body
        let tableBody = '';
        data.forEach(entry => {
            let row = '<tr>';
            columns.forEach(column => {
                row += `<td>&nbsp;${entry[column]}</td>`;
            });
            row += `<td><button class="btn btn-primary" onclick="#">Edit</button></td>`;
            row += `<td><button class="btn btn-danger" onclick="#">Delete</button></td>`;
            row += '</tr>';
            tableBody += row;
        });

        const tableHtml = `<table class="table table-fluid display" id="myTable">${tableHeader}${tableBody}</table>`;

        document.getElementById('tableContainer').innerHTML = tableHtml;

        $(document).ready(function () {
            $('#myTable').DataTable({
                paging: true,
                pageLength: 25,
                lengthMenu: [[10, 25, 50, -1], [10, 25, 50, "All"]],
                columns: columns
            });
        });



        var viewModel = new userViewModel();
        console.log(data);

        viewModel = data;

        console.log(JSON.stringify(viewModel));
    });
}

function createUser(username, password, email) {

    const dataToSend = JSON.stringify({
        userid: crypto.randomUUID(),
        username: username,
        password: password,
        email: email
    });

    // Set up the fetch options
    const requestOptions = {
        method: 'POST',
        headers: { 'Content-Type': 'application/json' },
        body: dataToSend
    };

    fetch('/api/Users', requestOptions)
        .then(response => response.json())
        .then(data => {
            console.log('Success:', data);
            alert('Entry successfully created!');
        })
        .catch(error => {
            console.error('Error:', error);
            alert('An error occurred while creating the entry.');
        });

}

function createActor(primaryname, birthyear, deathyear) {

    const dataToSend = JSON.stringify({
        nconst: 'nm' + String(Math.floor(Math.random() * 10000000) + 10000000),
        primaryname: primaryname,
        birthyear: birthyear,
        deathyear: deathyear
    });

    // Set up the fetch options
    const requestOptions = {
        method: 'POST',
        headers: { 'Content-Type': 'application/json' },
        body: dataToSend
    };

    fetch('/api/Actors', requestOptions)
        .then(response => response.json())
        .then(data => {
            console.log('Success:', data);
            alert('Entry successfully created!');
        })
        .catch(error => {
            console.error('Error:', error);
            alert('An error occurred while creating the entry.');
        });

}

function createMovie(titletype, primarytitle) {

    const dataToSend = JSON.stringify({
        tconst: 'tt' + String(Math.floor(Math.random() * 10000000) + 10000000),
        titletype: titletype,
        primarytitle: primarytitle
    });

    // Set up the fetch options
    const requestOptions = {
        method: 'POST',
        headers: { 'Content-Type': 'application/json' },
        body: dataToSend
    };

    fetch('/api/Movies', requestOptions)
        .then(response => response.json())
        .then(data => {
            console.log('Success:', data);
            alert('Entry successfully created!');
        })
        .catch(error => {
            console.error('Error:', error);
            alert('An error occurred while creating the entry.');
        });

}


function deleteUser(userid) {

    let url = '/api/users/' + String(userid);

    fetch(url, {
        method: 'DELETE',
    })
        .then(response => response.json())
        .then(data => console.log(data))
        .catch((error) => console.error('Error:', error));
}

function deleteActor(nconst) {

    let url = '/api/actors/' + String(nconst);

    fetch(url, {
        method: 'DELETE',
    })
        .then(response => response.json())
        .then(data => console.log(data))
        .catch((error) => console.error('Error:', error));
}

function deleteMovie(tconst) {

    let url = '/api/movies/' + String(tconst);

    fetch(url, {
        method: 'DELETE',
    })
        .then(response => response.json())
        .then(data => console.log(data))
        .catch((error) => console.error('Error:', error));
}

function editMovie(tconst, titletype, primarytitle) {

    const dataToSend = JSON.stringify({
        tconst: tconst,
        titletype: titletype,
        primarytitle: primarytitle
    });

    // Set up the fetch options
    const requestOptions = {
        method: 'PUT',
        headers: { 'Content-Type': 'application/json' },
        body: dataToSend
    };

    fetch('/api/movies/tt9460980', requestOptions)
        .then(response => response.json())
        .then(data => {
            console.log('Success:', data);
            alert('Entry successfully created!');
        })
        .catch(error => {
            console.error('Error:', error);
            alert('An error occurred while creating the entry.');
        });

}

function editUser(tconst, titletype, primarytitle) {

    const dataToSend = JSON.stringify({
        userid: userid,
        username: username,
        password: password,
        email: email
    });

    // Set up the fetch options
    const requestOptions = {
        method: 'PUT',
        headers: { 'Content-Type': 'application/json' },
        body: dataToSend
    };

    fetch('/api/movies/tt9460980', requestOptions)
        .then(response => response.json())
        .then(data => {
            console.log('Success:', data);
            alert('Entry successfully created!');
        })
        .catch(error => {
            console.error('Error:', error);
            alert('An error occurred while creating the entry.');
        });

}

function editActor(tconst, titletype, primarytitle) {

    const dataToSend = JSON.stringify({
        nconst: nconst,
        primaryname: primaryname,
        birthyear: birthyear,
        deathyear: deathyear
    });

    // Set up the fetch options
    const requestOptions = {
        method: 'PUT',
        headers: { 'Content-Type': 'application/json' },
        body: dataToSend
    };

    fetch('/api/movies/tt9460980', requestOptions)
        .then(response => response.json())
        .then(data => {
            console.log('Success:', data);
            alert('Entry successfully created!');
        })
        .catch(error => {
            console.error('Error:', error);
            alert('An error occurred while creating the entry.');
        });

}