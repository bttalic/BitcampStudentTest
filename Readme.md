￼Napravite klasu PawnShop koja predstavlja zalagaonicu, zalagaonica ima inventar. Sve sto se nalazi u inventaru (InventoryItem) mora imati identifikator (ID), naziv, opis i cijenu. Posebna paznja se pridaje vozilima gdje je bitno znati i koji je tip, godina proizvodnje, proizvodac i stanje (savrseno, ocuvano, lose). Osim vozila bitni su i satovi, kod satova je bitno znati materijal (zlato, srebro, guma, ostalo), proizvodaca i starost.
PawnShop ima i dvije vrste uposlenika svi uposlenici imaju ime, prezime i platu. Posebna vrsta uposlenika su eksperti za koje je potrebno znati i koja im je ekspertiza.
PawnShop treba moci pretraziti, i treba moci izlistati inventar po imenu i cijeni. Napravite mali program koji ce pokazati ono sto ste napravili.
HINT
Za pretragu: napravite interface ISearchable {
bool fitsSearch(string s); }
