using System.Collections.Generic;

class Class1
{
    List<string> data = new List<string>();

    public bool IsEmpthy()
    {
        return data.Count == 0;
    }
    public void Push(string newelement)
    {

         data.Add(newelement);
    }
    public string Peek()
    {
        var result = string.Empty;
        if (IsEmpthy() == false)
        {
            result = data[data.Count - 1];
        }
        return result;
    }
    public string Pop()
    {
        var result = string.Empty;
        if (IsEmpthy() == false)
        {
            var lastindex = data.Count - 1;
            result = data[lastindex];
            data.RemoveAt(lastindex);
        }
        return result;

    }
}

