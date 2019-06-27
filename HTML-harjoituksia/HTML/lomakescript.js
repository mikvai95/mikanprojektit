function Tarkasta() {
var etunimi = document.forms["lomake"]["etunimi"];
var sukunimi = document.forms["lomake"]["sukunimi"];
var osoite = document.forms["lomake"]["osoite"];
var kaupunki = document.forms["lomake"]["kaupunki"];
var puhelinnumero = document.forms["lomake"]["puhelinnumero"];
var email = document.forms["lomake"]["email"];

if (etunimi.value == "") {
    window.alert("Unohdit antaa etunimesi.");
    etunimi.focus();
    return false;
}
else if(etunimi.value.length < 3)  {
    window.alert("Anna kolmikirjaiminen etunimi");
    etunimi.focus();
    return false;
}
if (sukunimi.value == "") {
    window.alert("Unohdit antaa sukunimesi.");
    sukunimi.focus();
    return false;
}
if (osoite.value == "") {
    window.alert("Unohdit antaa osoitteesi.");
    osoite.focus();
    return false;
}
if (kaupunki.value == "") {
    window.alert("Unohdit antaa kaupunkisi.");
    kaupunki.focus();
    return false;
}
if (puhelinnumero.value == "") {
    window.alert("Unohdit antaa puhelinnumerosi.");
    puhelinnumero.focus();
    return false;
}
if (email.value == "") {
    window.alert ("Unohdit antaa emailin.");
    email.focus();
    return false;
}
else if (email.value.indexOf("@", 0) < 0) {
    window.alert ("Anna toimiva email.");
    email.focus();
    return false;
}
else if (email.value.indexOf(".", 0) < 0) {
    window.alert("Emailissa tulee olla ainakin yksi piste.");
    email.focus();
}
}