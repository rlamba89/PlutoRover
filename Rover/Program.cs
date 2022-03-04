using Rover.Domain;
using Rover.Domain.Directions;
using System;
using System.Collections.Generic;

namespace PlutoRover
{
    class Program
    {
        static void Main(string[] args)
        {
            var cardinalPoints = new CardinalPoints(0, 0, 100, 100);

            var rover = new Rover.Domain.PlutoRover(new List<IRoverMovementBehaviour>
            {
                new LeftSpinRover(),
                new RightSpinRover(),
                new MoveForwardRover(),
                new MoveBackwardRover()
            }, cardinalPoints, new North(cardinalPoints));

            rover.Move("F");
            Console.WriteLine($"Rover Position - X: {rover._cardinalPoints.XCordinate} and Y: {rover._cardinalPoints.YCordinate} facing {rover._direction.ToString()}");
            rover.Move("F");
            Console.WriteLine($"Rover Position - X: {rover._cardinalPoints.XCordinate} and Y: {rover._cardinalPoints.YCordinate} facing {rover._direction.ToString()}");
            rover.Move("R");
            Console.WriteLine($"Rover Position - X: {rover._cardinalPoints.XCordinate} and Y: {rover._cardinalPoints.YCordinate} facing {rover._direction.ToString()}");
            rover.Move("F");
            Console.WriteLine($"Rover Position - X: {rover._cardinalPoints.XCordinate} and Y: {rover._cardinalPoints.YCordinate} facing {rover._direction.ToString()}");
            rover.Move("F");
            Console.WriteLine($"Rover Position - X: {rover._cardinalPoints.XCordinate} and Y: {rover._cardinalPoints.YCordinate} facing {rover._direction.ToString()}");
            rover.Move("RFRFLBLBLBLB");
            Console.WriteLine($"Rover Position - X: {rover._cardinalPoints.XCordinate} and Y: {rover._cardinalPoints.YCordinate} facing {rover._direction.ToString()}");
            Console.ReadLine();
        }
    }
}
