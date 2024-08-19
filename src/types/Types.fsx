type AppleVariety =
    | Fuji
    | Gala
    | HoneyCrisp

type BananaVariety =
    | Cavendish
    | Burro
    | Plantain

type CherryVariety =
    | Bing
    | Rainier
    | Montmorency

// and
type FruitSalada =
    { Apples: AppleVariety
      Bananas: BananaVariety
      Cherries: CherryVariety }

// or
type FruitSnack =
    | Apple of AppleVariety
    | Banana of BananaVariety
    | Cherry of CherryVariety
