let inputs = document.querySelectorAll('input');
let campos = document.querySelectorAll('label');
campos[2].style.display = "none";
campos[3].style.display = "none";
campos[4].style.display = "none";

function mostrarCampos(tag) {
  if (tag.id === "fisica" && tag.checked) {
    campos[2].style.display = "inherit";
    campos[3].style.display = "none";
    campos[4].style.display = "inherit";
  } else if (tag.id === "juridica" && tag.checked) {
    campos[2].style.display = "none";
    campos[3].style.display = "inherit";
    campos[4].style.display = "none";
  }
}

function desabilitar() {
  let botao = document.querySelector("button");
  let swNome = false;
  let swPessoa = false;
  let swCpf = false;
  let swDataNasc = false;
  let swCnpj = false;
  let swEndereco = false;
  let swCep = false;
  let swTel = false;
  let swEmail = false;

  // Valida nome
  if (inputs[0].value)
    swNome = true;   
  else swNome = false;

  // Valida pessoa fisica
  if (inputs[1].checked) {
    swPessoa = true;
    
    // Valida CPF
    if (inputs[3].value)
      swCpf = true;
    else swCpf = false;

    // Valida data de nascimento
    if (inputs[5].value)
      swDataNasc = true;
    else swDataNasc = false;
  }
  
  // Valida pessoa juridica
  else if (inputs[2].checked) {
    swPessoa = true;
    // Valida CNPJ
    if (inputs[4].value)
      swCnpj = true;
    else swEndereco = false;
  }
  
  // Valida endereço
  if (inputs[6].value)
    swEndereco = true;
  else swEndereco = false;

  // Valida CEP
  if (inputs[7].value)
    swCep = true;
  else swCep = false;
  
  // Valida Telefone
  if (inputs[8].value)
  swTel = true;
else swTel = false;

  // Valida Email
  if (inputs[9].value)
    swEmail = true;
  else swEmail = false;
  
  // Guardando tudo em uma variavel
  let sw = (swNome && swPessoa && ((swCpf && swDataNasc) || swCnpj) && swEndereco && swCep && swTel && swEmail);
  
  if (sw)
    botao.disabled = false;
  else botao.disabled = true;
}

function cadastrar() {
  alert(`Usuário ${inputs[0].value} cadastrado!`);
}

// Valida Data de nascimento e CEP só aceita numeros
function checkPattern (element) {
  const pattern = "[0-9]";
  const char = String.fromCharCode(element.keyCode);
  if (char.match(pattern)) {
    return true;
  }
}

// Valida Data de nascimento só aceita numeros
inputs[5].addEventListener("keypress", (element) => {
  if (!checkPattern(element))
    element.preventDefault();
});

// Valida CEP só aceita numeros
inputs[7].addEventListener("keypress", (element) => {
  if (!checkPattern(element))
    element.preventDefault();
});