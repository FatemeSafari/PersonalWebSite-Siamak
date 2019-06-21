// JavaScript source code
//paste this code under head tag or in a separate js file.
// wait for window load
$(window).load(function () {
    // Animate loader off screen
    $(".se-pre-con").fadeOut("slow");;
});

// reload on top of the page
$(document).ready(function () {
    $("html,body").animate({ scrollTop: 0 }, 50); //50ms for example
});

