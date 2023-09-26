using Godot;
using System;

public class main : Label
{
    public override void _Input(InputEvent @event)
    {
        if (@event is InputEventKey keyEvent && keyEvent.Pressed)
        {
            if (keyEvent.Scancode == (int)KeyList.Key1)
            {
                GetTree().ChangeScene("res://just_Csharp.tscn"); //Go to just C# code scene
            }
            else if (keyEvent.Scancode == (int)KeyList.Key2)
            {
                GetTree().ChangeScene("res://fs_and_cs.tscn"); //Go to the C# code importing F# code scene
            }
        }
    }
}
