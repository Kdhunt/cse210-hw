class ScriptureReference
{
    public string _reference { get; set; }
    private String _book {get; set;}
    private string _chapter  {get; set;}
    private string _verse  {get; set;}

    public ScriptureReference(string reference)
    {
        _reference = reference;

        //this._book = book;
        //this._chapter = chapter;
        //this._verse = verse;
    }
    public string getDisplayText(){
       // return $"Scripture Reference: {this._book} {this._chapter}:{this._verse} ";
       return $"Scripture Reference: {this._reference}";
    }
}