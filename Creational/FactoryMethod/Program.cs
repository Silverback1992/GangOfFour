using FactoryMethod;
using Microsoft.Extensions.DependencyInjection;

//Quick IOC

//Change the DI in order to get different kind of mazes
//DefaultMazeCreator => For default maze
//BombedMazeCreator => For bombed maze
//EnchantedMazeCreator => For enchanted maze

//Each type of maze games would be in different projects with their own DI registration, choosing how to resolve the interface in their own projects

var services = new ServiceCollection();
services.AddTransient<IMazeCreator, EnchantedMazeGame>();

var serviceProvider = services.BuildServiceProvider();

//Maze:
var mazeCreator = serviceProvider.GetRequiredService<IMazeCreator>();
var mazeGame = new MazeGame(mazeCreator);
var maze = mazeGame.CreateMaze();

Console.WriteLine("Done");


