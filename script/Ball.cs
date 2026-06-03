using Godot;
using System;

public partial class Ball : RigidBody2D
{
	[Export] private float _startPower = 300f;
	[Export] private float _ballSpeed = 300f;
	
	public override void _Ready()
	{
		ApplyCentralImpulse(new Vector2(1f,-1f) * _startPower);
	}
	public override void _PhysicsProcess(double delta)
	{
		if(LinearVelocity.Length() > 0.001f)
		{
		LinearVelocity = LinearVelocity.Normalized() * _ballSpeed;	
		}
	}
}
