using babolnai_bence_dolgozat_241202;

List<Book> books = new List<Book>();

List<string> titles = new List<string>();
List<string> hungarian_title = new List<string>();
List<string> authors = new List<string>();
List<string> hungarian_authors = new List<string>();

foreach (var item in "Demi-Leigh Hoover\r\nMaariyah Humphrey\r\nYahya Parrish\r\nMaxim Arroyo\r\nIsobelle Daniel\r\nAnaya O'Quinn\r\nEoin Conway\r\nDanielle Walker\r\nAriana Porter\r\nBetsy Carney\r\nCain Ali\r\nMaariyah Brown\r\nEla Carroll\r\nBrendon Dickerson\r\nKelly Wall\r\nKyla Perry\r\nAlysha Hughes\r\nAditya Andrade\r\nRosalie French\r\nEdward Newman\"".Split("\r\n"))
{
    authors.Add(item);
}
foreach(var item in "Ács Milán\r\nAcél Azár\r\nAcél Kardos\r\nAcél Kürt\r\nAcél Tarcsa\r\nAcél Titán\r\nAcél Üllő\r\nAcél Vértes Levente\r\nAkó Bora\r\nAkó Ivó\r\nAlapi Csaba\r\nÁldott Aura\r\nAlföldi Aura\r\nAlföldi Délibáb\r\nAlka Ida\r\nAlle Glória\r\nÁlló Csillag\r\nÁlló Farkas\r\nÁlló Ella\r\nÁlló Illa\r\nÁlmos Előd Ond\r\nÁlmos Kürt\r\nAndriska Kálmán\r\nAngyal Alett\r\nAngyal Gábriel\r\nAngyal Rafael\r\nAngyal Uriel\r\nApai Ajándék\r\nApai Áldáska\r\nApró Ajándék\r\nApró Alma\r\nApró Berill".Split("\r\n")){
    hungarian_authors.Add(item);
}
foreach (var item in "1. Element of Joy\r\n2. Blood in The Beginning\r\n3. Cattles And Horses\r\n4. Ancestry with Honor\r\n5. The Magic Tree\r\n6. Trees and Criminals\r\n7. Love of Tomorrow\r\n8. Never The Same\r\n9. Cursed Queen\r\n10. The Lost Portrait\r\n11. The Unwanted Toy\r\n12. One Spell Away\r\n13. Kicking the Emperor\r\n14. Inspiration of The Eclipse\r\n15. Rise Without Flaws\r\n16. Changeling of Reality\r\n17. Snow This Christmas\r\n18. My Neighbour The Alien\r\n19. Blacksmiths and Heroes\r\n20. Escape the Commander\r\n21. Signs of Life on Jupiter\r\n22. Cupcake Kitty\r\n23. Changing the Castle\r\n24. Burning The Breeze\r\n25. Opponent of The Nation\r\n26. Fire And Water\r\n27. Changing History\r\n28. Night Light\r\n29. Chase Without Fear\r\n30. One Way Ride\r\n31. Fire And Water\r\n32. Companions and Blacksmiths\r\n33. Rise of The Lost Ones\r\n34. Sword of Glory\r\n35. Rebels of The Plague\r\n36. Together For A Day\r\n37. Ninja Cats Rescue Mission\r\n38. The Strange Key\r\n39. Who Stole My Homework?\r\n40. Who Were They?\r\n41. Calling the Jungle\r\n42. Foes and Snakes\r\n43. Spear of Gold\r\n44. Trees and Criminals\r\n45. Vengeance of The Forsaken\r\n46. Priest of Heaven\r\n47. Rain On Those\r\n48. Monster Strike\r\n49. Achievement of Yesterday\r\n50. Before The Past\r\n51. King of Hell\r\n52. Nice Try John\r\n53. Fade into The Future\r\n54. The Cover Up\r\n55. Ruination of Dread\r\n56. Extinction of The Sea\r\n57. Wizards of Ice\r\n58. Going to Myself\r\n59. Once Upon A Rat\r\n60. Dragon Invasion\r\n61. Miss Minnie And The Bees\r\n62. Border with A Goal\r\n63. Season For Revenge\r\n64. Rejecting My Dreams\r\n65. Slay Like a Princess\r\n66. Dark New World\r\n67. Hero with Gold\r\n68. Mysterious Cyborg\r\n69. Skeletons in the House\r\n70. World of Yesterday\r\n71. Riders Of The West\r\n72. The Meaning of Z\r\n73. Future of My Imagination\r\n74. Element of Joy\r\n75. Victory of The Night\r\n76. Humans and Cats\r\n77. Message in a Bottle\r\n78. Fear Of Those\r\n79. Rain On Those\r\n80. Symbols in My Leader\r\n81. Tales of the Heart\r\n82. Arealia, Forest Princess\r\n83. The Unwanted Toy\r\n84. Earth To Unknown\r\n85. Get Away And Run Away\r\n86. Time Lies\r\n87. Knights and Invaders\r\n88. Origin of My Family\r\n89. Shelter at The East\r\n90. The Unwanted Toy\r\n91. Horror Stories In The Dark\r\n92. Guardians of Glory\r\n93. Child of The Plague\r\n94. Wolf of Rainbows\r\n95. Admiring Dreams\r\n96. Losing Eternity\r\n97. Lone Cowboy\r\n98. An Elephant’s Journey\r\n99. World of Tomorrow\r\n100. Savior of Wood".Split("\r\n"))
{
    titles.Add(item.Split(".")[1]);
}
foreach (var item in "1. Örömelem\r\n2. Vér a kezdetekben\r\n3. Szarvasmarhák és lovak\r\n4. Becsületes ősök\r\n5. A varázsfa\r\n6. Fák és bűnözők\r\n7. A holnap szerelem\r\n8. Az elátkozott királynő\r\n10. Portré\r\n12. Egy varázslat\r\n14. Az Eclipse inspirációja\r\n17. Hó ezen a karácsonyon\r\n18. A kovácsok és a Hősök\r\n21. Az élet jelei a Jupiteren\r\n23. Az égő szellő A nemzet\r\n26. Változó történelem\r\n28. Chase Without Fear\r\n31. Tűz és víz\r\n33. A dicsőség kardja. A pestis lázadói\r\n36. Egy napra: Ninja Cats Rescue Küldetés\r\n38. A furcsa kulcs\r\n39. Ki lopta el a házi feladatomat?\r\n40. Kik voltak?\r\n41. A dzsungel hívása\r\n42. Ellenségek és kígyók\r\n43. Aranylándzsa\r\n44. Fák és bűnözők\r\n45. Az elhagyottak bosszúja\r\n46. Mennyország papja\r\n47. Eső azokon\r\n48. Monster Strike\r\n49. A tegnapi nap eredménye\r\n50. A múlt előtt\r\n51. A pokol királya\r\n52. Szép Próbálja ki Johnt\r\n53. Eltűnni a jövőbe\r\n54. Az elfedés\r\n55. A rettegés tönkretétele\r\n56. A tenger kihalása\r\n57. A jég varázslói\r\n58. Megyek magamhoz\r\n59. Once Upon A Rat\r\n60. Sárkányinvázió\r\n61. Miss Minnie és a méhek\r\n62. Határ egy góllal\r\n63. A bosszúévad\r\n64. Álmaim elutasítása\r\n65. Ölj meg, mint egy hercegnőt\r\n66. Sötét új világ\r\n67. Hős arannyal\r\n68. A titokzatos kiborg\r\n69. Csontvázak a házban\r\n70. A tegnap világa\r\n71. A Nyugat lovasai\r\n72. A Z jelentése\r\n73. Képzeletem jövője\r\n74. Öröm elem\r\n75. Az éjszaka győzelme\r\n76. Emberek és macskák\r\n77. Üzenet palackban\r\n78. Félelem azoktól\r\n79. Eső azokon\r\n80. Szimbólumok a Vezetőmben\r\n81. A szív meséi\r\n82. Arealia, erdei hercegnő\r\n83. A nem kívánt játék\r\n84. Föld ismeretlenig\r\n85. Szökj el és fuss el\r\n86. Az idő hazudik\r\n87. Lovagok és megszállók\r\n88. Családom eredete\r\n89. Menedék a Keleten\r\n90. A nem kívánt játék\r\n91. Horror Stories In The Dark\r\n92. A dicsőség őrzői\r\n93. A pestis gyermeke\r\n94. Szivárvány farkasa\r\n95. Csodálatos álmok\r\n96. Az örökkévalóság elvesztése\r\n97. Magányos Cowboy\r\n98. Egy elefánt utazása\r\n99. A holnap világa\r\n100. A fa megmentője".Split("\r\n"))
{
    hungarian_title.Add(item.Split(".")[1]);
}

