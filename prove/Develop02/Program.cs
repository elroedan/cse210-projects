using System;

class Program
{
    static void Main(string[] args)
    {
        Menu _start = new Menu();
        int _enter = 6;
        Prompt _prompt= new Prompt();
            _prompt.Promtps.Add("Who do you trust most? Why?");
            _prompt.Promtps.Add("What are your strengths in relationships (kindness, empathy, etc.)?");
            _prompt.Promtps.Add("How do you draw strength from loved ones?");
            _prompt.Promtps.Add("What do you value most in relationships (trust, respect, sense of humor, etc.)?");
            _prompt.Promtps.Add("What three important things have you learned from previous relationships?");
        Entry _entry = new Entry();

        string _text = "";
        _entry._entry = _text;
        
        Journal _createJournal = new Journal();
        string _fileSaved = "";
        _createJournal._fileName = _fileSaved;
        while (_enter != 5) {
        System.Console.WriteLine("");
        
        _start.DisplayMenu();
        _enter = _start.OpenJournal();
        switch (_enter)
        {
            case 1:
                

                _prompt.GenertatePrompt();
                string _write = _prompt.GenertatePrompt();

                _entry.theCurrentTime = DateTime.Now; 
                _text = _entry.WriteEntry(_write);
                

                
                break;
            case 2:
                // string _fileContent = _createJournal.Display(_fileSaved);
                
                _entry.DisplayEntry(_text);
                ;
                break;
            case 3:
                string _loadFile = _createJournal.Load(_fileSaved, _text);
                ;
                break;
            case 4:
                _fileSaved = _createJournal.Save(_text);
                _createJournal._fileName = _fileSaved;
                ;
                break;
            
        
        }
        }
        

    }
}