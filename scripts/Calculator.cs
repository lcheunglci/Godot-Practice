using Godot;

public class Calculator : Node2D
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";

    private Label _label;
    private int _output;

    //public delegate void calcButtonPressed(int val);
    //public event CalcButtonPressedDelegate CalcButtonPressed;


    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        _output = 0;
        _label = this.GetNode<Label>("Label");

        //CalcButtonPressed += OnCalcButtonPressed;

        for (int i = 1; i <= 10; i++)
        {
            var button = this.GetNode<Button>($"KeyPad/Button-{i}");
            if (button != null)
            {
                GD.Print($"Connect signal on button {i}");
                button.Connect("calcButtonPressed", this, nameof(OnCalcButtonPressed));
            }
        }
    }

    //  // Called every frame. 'delta' is the elapsed time since the previous frame.
    //public override void _Process(float delta)
    //{

    //}

    private void OnCalcButtonPressed(int val)
    {
        GD.Print(val);
        if (_label != null)
        {
            _output += val;
            _label.Text = _output.ToString();
        }
    }

}
