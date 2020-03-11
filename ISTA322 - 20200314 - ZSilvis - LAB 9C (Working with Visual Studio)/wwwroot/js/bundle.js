document.addEventListener("DOMContentLoaded", function () {
    var element = document.createElement("p");
    element.textContent = "Hey there! This content is from the MODIFIED third.js file.";
    document.querySelector("body").appendChild(element);
});
document.addEventListener("DOMContentLoaded", function () {
    var element = document.createElement("p");
    element.textContent = "Hi there! I'm the fourth.js file!";
    document.querySelector("body").appendChild(element);
})