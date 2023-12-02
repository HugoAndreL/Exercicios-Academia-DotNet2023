let button = document.getElementById('show');

button.addEventListener("click", function() {
  let p = document.getElementById('paragrafo');
  (p.style.visibility == "visible") ? p.style.visibility = "hidden" : p.style.visibility = "visible";
});