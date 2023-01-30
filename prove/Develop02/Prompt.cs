using System;


class Prompt
{
  public List<string> Promtps = new List<string>{};

  public Prompt() {
  }
//   public void DisplayPrompt() {
//     System.Console.WriteLine("");
//   }

  public string GenertatePrompt() {
    Random _number = new Random();
    int index = _number.Next(Promtps.Count);
    string prompt = Promtps[index];
    return prompt;

  }
}