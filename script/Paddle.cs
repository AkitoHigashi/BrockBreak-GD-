using Godot;
using System;

public partial class Paddle : CharacterBody2D
{
	[Export] private float _speed = 400.0f;

	public override void _PhysicsProcess(double delta)
	{
		Vector2 velocity =  Velocity;
		velocity.X = 0;
		
		if(Input.IsKeyPressed(Key.A))
		{
			velocity.X = -_speed;
		}
		if(Input.IsKeyPressed(Key.D))
		{
			velocity.X = _speed;
		}
		
		Velocity = velocity;
		 MoveAndSlide();
	}
}
