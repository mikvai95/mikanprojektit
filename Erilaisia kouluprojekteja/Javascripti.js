function lahetaVastaukset()
{
    var yhteensa = 5;
    var pisteet = 0;
    var huom = 0;

    // Katsotaan, mit� k�ytt�j� on vastannut
    var k1 = document.forms["kyselyLomake"]["k1"].value;
    var k2 = document.forms["kyselyLomake"]["k2"].value;
    var k3 = document.forms["kyselyLomake"]["k3"].value;
    var k4 = document.forms["kyselyLomake"]["k4"].value;
    var k5 = document.forms["kyselyLomake"]["k5"].value;

    // Vastausten tarkistus
    for (i = 1; i <= yhteensa; i++)
    {
        if(eval('k'+i) == null || eval('k'+i) == '')
        {
            alert('Et vastannut kysymykseen numero: ' + i);
            huom = 1;
        }
        if (huom == 1) return false;
    }

    // Oikeat vastaukset
    var vastaukset = ["b", "a", "d", "d", "b"];

    // Oikeiden vastausten tarkistus
    for (i = 1; i <= yhteensa; i++)
    {
        if (eval('k'+i) == vastaukset[i-1])
        {
            pisteet++;
        }
    }

    // N�ytet��n tulos
    var tulokset = document.getElementById('tulokset');
    alert('Sait ' + pisteet + ' pistett�, maksimitulos olisi ollut ' + yhteensa);
    tulokset.innerHTML = '<h3>Sait <span>' + pisteet + '</span> pistett�, maksimitulos olisi ollut <span>' + yhteensa + '</span></h3>';
    return false;
}
