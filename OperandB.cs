using Godot;
using System;

public partial class OperandB : RichTextLabel
{
    public override void _Ready()
    {
        var OperandBLabel = this;
        Random rand = new Random();
        int operandB = rand.Next(10, 100);
        OperandBLabel.Text = operandB.ToString();
        OperandBLabel.SetMeta("Type", operandB);
    }
}
