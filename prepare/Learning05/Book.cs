using System;

public class Book {
    protected string _author;
    protected string _title;

    public Book () {
        _author = "anonymous";
        _title = "Unkown";

    }

    public Book (string author, string title) {

        _author = author; 
        _title = title;
    }
    public void SetAuthor(string author) {
        _author = author;
    }

    public void SetTitle(string title) {

        _title = title;
    }

    public string GetTitle() {

        return _title;
    }
    public string GetBookInfo () {
        
        return $"{_title} by {_author}";
    }
    public string GetAuthor(){

        return _author;
    }

}
