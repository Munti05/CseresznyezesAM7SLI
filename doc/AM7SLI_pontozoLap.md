# Pontozó Lap
**Név:** Muntean Áron

**Neptun:** AM7SLI
## Projekt rövid leírása
Az alkalmazásom weboldalán vinly lemezeket lehet megjeleníteni, és törölni az adatbázisból. A swagger-es felületen a felhasználókat és a vinyl-eket tudjuk részletesebben kezelni. A forms-os felületen pedig csak megtekinthetjük szintén a felhasználókat és a vinyl-ekt részletesebben.
> Megjegyzésként hozzáfűzném, hogy a kész projektemet nem sikerült VS-ben push-olnom a repository-mhoz, ezért sajnos manuálisan vittem fel a fájlokat `drag and drop` módszerrel és így nem tudtam egybe felmásolni az egészet (azt hiszem egyszerre csak 100 fájlt tudtam) ezért a github repository-mban nagyon összevissza vannak a dolgok. Elnézést, a kellemetlenségért, a screenshot-ok és a GIF-ek ezzel a markdown fájlal együtt, a `doc` nevű mappában találhatóak
## Hozott anyagok
### Saját adatbázis

![Adatbázis struktúra](https://github.com/Munti05/CseresznyezesAM7SLI/blob/01b86bb374f8a06b5e55a36e073a021374ee9eef/doc/database_structure.png)
> Az adatbázishoz az SQL scripteket ChatGPT segítségével generáltam, részletes leírást adtam neki minden tábláról és táblánként az oszlopok tulajdonságáról. Ezeket aztán lefuttattam Azure Data Studio-ba miközbe hozzá voltam csatlakozva az Azure Portal-on létrehozott adatbázisomhoz. Így létrejött az adatbázisom, amit a connection string-el el lehet érni már bárhonnan. Az adatbázisnak három táblája van: VINYLS néven a lemezeket és azok leírását tartalmazó tábla, USERS néven a felhasználókat leíró tábla és COLLETION néven, ahol pedig a felhasználókat kötöttem össze az általuk birtokolt lemezekkel.

- `2x1 pont` Az alkalmazásban használt táblák (USERS, VINYLS)
-   `1x1 pont`  Az adatbázis tartalmaz Constraint-eket (min 2)
-   `1x1 pont`  Az adatbázis adatainak forrásmegjelölése értsd (fentebb található)
-   `1x2 pont`  Az adatbázis saját Azure SQL szerveren van

Részpont: **`6 pont`** 

Összesen: ==**6 pont**==


### Weboldal
![Weboldal megjelenése](https://github.com/Munti05/CseresznyezesAM7SLI/blob/2deb6c68108140364ae4a3c492031d1945e208cd/doc/html_default.png)
-   `1x1 pont`  A weboldalnak van egy értelmezhető struktúrája
-   `1x1 pont`  A weboldal dinamikus tartalommal tölthető fel adatbázison keresztül
-   `1x1 pont`  A weboldal használ legalább 20 sor értelmes css-t
-   `1x1 pont`  A weboldal javascriptje más funkciót is ellát, mint az adatok betöltése (betöltés és ID alapján törlés)

Részpont: **`4 pont`**

Összesen: ==**10 pont**==
## Windows Forms Application
### User Interface
-   `1x2 pont`  Az alkalmazásból a  **kilépés csak megerősítő kérdés után**  lehetséges. (későbbi GIF-en látható)
-   `2x2 pont`  Olyan alkalmazás  **elrendezés, melyben gombok lenyomására UserControl-ok kerülnek elhelyezésre egy Panel vezérlőben**, teljesen kitöltve azt. Minden gombra jár a pont, amennyiben az funckuonlalitással rendelkező UserControl-t tölt be. (Vinyls és Users UserControl-ok, későbbi GIF-en látható)
-   `1x2p`  **Anchorok alkalmazása**: az alkalmazás egészében meg van oldva, hogy az ablak átméretezésekor ki legyen használva a rendelkezésre álló terület. (a UserControl-okon és a Forms-on is egyaránt használom, későbbi GIF-en látható)

Részpont: **`8 pont`**

Összesen: ==**18 pont**==
### Tábla adatainak megjelenítése  `ListBox`-ban.
![Felhasználónevek megjelenítése, szűrése, anchor-ok és a bezárásnál megerősítés kérése](https://github.com/Munti05/CseresznyezesAM7SLI/blob/2deb6c68108140364ae4a3c492031d1945e208cd/doc/forms_users.gif)
-   `1x2 pont`  Adatok megjelenítése (Felhasználónevek megjelenítése)
-   `1x2 pont`  Az adatok tetszőleges módszerrel, pl. `TextBox`-on keresztül szűrhetőek. (A felhasználónevek szűrhetőek)

Részpont: **`4 pont`**

Összesen: ==**22 pont**==

### Tábla adatainak megjelenítése  `DataGridView`-ban
![Vinyl-ek megjelenítése](https://github.com/Munti05/CseresznyezesAM7SLI/blob/2deb6c68108140364ae4a3c492031d1945e208cd/doc/forms_vinyls.png)
-   `1x2p`  Adatok megjelenítése (Vinyl-ek megjelenítése)

Részpont: **`2 pont`**

Összesen: ==**24 pont**==
### Adatkötés  `BindingSource`  -on keresztül
-   `1x2 pont`  Működő  `BindingSource` (mind a User-ek mind a Vinyl-ek megjelenítéséhez használtam)

Részpont: **`2 pont`**

Összesen: ==**26 pont**==
## ASP .NET

ASP .NET alkalmazás, melyet lehet a Forms alapú projekttel közös solution-ben létrehozni.

-   `1x2 pont`  `program.cs`  beállítása  `wwwroot`  mappában tárolt statikus tartalmak megosztására

Részpont: **`2 pont`**

Összesen: ==**28 pont**==

### API végpontok
![Swagger kezdőképernyő](https://github.com/Munti05/CseresznyezesAM7SLI/blob/2deb6c68108140364ae4a3c492031d1945e208cd/doc/swagger_default_page.png)
Ezen a GIF-en a Users táblához tartozó API végpontok működését mutatom be (nem működő szerepel a viedóban, de az elnevezések egyértelműek).
![Swagger users: get all, get by id, delete, post modify](https://github.com/Munti05/CseresznyezesAM7SLI/blob/2deb6c68108140364ae4a3c492031d1945e208cd/doc/swagger_user_get_delete_postUpdate.gif)
Itt a Vinlys táblához írtam meg az API végpontokat (nincs minden működő funkció bemutatva a GIF-ben), az elnevezések magától értetődnek. (Az új lemez felvételét úgy oldottam, meg, hogy nem állítottam be kötelező paraméternek, azokat az attribútumokat, amiket az SQL megszorítások szerint nem kötelező megadni.)
![Swagger vinyls: get all, get by id, post new](https://github.com/Munti05/CseresznyezesAM7SLI/blob/2deb6c68108140364ae4a3c492031d1945e208cd/doc/swagger_viny_get_getById_postNew.gif)
-   `1x3 pont`  Teljes SQL tábla adatainak szolgáltatása API végponton keresztül (Users, Vinyls)
-   `2x2 pont`  SQL tábla egy választható rekordjának szolgáltatása API végponton keresztül (Users, Vinyls)
-   `1x3 pont`  SQL tábla egy választható rekordjának törlése (Users, Vinyls)
-   `1x5 pont`  Új rekord felvétele  `HttpPost`  metóduson keresztül SQL táblába (Users, Vinyls)
-   `1x3 pont`  Rekord módosítása  `HttpPost`  metóduson keresztül SQL táblában (Users)

Részpont: **`18 pont`**

Összesen: ==**46 pont**==
### Javascript
![HTML oldal betöltve és ID alapján törlés](https://github.com/Munti05/CseresznyezesAM7SLI/blob/c154979b3d41c69057082ec5aabdb9a08c544bc3/doc/html_mukodese.gif)
-   `1x5 pont`  DOM feltöltése javascripttel (A táblázat feltöltése, valamint a törlés megvalósítása. Itt nem volt egyértelmű nekem, hogy mire lehet kapni 2x5 pontot, így csak 5 pontot adtam magamnak.)

Részpont: **`5 pont`**

Összesen: ==**51 pont**==
### Egyéb,  extra
-   `2x1 pont`  `Scaffold-DbContext`  használata (ajándék) (használom a Forms-os és a Web-es alkalmazásban is)

Részpont: **`2 pont`**

Összesen: ==**53 pont**==

# *Összesen: 53 pont*
