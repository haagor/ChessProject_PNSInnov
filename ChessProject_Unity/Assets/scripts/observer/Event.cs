using System;

public enum EventType { None = 0, Timeout = 1, MovementDone = 2, EndTurn = 3}

/// <summary>
/// An Event class with all the informations on
/// the event that you receive
/// </summary>
public class Event
{
    private EventType type;             //type of the event
    public EventType Type
    {
        get
        {
            return type;
        }
    }

    private String message;             //message which is sent/received with the event
    public String Message
    {
        get
        {
            return message;
        }
            
    }

    public Event(EventType type, String message)
    {
        this.type = type;
        this.message = message;
    }
}