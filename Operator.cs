using Godot;
using System;

public partial class Operator : RichTextLabel
{
    public override void _Ready()
    {
        var OperatorLabel = this;
        Random rand = new Random();
        bool isAddition = rand.Next(2) == 0;
        //bool isAddition = true;
        OperatorLabel.Text = isAddition ? "+" : "-";
        OperatorLabel.SetMeta("Type", isAddition);
    }
}
