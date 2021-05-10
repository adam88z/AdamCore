// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

var APIKEY = "CgMHXdbedJ2T6DiUi6VrYWWqDIxcW2EQcC6tfxXg";

$.ajax({
    url: 'https://api.nasa.gov/planetary/apod?api_key=APIKEY', //retrieves data
    type: 'get',
    data: 'data',
    contentType: 'false',
    success: function (data) {
        document.getElementById('NASA-APOD').src = data.url;
    }
});





function ImageSlider() {

    for (var i = 0; i < 10; i++) {

    }

}

window.onscroll = function () {
    var windowBottom = $(this).scrollTop() + $(this).innerHeight();
    $(".fade-in").each(function () {
        /* Check the location of each desired element */
        var objectBottom = $(this).offset().top + $(this).outerHeight();

        /* If the element is completely within bounds of the window, fade it in */
        if (objectBottom < windowBottom) { //object comes into view (scrolling down)
            $(this).addClass("fade-in-now");
        } else { //object goes out of view (scrolling up)
            //if ($(this).css("opacity") == 1) { $(this).fadeTo(1000, 0); }
        }
    });
    $(".fade-in-left").each(function () {
        /* Check the location of each desired element */
        var objectBottom = $(this).offset().top + $(this).outerHeight();

        /* If the element is completely within bounds of the window, fade it in */
        if (objectBottom < windowBottom) { //object comes into view (scrolling down)
            $(this).addClass("slide-in");
        } else { //object goes out of view (scrolling up)
        }

    });
    $(".fade-in-right").each(function () {
        /* Check the location of each desired element */
        var objectBottom = $(this).offset().top + $(this).outerHeight();
        /* If the element is completely within bounds of the window, fade it in */
        if (objectBottom < windowBottom) { //object comes into view (scrolling down)
            $(this).addClass("slide-in");
        } else { //object goes out of view (scrolling up)
        }
    });
    $(".fade-in-top").each(function () {
        /* Check the location of each desired element */
        var objectBottom = $(this).offset().top + $(this).outerHeight();

        /* If the element is completely within bounds of the window, fade it in */
        if (objectBottom < windowBottom) { //object comes into view (scrolling down)
            $(this).addClass("slide-in");
        } else { //object goes out of view (scrolling up)

        }
    });
    $(".fade-in-bottom").each(function () {
        /* Check the location of each desired element */
        var objectBottom = $(this).offset().top + $(this).outerHeight();

        /* If the element is completely within bounds of the window, fade it in */
        if (objectBottom < windowBottom) { //object comes into view (scrolling down)
            $(this).addClass("slide-in");
        } else { //object goes out of view (scrolling up)
        }
    });

    // When the user scrolls the page, execute myFunction 
    stickyHeader()

} // End window on scroll function



// Get the header
var navbarcontainer = document.getElementById("navbar-container");
// Get the offset position of the navbar 
var sticky = navbarcontainer.offsetTop;
// Add the sticky class to the header when you reach its scroll position. Remove "sticky" when you leave the scroll position 
// to delay the sticky head add a value to sticky below in the parenthesis. example: "sticky+100"
function stickyHeader() {
    if (window.pageYOffset > sticky) {
        navbarcontainer.classList.add("sticky");

    } else {
        navbarcontainer.classList.remove("sticky");
    }
}








// This says if the mouse click IS NOT hamburger or and of hamburgers descendants THEN remove the overlay class.
// Overlay is applied when the user toggles the hamburger function
$(document).mouseup(function (e) {
    if (!$("#navigation-container").is(e.target)  // if the target of the click isn't the container...
        && !$(".hamburger").is(e.target)
        && !$(".hamburger-inner").is(e.target)
        && $("#navigation-container").has(e.target).length === 0) // ... nor a descendant of the container
    {
        $('#overlay').hide();

        $("#navigation-container").hide();
    }
});

function functionHamburgerMenu(x) {
    //x.classList.toggle("change");
    //$(".hamburger-container").stopPropagation(); "stopPropogation" interrupts the operation of the DOM somehow

    if ($(window).innerWidth() <= 600) { $(".hamburger-container").toggleClass("hamburger-stay"); }
    if ($(window).innerWidth() > 600) { $(".hamburger-container").removeClass("hamburger-stay"); }

    $("#overlay").toggle();

    $("#navigation-container").animate({
        height: "toggle"
    }, 100, function () {
        // Animation complete.
    });
}

