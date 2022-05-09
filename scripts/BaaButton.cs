using Godot;

public class BaaButton : Button
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {

    }

    public override void _Pressed()
    {
        AudioStreamPlayer2D audio = GetNode<AudioStreamPlayer2D>("Audio");
        if (audio != null) audio.Play();

        base._Pressed();
    }

    //  // Called every frame. 'delta' is the elapsed time since the previous frame.
    //  public override void _Process(float delta)
    //  {
    //      
    //  }
}
