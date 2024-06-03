//default values
var dez =10;
var cem = 100;
var weight = 0.7;
var exameWeight = 0.3;
var minima = 95;
var decima = 0.01;
var totalSecundario = dez;
var totalIngresso=dez;
var mediaCifPortugues = dez;
var mediaCifEduFisica = dez;
var mediaCifFilosofia = dez;
var mediaCifLingua = dez;
var mediaCifTrienal = dez;
var mediaCifBienal = dez;
var mediaCifBienalI = dez;
var mediaCifAnual = dez;
var mediaCifAnualI = dez;


document.getElementById('media').innerHTML = dez.toFixed(2);

var mediaSecundario = document.getElementById('media');
var mediaIngresso = document.getElementById('media-ingresso');
var mediaDesportoIngresso = document.getElementById('media-desporto');
var weightExamBox = document.getElementById('exameWeight');

//Realizou exame final da disciplina? Se sim ativa checkbox da coluna 'EXAME NACIONAL', com ajuda do 'adicionarInputExame' 
//adiciona um campo numerico para inserir nota de exame
document.addEventListener("DOMContentLoaded", function() {
    var disciplinas = document.querySelectorAll('.checkboxDisciplina');

    disciplinas.forEach(function(checkbox){
        checkbox.addEventListener("change", function(){
            var inputField = document.getElementById('input' + this.dataset.disciplina);
            var provaIngresso = document.getElementById('check' + this.dataset.disciplina);
            if(this.checked){
                adicionarInputExame(inputField, this.dataset.disciplina);
                var exame = document.getElementById('exame' + this.dataset.disciplina);
                exame.addEventListener("change", function(){
                    console.log(exame.value);
                    if(exame.value < minima){
                        provaIngresso.disabled = true;
                    }
                });
            }else{
                removerInputExame(this.dataset.disciplina);
            }
        });
    });


    // Exame selecionado
    function adicionarInputExame(inputField, disciplina){
        var inputsContainer = document.getElementById('form' + inputField.dataset.disciplina);
        var provaIngresso = document.getElementById('check' + inputField.dataset.disciplina);
        inputField = document.createElement("input");
        inputField.setAttribute("type", "number");
        inputField.setAttribute("min", 0);
        inputField.setAttribute("value",100);
        inputField.setAttribute("max", 200);
        inputField.setAttribute("class", "center");
        inputField.setAttribute("id", "exame" + disciplina);
        inputField.setAttribute("onchange", "calcular()");
        inputsContainer.appendChild(inputField);
        provaIngresso.disabled = false;
    }
});

function removerInputExame(disciplina) {
    var formField = document.getElementById('exame' + disciplina);
    var provaIngresso = document.getElementById('check' + disciplina);
    if (formField) {
        formField.remove();
        provaIngresso.disabled = true;
        provaIngresso.checked = false;
    }
}

