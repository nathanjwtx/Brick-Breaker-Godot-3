using Godot;
using System;

public class Bricks : Node2D
{
    // Member variables here, example:
    // private int a = 2;
    // private string b = "textvar";

    public override void _Ready()
    {
        // Called every time the node is added to the scene.
        // Initialization here
        var count = 0;
        foreach (Node brick in GetChildren())
        {
            count += 1;
            brick.AddToGroup("Bricks");
        }
    }

//    public override void _Process(float delta)
//    {
//        // Called every frame. Delta is time since last frame.
//        // Update game logic here.
//        
//    }
}
