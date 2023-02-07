var allPosts = [];
var selectPostRowEl;

function newPost() {

    const table = document.getElementById("tblPosts");
    const newPost = {
        ID: allPosts.length + 1,
        Name: document.getElementById("name").value,
        Surname: document.getElementById("surname").value,
        Age: document.getElementById("age").value,
        Gender: document.getElementById("gender").value
    };
    allPosts.push(newPost);

    createPostsTableRow(newPost, table);
}

function createPostsTableRow(post, tableEl) {
    let rowEl = tableEl.insertRow();

    rowEl.setAttribute('data-id', post.ID);

    rowEl.addEventListener('click', (event) => {
        selectPostRow(event.currentTarget);
    });

    let idEl = rowEl.insertCell(0);
    idEl.innerHTML = post.ID;

    let titleEl = rowEl.insertCell(1);
    titleEl.innerHTML = post.Name;

    let surnameEl = rowEl.insertCell(2);
    surnameEl.innerHTML = post.Surname;

    let ageEl = rowEl.insertCell(3);
    ageEl.innerHTML = post.Age;

    let genderEl = rowEl.insertCell(4);
    genderEl.innerHTML = post.Gender;
}

// function selectPostRow(rowEl) {
//     if (selectPostRowEl != undefined) {
//         selectPostRowEl.remove('selected')
//     }

//     selectPostRowEl = rowEl;
//     selectPostRowEl.add('selected')
// }