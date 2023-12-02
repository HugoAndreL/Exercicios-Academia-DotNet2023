// Global
let p = document.querySelector("p");
// Exercicio 6

function corWhite() {
  p.style.color = "white";
}

function corBlack() {
  p.style.color = "black";
}

function bgBlack() {
  document.body.style.backgroundColor = "black";
}

function bgWhite() {
  document.body.style.backgroundColor = "white";
}

// Exercicio 7
let size = window.getComputedStyle(p, null).getPropertyValue('font-size');

function plus() {
  size = parseInt(size) + 1;
  p.style.fontSize = `${size}px`;
}

function minus() {
  size = parseInt(size) - 1;
  p.style.fontSize = `${size}px`;
}

// Exercicio 8
function upper() {
  p.style.textTransform = "uppercase";
}
