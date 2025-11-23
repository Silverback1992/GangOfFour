using MazeGame;

//In GoF this is createmaze method instead of being the client code
var maze = new Maze();
var r1 = new Room(1);
var r2 = new Room(2);
var door = new Door(r1, r2);

maze.AddRoom(r1);
maze.AddRoom(r2);

r1.SetSide(Direction.North, new Wall());
r1.SetSide(Direction.East, door);
r1.SetSide(Direction.South, new Wall());
r1.SetSide(Direction.West, new Wall());

r2.SetSide(Direction.North, new Wall());
r2.SetSide(Direction.East, new Wall());
r2.SetSide(Direction.South, new Wall());
r2.SetSide(Direction.West, door);