for (int i = 0; i < 15; i++)
{
    long isbn = Random.Shared.NextInt64(1000000000, 9999999999);
    string language = "";
    int stock = 0;
    string name = "";
    List<Author> fakeauthors = new List<Author>();
    if (books.Any(p => p.ISBN == isbn))
    {
        isbn = Random.Shared.NextInt64(1000000000, 9999999999);
    }
    if (Random.Shared.Next(100) < 80) language = "magyar";
    else language = "angol";
    if (Random.Shared.Next(100) < 30) stock = 0;
    else stock = Random.Shared.Next(5,10);
    if(Random.Shared.Next(100) < 70)
    {
        if(language == "angol")
        {
            name = titles[Random.Shared.Next(1, titles.Count-1)];
            fakeauthors.Add(new Author(authors[Random.Shared.Next(1, authors.Count - 1)]));
        }
        else
        {
            name = hungarian_title[Random.Shared.Next(1, hungarian_title.Count - 1)];
            fakeauthors.Add(new Author(hungarian_authors[Random.Shared.Next(1, hungarian_authors.Count - 1)]));
        }
    }
    else
    {
        for(int j = 0; j < Random.Shared.Next(1, 2); j++) {
            if (language == "angol")
            {
                name = titles[Random.Shared.Next(1, titles.Count - 1)];
                fakeauthors.Add(new Author(authors[Random.Shared.Next(1, authors.Count - 1)]));
            }
            else
            {
                name = hungarian_title[Random.Shared.Next(1, hungarian_title.Count - 1)];
                fakeauthors.Add(new Author(hungarian_authors[Random.Shared.Next(1, hungarian_authors.Count - 1)]));
            }
        }
    }
    int price = 0;
    int randomp = Random.Shared.Next(1000, 10000);
    while (randomp % 100 != 0) randomp = Random.Shared.Next(1000, 10000);
    price = randomp;
    int year = Random.Shared.Next(2007,DateTime.Now.Year);
    books.Add(new Book(isbn,name,stock,language,price,year, fakeauthors.ToArray()));
}

int osszKonyv = books.Sum(p => p.Stock);
int testossz = books.Count;
int bevetel = 0;
int kikonyv = 0;
for (int i = 0; i < 100; i++)
{
    Book book = books[Random.Shared.Next(1, books.Count - 1)];
    if (book.Stock > 1)
    {
        bevetel += book.Price;
        book.Stock -= 1;
    }
    else
    {
        if (Random.Shared.Next(100) < 50)
        {
            book.Stock += Random.Shared.Next(1, 10);
        }
        else
        {
            books.Remove(book);
            kikonyv++;
        }
    }
}

Console.WriteLine($"Eladásokból származó bruttó bevétel: {bevetel}$" +
    $"\nEnnyi könyv nem volt a nagykerbe: {kikonyv} db" +
    $"\nEladások elötti könyvek száma: {osszKonyv} ({testossz} fajta könyv) db" +
    $"\nMostani könyvek száma: {books.Sum(p=>p.Stock)} ({books.Count} fajta könyv) db" +
    $"\nEladások elött - mostani: {osszKonyv-books.Sum(p=>p.Stock)} ({testossz-books.Count} fajta könyv) db");