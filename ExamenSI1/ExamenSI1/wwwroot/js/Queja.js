function Queja_Search() {
    const search = document.getElementById("txt-search").value;

    const currentURL = window.location.href.substring(
        window.location.href.lastIndexOf('/') + 1
    ).split("?")[0];

    Window.location = `${currentURL}?search=${search}`;
}