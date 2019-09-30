$(document).ready(function(){
$("#btnCadastro").on('click', function(){

    var jogo = {};
    jogo["nomeJogo"] = $("#nomeJogo").val();
    jogo["precoJogo"] = $("#precoJogo").val();
    jogo["generoJogo"] = $("#generoJogo").val();
    jogo["dataCompra"] = $("#dataCompra").val();

    $.ajax({
        url: $(this).attr("data-url"),
        data: jogo,
        type: "POST",
});





//var jogo = class {
//    constructor(nomeJogo, precoJogo, generoJogo, dataCompra) {
//        this.nomeJogo = nomeJogo;
//        this.precoJogo = precoJogo; 
//        this.generoJogo = generoJogo;
//        this.dataCompra = dataCompra;
//    }
//};
//function checagem() {
//    var checar = document.getElementById("nomeJogo").value;
//    var texto = eval("checar");
//    if (texto == null || texto == "") {
//        alert("O campo nome não foi preenchido!");
//    }
//    else {

//        jogoJson = new jogo();
//        jogoJson.nomeJogo = texto;
//        jogoJson.precoJogo = document.getElementById("precoJogo").value;
//        jogoJson.generoJogo = document.getElementById("generoJogo").value;
//        jogoJson.dataCompra = document.getElementById("dataCompra").value;

//        json = JSON.stringify(jogoJson);//gerou um json, o "stringify" disse que é do tipo string

//        $.ajax({
//            type: 'POST',
//            url: "/jogoes/Create",
//            //contentType: 'application/json; charset=utf-8',
//            //data: { "valor": 10 },
//            success: function(data){
//                alert(data);
//            },
//            error: function (ex) {
//                alert("Error!");
//            }
//        });
//    }