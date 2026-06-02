using Godot;
using System;

public partial class Brock : Area2D
{
	public override void _Ready()
	{
		BodyEntered += OnBodyEntered;
	}

	private void OnBodyEntered(Node2D body)
	{
		 if (!body.IsInGroup("ball"))
		return;
		GD.Print($"Hit");	
		 QueueFree();
	}
}
