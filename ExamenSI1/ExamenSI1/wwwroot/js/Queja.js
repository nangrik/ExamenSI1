function Queja_Search() {
    const search = document.getElementById("txt_search").value;

    const currentURL = window.location.href.substring(
        window.location.href.lastIndexOf('/') + 1
    ).split("?")[0];

    Window.location = `${currentURL}?search=${search}`;
}

const queja_input_search = document.getElementById("txt_search");

queja_input_search.addEventListener("keyup", function (event) {
    if (event.keyCode === 13) {
        event.preventDefault();
        Queja_Search();
    }
});