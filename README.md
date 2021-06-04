# FightForYourLife__WPFGame## Veres Levente- PPKMX9//Hegedűs Máté- ISGUOH

# Rövid Leírás

A játékunk lényege, hogy minél tovább jusson a főhősünk a
pályán. Ehhez blokkról blokkra kell haladnunk. Az utunk során a
blokkokon találkozhatunk szörnyekkel, ládákkal illetve érmékkel az
utóbbit a boltban tudjuk elkölteni.

A szörnyekkel a tovább haladáshoz meg kell küzdenünk. Ha sikerült
legyőznünk a szörnyet, akkor haladhatunk tovább. Harc közben
képesek vagyunk támadni illetve védekezni. Ezeket tudjuk
irányítani a billentyűzetről, illetve a UI-ról is. Támadásnál az
ellenfelünk életereje csökken a támadó erőnknek megfelelően,
sikeres védekezésnél pedig csökkentjük az ellenfél által kiosztott
sebzést.

Ha bolt mezőre lépünk, akkor lehetőségünk van fejleszteni a
támadóerőnket, védekezésünket, támadási sebességet és
visszatölthetjük életerőnket. Az itt elkölthető pénzt az utunk során
bírjuk felszedni szörnyektől vagy ládákból.

# Fejlesztői szerepkörök definiálása

ISGUOH #1: Interfészek + GameLogic + LogicTests

PPKMX9 #2: GameModel + Repository + Renderer + GameControl

# Irányítás

## Haladás:

A karakterünket a space/a UI-on található gomb segítségével
tudjuk a következő blokkra léptetni.

**Haladás feltételei:**

Ahhoz, hogy a hősünk a következő mezőre tudjon lépni, meg kell
arról győződni, hogy a következő mezőn nem áll szörny.

Amennyiben a következő mezőn boltot/ládát látunk, akkor
akadálytalanul ráléphetünk.

## Védekezés:

Karakterünk a pajzs segítségével védekezik, amelyet a felfele
nyíl/UI-on található gomb segítségével tart maga elé.

## Támadás:

Hősünk a jobbra nyíl/UI-on található gomb segítségével támad.

## UI-on található gombok koncepciója


# Karakterek leírása

Alapvetően két típusú karakter közül tudunk választani, amelyet a
játék megkezdése előtt tudunk kiválaszatni.

## #1: Light típusú karakter:

Light típusú karakterünk előnye az, hogy gyorsabban tud ütni,
azonban kevesebb armorral( 3 ), életerővel( 8 ) kezdi a játékot.

## # 2 : Heavy típusú karakter:

## Heavy típusú karakterünk hátránya az, hogy lassabban tud ütni,

## azonban több armorral( 6 ), életerővel( 12 ) kezdi a játékot.

# Blokkon lévő tárgyak

Alapvetően a blokkon, három különböző dologgal találkozhatunk:
szörnyekkel, bolttal vagy ládával.

## Szörnyek:

Amennyibben szörny található a következő blokkon, akkor addig
nem tudunk tovább haladni, amíg le nem győzzük.Két szörny típust
különböztetünk meg: Light , Heavy (illetve ha időnk engedi, akkor
több fajta). Ezek élet/támadási ereje különbözik.

A legutolsó blokkon pedig biztosan egy főellenség található.


## Bolt:

A boltban bírjuk fejleszteni a karakterünk eszközeit/tulajdonságait.
Például: Támadási erőnket tudjuk fejleszteni, illetve életerőt tudunk
visszatölteni.

## Láda:

Amikor egy ládához érünk, lehetőségünk van egy kérdésre
válaszolva kinyitni és megszerezni a tartalmát.

A kérdés lefedheti a prog tananyagot, illetve a játék elején
található „bevezető” szöveg tartalmát is. Amennyiben sikerül
megválaszolnunk V-buckot(pénzt) kapunk esetleg.

# Játék vége

A játéknak akkor lesz vége, amikor elfogy az életerőnk(veszítünk)
vagy legyőzzük a főellenséget(győzünk).

A játék végén pedig pontszámot számítunk a játékos teljesítménye
alapján.