function calcular(){

    var decimoPortugues = parseFloat(document.getElementById('decimoPortugues').value);
    var decimoPrimPortugues = parseFloat(document.getElementById('decimoPrimPortugues').value);
    var decimoSegPortugues = parseFloat(document.getElementById('decimoSegPortugues').value);

    var decimoEduFisica = parseFloat(document.getElementById('decimoEduFisica').value);
    var decimoPrimEduFisica = parseFloat(document.getElementById('decimoPrimEduFisica').value);
    var decimoSegEduFisica = parseFloat(document.getElementById('decimoSegEduFisica').value);

    var decimoFilosofia = parseFloat(document.getElementById('decimoFilosofia').value);
    var decimoPrimFilosofia = parseFloat(document.getElementById('decimoPrimFilosofia').value);

    var decimoLingua = parseFloat(document.getElementById('decimoLingua').value);
    var decimoPrimLingua = parseFloat(document.getElementById('decimoPrimLingua').value);

    var decimoTrienal = parseFloat(document.getElementById('decimoTrienal').value);
    var decimoPrimTrienal = parseFloat(document.getElementById('decimoPrimTrienal').value);
    var decimoSegTrienal = parseFloat(document.getElementById('decimoSegTrienal').value);

    var decimoBienal = parseFloat(document.getElementById('decimoBienal').value);
    var decimoPrimBienal = parseFloat(document.getElementById('decimoPrimBienal').value);

    var decimoBienalI = parseFloat(document.getElementById('decimoBienalI').value);
    var decimoPrimBienalI = parseFloat(document.getElementById('decimoPrimBienalI').value);

    var decimoSegAnual = parseFloat(document.getElementById('decimoSegAnual').value);

    var decimoSegAnualI = parseFloat(document.getElementById('decimoSegAnualI').value);

    var weightExamBox = document.getElementById('exameWeight');
    var weightExam = document.getElementById('exameWeight').value;
    var weightDisciplina = cem - weightExam;

    var examePortugues = document.getElementById('examePortugues').value;

    if(document.getElementById('exameFilosofia') !== null){
        var exameFilosofia = document.getElementById('exameFilosofia').value;
    }

    if(document.getElementById('exameTrienal') !== null){
        var exameTrienal = document.getElementById('exameTrienal').value;
    }

    if(document.getElementById('exameBienal') !== null){
        var exameBienal = document.getElementById('exameBienal').value;
    }

    if(document.getElementById('exameBienalI') !== null){
        var exameBienalI = document.getElementById('exameBienalI').value;
    }

    var checkPortugues = document.getElementById('checkPortugues');
    var checkFilosofia = document.getElementById('checkFilosofia');
    var checkTrienal = document.getElementById('checkTrienal');
    var checkBienal = document.getElementById('checkBienal');
    var checkBienalI = document.getElementById('checkBienalI');

    var checkExameFilosofia = document.getElementById('inputFilosofia');
    var checkExameTrienal = document.getElementById('inputTrienal');
    var checkExameBienal = document.getElementById('inputBienal');
    var checkExameBienalI = document.getElementById('inputBienalI');

    var counterExames = 0;
    //selecao exameNacional
    let arrayExams = [0,0,0,0,0];

    if(checkExameFilosofia.checked){
        arrayExams[1]=1;
    }

    if(checkExameTrienal.checked){
        arrayExams[2]=1;
    }

    if(checkExameBienal.checked){
        arrayExams[3]=1;
    }

    if(checkExameBienalI.checked){
        arrayExams[4]=1;
    }

    //selecao ProvasIngresso
    let arrayProvas = [0,0,0,0,0];

    let sumExames = 0;
    if(checkPortugues.checked){
        addMedias();
        arrayProvas[1]=1;
        sumExames = adicionar(sumExames,examePortugues);
        counterExames++;
    }

    if(checkFilosofia.checked){
        addMedias();
        arrayProvas[1]=1;
        sumExames = adicionar(sumExames,exameFilosofia);
        counterExames++;
    }

    if(checkTrienal.checked){
        addMedias();
        arrayProvas[2]=1;
        sumExames = adicionar(sumExames,exameTrienal);
        counterExames++;
    }

    if(checkBienal.checked){
        addMedias();
        arrayProvas[3]=1;
        sumExames = adicionar(sumExames,exameBienal);
        counterExames++;
    }

    if(checkBienalI.checked){
        addMedias();
        arrayProvas[4]=1;
        sumExames = adicionar(sumExames,exameBienalI);
        counterExames++;
    }

    //MEDIA CIF
    mediaCifPortugues = calculaPortugues(decimoPortugues,decimoPrimPortugues,decimoSegPortugues);
    mediaCifEduFisica = calculaEduFisica(decimoEduFisica,decimoPrimEduFisica,decimoSegEduFisica);
    mediaCifFilosofia = calculaFilosofia(arrayExams,decimoFilosofia,decimoPrimFilosofia);
    mediaCifLingua = calculaLingua(decimoLingua,decimoPrimLingua);
    mediaCifTrienal = calculaTrienal(arrayExams,decimoTrienal,decimoPrimTrienal,decimoSegTrienal);
    mediaCifBienal = calculaBienal(arrayExams,decimoBienal,decimoPrimBienal);
    mediaCifBienalI = calculaBienalI(arrayExams,decimoBienalI,decimoPrimBienalI);
    mediaCifAnual = decimoSegAnual;
    mediaCifAnualI = decimoSegAnualI;

    //MEDIA FINAL SECUNDARIO S/ EDU. FÍSICA

    totalSecundario = (calculaPortugues(decimoPortugues,decimoPrimPortugues,decimoSegPortugues) + calculaFilosofia(arrayExams, decimoFilosofia, decimoPrimFilosofia) +
        calculaBienal(arrayExams, decimoBienal, decimoPrimBienal) + calculaBienalI(arrayExams, decimoBienalI, decimoPrimBienalI) + calculaLingua(decimoLingua,decimoPrimLingua) +
        calculaTrienal(arrayExams,decimoTrienal,decimoPrimTrienal,decimoSegTrienal) + decimoSegAnual + decimoSegAnualI)/8;
    console.log(totalSecundario);
    //MEDIA FINAL SECUNDARIO C/ EDU. FÍSICA
    totalDesporto = parseFloat(((calculaPortugues(decimoPortugues,decimoPrimPortugues,decimoSegPortugues) + calculaFilosofia(arrayExams, decimoFilosofia, decimoPrimFilosofia) +
        calculaBienal(arrayExams, decimoBienal, decimoPrimBienal) + calculaBienalI(arrayExams, decimoBienalI, decimoPrimBienalI) + calculaLingua(decimoLingua,decimoPrimLingua) +
        calculaTrienal(arrayExams,decimoTrienal,decimoPrimTrienal,decimoSegTrienal) + calculaEduFisica(decimoEduFisica,decimoPrimEduFisica,decimoSegEduFisica) + decimoSegAnual +
        decimoSegAnualI)/9)).toString().match(/^\d+(?:\.\d{0,1})?/);

    //media acesso ens. sup.
    totalIngresso = calculaSecundario(totalSecundario,weightDisciplina,sumExames, counterExames, weightExam);
    totalDesporto = calculaDesporto(totalDesporto, weightDisciplina, sumExames, counterExames, weightExam);



    //read

    var cifPortugues = document.getElementById('cifPortugues');
    var cifEduFisica = document.getElementById('cifEduFisica');
    var cifFilosofia = document.getElementById('cifFilosofia');
    var cifLingua = document.getElementById('cifLingua');
    var cifTrienal = document.getElementById('cifTrienal');
    var cifBienal = document.getElementById('cifBienal');
    var cifBienalI = document.getElementById('cifBienalI');
    var cifAnual = document.getElementById('cifAnual');
    var cifAnualI = document.getElementById('cifAnualI');

    console.log((Math.floor(totalSecundario * 10) / 10));
    //write
    mediaSecundario.innerHTML = (Math.floor(totalSecundario * 10) / 10)*dez;

    if(!isNaN(totalIngresso) && !isNaN(totalDesporto)){
        mediaIngresso.innerHTML = totalIngresso.toFixed(2);
        mediaDesportoIngresso.innerHTML = totalDesporto.toFixed(2);
        weightExamBox.style.display = "inline";
    }else{
        mediaIngresso.innerHTML = "";
        mediaDesportoIngresso.innerHTML = "";
        weightExamBox.style.display = "none";
    }

    cifPortugues.value= mediaCifPortugues;
    cifEduFisica.value= mediaCifEduFisica;
    cifFilosofia.value= mediaCifFilosofia;
    cifLingua.value= mediaCifLingua;
    cifTrienal.value= mediaCifTrienal;
    cifBienal.value= mediaCifBienal;
    cifBienalI.value= mediaCifBienalI;
    cifAnual.value= mediaCifAnual;
    cifAnualI.value= mediaCifAnualI;
};

