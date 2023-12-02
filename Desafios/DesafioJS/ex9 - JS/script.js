function desabilitar() {
  let login = document.querySelector("#login").value;
  let password = document.querySelector("#password").value;
  let confirmP = document.querySelector("#confirm").value;

  let botao = document.querySelector("button");

  if ((login && password && confirmP) && (password === confirmP) && (password.length >= 6 && password.length <= 10)) {
    botao.disabled = false;
    return;
  }
  botao.disabled = true;
}

function cadastrar() {
  alert(`Usuário ${document.querySelector("#login").value} cadastrado!`);
}