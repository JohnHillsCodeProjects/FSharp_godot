using Godot;
using System;

public partial class main : Label
{
	public override void _Input(InputEvent @event)
	{
		if (@event is InputEventKey keyEvent && keyEvent.Pressed)
		{
			if (keyEvent.Keycode == Key.Key1) GetTree().ChangeSceneToFile("res://just_csharp.tscn"); 
			if (keyEvent.Keycode == Key.Key2) GetTree().ChangeSceneToFile("res://fs_and_cs.tscn"); 
		}
	}
}
