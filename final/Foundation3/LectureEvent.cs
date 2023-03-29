using System;

public class LectureEvent
{
    int _capacity;
    string _speaker;

    public int Capacity
    {
        get {return _capacity; }
        set {_capacity = value; }
    }

    public string Speaker
    {
        get {return _speaker; }
        set {_speaker = value; }
    }
}