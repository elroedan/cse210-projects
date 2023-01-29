using System;


class Prompt
{
  public List<string> Promtps = new List<string>{"Who do you trust most? Why?",
"What are your strengths in relationships (kindness, empathy, etc.)?",
"How do you draw strength from loved ones?",
"What do you value most in relationships (trust, respect, sense of humor, etc.)?",
"What three important things have you learned from previous relationships?",
"What five traits do you value most in potential partners?",
"How do you show compassion to others? How can you extend that same compassion to yourself?",
"What are three things working well in your current relationship? What are three things that could be better?",
"What boundaries could you set in your relationships to safeguard your own well-being?",
"What do you most want your children (or future children) to learn from you?",
"How can you better support and appreciate your loved ones?",
"What does love mean to you? How do you recognize it in a relationship?",
"List three things you’d like to tell a friend, family member, or partner."};

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