function limpar(){
    document.getElementById('decimoPortugues').value = dez;
    document.getElementById('decimoPrimPortugues').value = dez;
    document.getElementById('decimoSegPortugues').value = dez;

    document.getElementById('decimoEduFisica').value = dez;
    document.getElementById('decimoPrimEduFisica').value = dez;
    document.getElementById('decimoSegEduFisica').value = dez;

    document.getElementById('decimoFilosofia').value = dez;
    document.getElementById('decimoPrimFilosofia').value = dez;

    document.getElementById('decimoLingua').value = dez;
    document.getElementById('decimoPrimLingua').value = dez;

    document.getElementById('decimoTrienal').value = dez;
    document.getElementById('decimoPrimTrienal').value = dez;
    document.getElementById('decimoSegTrienal').value = dez;

    document.getElementById('decimoBienal').value = dez;
    document.getElementById('decimoPrimBienal').value = dez;

    document.getElementById('decimoBienalI').value = dez;
    document.getElementById('decimoPrimBienalI').value = dez;

    document.getElementById('decimoSegAnual').value = dez;

    document.getElementById('decimoSegAnualI').value = dez;

    document.getElementById('media').innerHTML = dez.toFixed(2);

    document.getElementById('cifPortugues').value = dez;
    document.getElementById('cifEduFisica').value = dez;
    document.getElementById('cifFilosofia').value = dez;
    document.getElementById('cifLingua').value = dez;
    document.getElementById('cifTrienal').value = dez;
    document.getElementById('cifBienal').value = dez;
    document.getElementById('cifBienalI').value = dez;
    document.getElementById('cifAnual').value = dez;
    document.getElementById('cifAnualI').value = dez;

    let disciplinas = ["Filosofia", "Trienal", "Bienal", "BienalI"];

    disciplinas.forEach(disciplina =>
        removerInputExame(disciplina));

    document.getElementById('inputFilosofia').checked = false;
    document.getElementById('inputTrienal').checked = false;
    document.getElementById('inputBienal').checked = false;
    document.getElementById('inputBienalI').checked = false;


    document.getElementById('checkPortugues').checked = false;
    document.getElementById('checkFilosofia').checked = false;
    document.getElementById('checkTrienal').checked = false;
    document.getElementById('checkBienal').checked = false;
    document.getElementById('checkBienalI').checked = false;

    mediaDesportoIngresso.innerHTML = "";
    mediaIngresso.innerHTML = "";
    weightExamBox.style.display = "none";
};

