using Godot;
using System;

public partial class Button : Godot.Button
{
    //onpressed event send the button id to the main2d.cs
    public override void _Ready()
    {
        // this.Pressed += () => GetParent<main2d>().ButtonPressed(1);
    }
    
}
