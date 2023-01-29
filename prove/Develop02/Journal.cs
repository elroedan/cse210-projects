using System;
using System.IO;

class Journal
{
  public string _fileName;
  

 
  public string Save(string _text) {
    
    
    System.Console.WriteLine("Enter name of the file (Entry1.txt): ");
    _fileName = System.Console.ReadLine();


    using (StreamWriter writer = new StreamWriter(_fileName))
    {
        writer.WriteLine(_text);
    }
    
    string _fileWritten = ("The entry has been written to the file.");
    System.Console.WriteLine(_fileWritten);
    return _fileName;
    
  }

  public string Load(string _fileName, string _text) {
    using (StreamWriter _writer = File.AppendText(_fileName))
    {
        _writer.WriteLine(_text);
 
    }

    string _fileAdded = ("The entry was added to the file.");

    return _fileAdded;
  }
  public string Display(string _fileName) {
    using (StreamReader _reader = new StreamReader(_fileName))
    {
        string _fileContent = _reader.ReadToEnd();
        
        return _fileContent;

    }

    }
}