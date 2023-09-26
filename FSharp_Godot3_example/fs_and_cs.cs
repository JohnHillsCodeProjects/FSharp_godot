using Godot;
using System;
using FSharpLibrary;

public class fs_and_cs : Label
{
    public override void _Ready()
    {
        Label outputLabel = (Label)GetNode("/root/fs_and_cs/output");
        outputLabel.Text = TestCode.displayText("working");
        //outputLabel.Text = "|F# script not loaded|";
    }

    public override void _Input(InputEvent @event)
    {
        if (@event is InputEventKey keyEvent && keyEvent.Pressed)
        {
            if (keyEvent.Scancode == (int)KeyList.Escape)
            {
                GetTree().ChangeScene("res://main.tscn"); //Go back to main scenes
            }
        }
    }
}
