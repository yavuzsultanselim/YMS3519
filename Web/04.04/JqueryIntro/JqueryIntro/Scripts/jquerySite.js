//sayfa yüklendiği anda tüm fonksiyonların çalışmaya hazır olması için $(document).ready(function(){}) kullanmamız gerekli.
$(document).ready(function () {
    $("#bir").click(function () {
        //alert(1);
        $("#metin").html('Merhaba Jquery');
        $('p').html('Merhaba Jquery');
      
    });
    $("#iki").click(function () {
        $('p').html('');
        $('p#metin1').html('Merhaba Jquery');
    });
    $("#uc").click(function () {
        $('p').html('');
        //id'si metin1 ve metin2 olan p'lerin html içeriğini değiştirme.
        $('p#metin1,p#metin2').html('Merhaba Jquery');
    });
    $("#dort").click(function () {
        $('p').html('');
        //lang attribute'u tr olan elementlerin html içeriğini değiştirme.
        $('p[lang=tr]').html('Merhaba Jquery');
        
    });

    $("#bes").click(function () {
        $('p').html('');
        //lang attribute'u tr ve en olan elementlerin html içerğini değiştirme.
        $('p[lang=tr],[lang=en]').html('Merhaba Jquery');
    });

    $("#alti").click(function () {
        $('p').html('');
       //Lang attribute u en ve id attribute'u metin2 olan elementin html içeriğini değiştirme.
        //$('p[id=metin2],[lang=en]').html('Merhaba Jquery');
        $('p[lang=en],#metin2').html('Merhaba Jquery');
    });

    $("#yedi").click(function () {
        $('p').html('');
       //id'si metin3 olmayan elementlerin html içeriğini değiştirme.
        $('p[id!=metin3]').html('merhaba Jquery');
        
      
    });
});
