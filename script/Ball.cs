using Godot;
using System;

public partial class Ball : RigidBody2D
{
	[Export] private float _ballPower = 300f;
	
	public override void _Ready()
	{
		ApplyCentralImpulse(new Vector2(1f,-1f) * _ballPower);
	}
}
