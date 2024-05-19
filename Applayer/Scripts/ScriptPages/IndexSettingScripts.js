document.addEventListener("DOMContentLoaded", function() {
    const fullscreenButton = document.getElementById("fullscreenButton");

    fullscreenButton.addEventListener("click", function() {
        if (document.documentElement.requestFullscreen) {
            document.documentElement.requestFullscreen();
        } else if (document.documentElement.mozRequestFullScreen) { // Firefox
            document.documentElement.mozRequestFullScreen();
        } else if (document.documentElsement.webkitRequestFullscreen) { // Chrome, Safari and Opera
            document.documentElement.webkitRequestFullscreen();
        } else if (document.documentElement.msRequestFullscreen) { // IE/Edge
            document.documentElement.msRequestFullscreen();
        }
    });

    // Trigger full screen automatically after page load (requires user interaction)
    setTimeout(() => {
        fullscreenButton.click();
    }, 1000); // Adjust the timeout if necessary
});
