using Godot;
using System;

public partial class main2d : Node2D
{
  private float time = 0;
  private RichTextLabel timer;
  private bool timer_on = true;
  private int marker = 1; 
  public void _process(float delta)
  {

    if (timer_on){
      timer = GetNode<RichTextLabel>("timer");
    if (timer != null)
    {
      time += delta;
      int hours = (int)(time / 3600);
      int minutes = (int)((time % 3600) / 60);
      int seconds = (int)(time % 60);
      int milliseconds = (int)((time % 1) * 1000);
      string elapsedTime = $"{hours:D2}:{minutes:D2}:{seconds:D2}:{milliseconds:D3}";
      timer.Text = elapsedTime;
      //GD.Print(elapsedTime);
    }
    }
  }
  public override void _Ready()
  {


  }


  public void GetAnswer()
  {
   
    var operands = new int[2];

    var answerinput = GetNode<RichTextLabel>("AnswerInput").Text;
    bool operatortype = (bool)GetNode<RichTextLabel>("Operator").GetMeta("Type");
    if (answerinput != null)
    {
      var answers = answerinput.ToInt();

      operands[0] = GetNode<RichTextLabel>("OperandA").Text.ToInt();
      operands[1] = GetNode<RichTextLabel>("OperandB").Text.ToInt();


      if (operatortype == true)
      {
        if (operands[0] + operands[1] == answers)
        {
          GD.Print("Correct");
          //raise event to main2d.cs
          NextQuestion();

        }
        else
        {
          GD.Print("Incorrect");
        }
      }
      else if (operatortype == false)
      {
        string absoluteDifferenceAsString = Math.Abs(operands[0] - operands[1]).ToString();
        if (absoluteDifferenceAsString == answers.ToString())
        {
         
         // GD.Print("correct:",absoluteDifferenceAsString);
          GD.Print("Correct");
          NextQuestion();
        }
      }
      // GD.Print(answers);
    }
    //Randomize();

  }

  public void ButtonPressed(int buttonId)
  {
    var label = GetNode<RichTextLabel>("AnswerInput");
    //output the button id to console
    GD.Print("Button pressed: " + buttonId);

    switch (buttonId)
    {
      case 1:
        label.Text += "1";
        break;
      case 2:
        label.Text += "2";
        break;
      case 3:
        label.Text += "3";
        break;
      case 4:
        label.Text += "4";
        break;
      case 5:
        label.Text += "5";
        break;
      case 6:
        label.Text += "6";
        break;
      case 7:
        label.Text += "7";
        break;
      case 8:
        label.Text += "8";
        break;
      case 9:
        label.Text += "9";
        break;
      case 0:
        label.Text += "0";
        break;
      default:
        break;
    }
  }
  public void BackSpace()
  {
    var label = GetNode<RichTextLabel>("AnswerInput");
    label.Text = label.Text.Substring(0, label.Text.Length - 1);
  }
  public void NextQuestion()
  {
    if(marker == 2)
    {
      timer_on = false;
      GD.Print("Game Over");
      GetNode<AcceptDialog>("SendRankingmodal").Visible = true;
      return;
    }
    marker++;
    GD.Print("Next Question");
    var label = GetNode<RichTextLabel>("AnswerInput");
    label.Text = "";

    var operandA = GetNode<RichTextLabel>("OperandA");
    var operandB = GetNode<RichTextLabel>("OperandB");
    var OperatorLabel = GetNode<RichTextLabel>("Operator");

    Random rand = new Random();
    //bool isAddition = rand.Next(2) == 0;
    bool isAddition = false;
    OperatorLabel.Text = isAddition ? "+" : "-";
    OperatorLabel.SetMeta("Type", isAddition);
    operandA.Text = rand.Next(10, 100).ToString();
    operandB.Text = rand.Next(10, 100).ToString();

  }

}
