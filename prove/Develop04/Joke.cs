public class Joke
{
    private string _q;
    private string _a;

    public Joke(string q, string a)
    {
        this._q = q;
        this._a = a;
    }

    public string GetQ()
    {
        return this._q;
    }

    public string GetA()
    {
        return this._a;
    }
}

