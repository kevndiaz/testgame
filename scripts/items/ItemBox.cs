using Godot;
using System;

public partial class ItemBox : Area3D
{

	public float rotationSpeed = 2.0f;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		RotateY(Mathf.DegToRad(rotationSpeed));

		if(HasOverlappingBodies()){
			QueueFree();
		}
	}
}
