$(document).ready(function(){
    var nopeus = 500;
    var autoswitch = true;
    var autoswitch_nopeus = 4000;

    $('.slide').first().addClass('active');
    $('.slide').hide();
    $('.active').show();

    $('#next').on('click', seuraavaDia);
    $('#prev').on('click', edellinenDia);

    if(autoswitch == true)
    {
        setInterval(seuraavaDia, autoswitch_nopeus);
    }

    function seuraavaDia(){
        $('.active').removeClass('active').addClass('oldActive');
        if($('.oldActive').is(':last-child'))
        {
            $('.slide').first().addClass('active');
        }
        else
        {
            $('.oldActive').next().addClass('active');
        }
        $('.oldActive').removeClass('oldActive');
        $('.slide').fadeOut(nopeus);
        $('.active').fadeIn(nopeus);
    }

    function edellinenDia(){
        $('.active').removeClass('active').addClass('oldActive');
        if($('.oldActive').is(':first-child'))
        {
            $('.slide').last().addClass('active');
        }
        else
        {
            $('.oldActive').prev().addClass('active');
        }
        $('.oldActive').removeClass('oldActive');
        $('.slide').fadeOut(nopeus);
        $('.active').fadeIn(nopeus);
    }

});
    