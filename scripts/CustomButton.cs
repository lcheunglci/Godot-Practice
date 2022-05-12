using Godot;

public class CustomButton : Button
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";
    [Export]
    private Label OutputLabel;

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {

    }

    public override void _Pressed()
    {
        base._Pressed();
        if (OutputLabel != null)
        {
            OutputLabel.Text += this.Text;
        }
        else
        {
            GD.Print("No output label set");
        }
    }

    //  // Called every frame. 'delta' is the elapsed time since the previous frame.
    //  public override void _Process(float delta)
    //  {
    //      
    //  }
}