function addMedias(){
    document.getElementById('media-desporto').innerHTML = dez.toFixed(2);
    document.getElementById('media-ingresso').innerHTML = dez.toFixed(2);
};

function calculaPortugues(decimo,decimoPrim,decimoSeg){

    var total = 0;

    var exame = document.getElementById('examePortugues').value;
    total = (((decimo+decimoPrim+decimoSeg)/3)*weight) + ((exame*exameWeight)/dez)

    return parseInt(total.toFixed(0));
};

function calculaLingua(decimo,decimoPrim){

    var total = 0;

    total = (decimo + decimoPrim)/2
    console.log(total.toFixed(0));
    return parseInt(total.toFixed(0));
};

function calculaEduFisica(decimo,decimoPrim,decimoSeg){

    var total = 0;

    total = (decimo + decimoPrim + decimoSeg)/3

    return parseInt(total.toFixed(0));
};

function calculaTrienal(arrayExams,decimo,decimoPrim,decimoSeg){

    var total = 0;

    if(arrayExams[2]==1){
        var exame = document.getElementById('exameTrienal').value;
        total = (((decimo+decimoPrim+decimoSeg)/3)*weight) + ((exame*exameWeight)/dez);
    }else{
        total = (decimo+decimoPrim+decimoSeg)/3;
    }

    return parseInt(total.toFixed(0));
};

function calculaFilosofia(arrayExams,decimo,decimoPrim){

    var total = 0;

    if(arrayExams[1]==1){
        var exame = document.getElementById('exameFilosofia').value;
        total = (((decimo+decimoPrim)/2)*weight) + ((exame*exameWeight)/dez);
    }else{
        total = (decimo+decimoPrim)/2
    }

    return parseInt(total.toFixed(0));
};

function calculaBienal(arrayExams,decimo,decimoPrim){

    var total = 0;

    if(arrayExams[3]==1){
        var exame = document.getElementById('exameBienal').value;
        total = (((decimo+decimoPrim)/2)*weight) + ((exame*exameWeight)/dez);
    }else{
        total = (decimo+decimoPrim)/2;
    }

    return parseInt(total.toFixed(0));
};

function calculaBienalI(arrayExams,decimo,decimoPrim){

    var total = 0;

    if(arrayExams[4]==1){
        var exame = document.getElementById('exameBienalI').value;
        total = (((decimo+decimoPrim)/2)*weight) + ((exame*exameWeight)/dez);
    }else{
        total = (decimo+decimoPrim)/2;
    }

    return parseInt(total.toFixed(0));
};

function calculaSecundario(totalSecundario, weightDisciplina, sumExames, counterExames, weightExam){
    var total = (totalSecundario * (weightDisciplina*decima)) + ((((sumExames/counterExames)/dez) * (weightExam*decima)));
    return total;
};

function calculaDesporto(totalDesporto, weightDisciplina, sumExames, counterExames, weightExam){
    var total = (totalDesporto * (weightDisciplina*decima)) + ((((sumExames/counterExames)/dez) * (weightExam*decima)));
    return total;
};

function adicionar(sumExames, exame){
    sumExames = parseInt(sumExames, 10);
    exame = parseInt(exame, 10);
    return sumExames + exame;
};
