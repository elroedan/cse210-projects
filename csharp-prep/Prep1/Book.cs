using System;

public class Book {
    private string _author;
    private string _title;


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
