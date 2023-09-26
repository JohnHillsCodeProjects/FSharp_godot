using Godot;
using System;

public class just_Csharp : Label
{
    public override void _Ready()
    {
        Label outputLabel = (Label)GetNode("/root/just_Csharp/output");
        outputLabel.Text = "|working|";
    }
    public override void _Input(InputEvent @event)
    {
        if (@event is InputEventKey keyEvent && keyEvent.Pressed)
        {
            if (keyEvent.Scancode == (int)KeyList.Escape)
            {
                GetTree().ChangeScene("res://main.tscn"); //Go back to main scene
            }
        }
    }
}