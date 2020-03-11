document.addEventListener("DOMContentLoaded", function () {
    var element = document.createElement("p");
    element.textContent = "Hey there! This content is from the MODIFIED third.js file.";
    document.querySelector("body").appendChild(element);
});