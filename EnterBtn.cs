using Godot;
using System;

public partial class EnterBtn : Button
{
    public override void _Ready()
    {

        //on pressed Call function GetAnswer

    }

    


    public void Randomize()
    {
        var label = GetParent<main2d>().GetNode<RichTextLabel>("RichTextLabel");
        var rand = new Random();
        var num = rand.Next(1, 100); // Generates a random number between 1 and 99
        GD.Print("generated num:", num);
        label.Text = num.ToString();
    }
}
