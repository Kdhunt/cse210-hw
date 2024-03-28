public class Shape{
    protected string _color {get; set;}
    public Shape(string color){
        _color = color;
    }
    public virtual double GetArea(){
        return 0;
    }
}