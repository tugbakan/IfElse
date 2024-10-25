// Saate göre selamlama 

    int time=DateTime.Now.Hour;


    if(time>=6 && time < 12)
    {
        Console.WriteLine("Günaydın");
    }
    else if(time<=18)
    {
        Console.WriteLine("İyi Günler");
    }
    else
    {
        Console.WriteLine("İyi akşamlar");
    }

    //Ternary 
    
    string sonuc = time <=18 ? "İyi Günler" : "İyi Akşamlar";
    sonuc= time >= 6 && time < 12 ? "Günaydın!" : time <=18 ? "İyi Günler":"İyi Akşamlar";

    Console.WriteLine(sonuc);