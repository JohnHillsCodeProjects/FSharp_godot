using Godot;
using System;
using FSharpLibrary;

public partial class fs_and_cs : Label
{
	public override void _Ready()
	{
		Label outputLabel = (Label)GetNode("/root/fs_and_cs/output");
		outputLabel.Text = TestCode.displayText("working");
        //outputLabel.Text = "|F# code not loaded|";
	}

    public override void _Input(InputEvent @event)
    {
        if (@event is InputEventKey keyEvent && keyEvent.Pressed)
		{
			if (keyEvent.Keycode == Key.Escape || keyEvent.Keycode == Key.Enter) GetTree().ChangeSceneToFile("res://main.tscn");
		}
    }
}
