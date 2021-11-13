var ship = new ShipConcreteFactory();
var starDestroyer = ship.CreateStarDestroyer();
var xWing = ship.CreateXWing();

starDestroyer.RaiseShields();
starDestroyer.Shoot("lasers");
xWing.Shoot("lasers");
xWing.RaiseShields();