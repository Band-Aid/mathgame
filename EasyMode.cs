using Godot;
using System;

public partial class EasyMode : Button
{
    public void OpenEasyMode()
    {
        GetTree().ChangeSceneToFile("res://main2d.tscn");
    }
}
