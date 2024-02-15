using Godot;
using System;

public partial class OperandA : RichTextLabel
{
    public override void _Ready()
    {
               var OperandALabel = this;
        Random rand = new Random();
        int operandB = rand.Next(10, 100);
        OperandALabel.Text = operandB.ToString();
        OperandALabel.SetMeta("Type", operandB);
       
    }
}
