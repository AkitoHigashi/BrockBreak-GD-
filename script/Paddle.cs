using Godot;
using System;

public partial class Paddle : CharacterBody2D
{
	[Export] private float _speed = 400.0f;
	
	private float _fixedY;
	
	public override void _Ready()
	{
		_fixedY = Position.Y;
	}

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
		
		Position = new Vector2(Position.X,_fixedY);
	}
}
