using Godot;
using System;

public partial class just_csharp : Label
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
			if (keyEvent.Keycode == Key.Escape || keyEvent.Keycode == Key.Enter) GetTree().ChangeSceneToFile("res://main.tscn");
		}
    }
}