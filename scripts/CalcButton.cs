using Godot;

public class CalcButton : Button
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";

    //[Export]
    //public int? Val { get; private set; }
    private int _value;

    [Signal]
    public delegate void calcButtonPressed(int val);

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        if (int.TryParse(this.Text, out int buttonVal))
        {
            _value = buttonVal;
        }
    }

    public override void _Pressed()
    {
        GD.Print($"emit {nameof(calcButtonPressed)} : val: {_value} ");
        this.EmitSignal(nameof(calcButtonPressed), _value);
        base._Pressed();
    }
}
