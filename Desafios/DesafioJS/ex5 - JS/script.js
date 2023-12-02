
let button = document.querySelector("button");
let ck = document.querySelector("input");

function ckAtivas () {
  let ck1 = document.querySelector("#ck1").checked;
  let ck2 = document.querySelector("#ck2").checked;
  let ck3 = document.querySelector("#ck3").checked;
  if ((ck1 && ck2) || (ck2 && ck3) || (ck1 && ck3))
    button.disabled = false;
};
