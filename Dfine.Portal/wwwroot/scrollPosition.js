let savedScrollPosition = 0;

function storeScrollPosition() {
    savedScrollPosition = window.scrollY;
}

function restoreScrollPosition() {
    window.scrollTo(0, savedScrollPosition);
}