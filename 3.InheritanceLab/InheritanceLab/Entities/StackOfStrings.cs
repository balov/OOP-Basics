using System.Collections.Generic;

public class StackOfStrings
{
    private List<string> data;

    public StackOfStrings()
    {
        this.data = new List<string>();
    }

    public void Push(string item)
    {
        data.Add(item);
    }

    public string Pop()
    {
        string item = data[data.Count - 1];
        data.RemoveAt(data.Count - 1);
        return item;
    }

    public string Peek()
    {
        return data[data.Count - 1];
    }

    public bool IsEmpty()
    {
        if (data.Count == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}