using Godot;

public class Sheep : Sprite
{
    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {

    }

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(float delta)
    {
        float amount = 5f;
        if (Input.IsKeyPressed((int)KeyList.W))
        {
            this.Position += new Vector2(0, -amount);
        }
        else if (Input.IsKeyPressed((int)KeyList.S))
        {
            this.Position += new Vector2(0, amount);
        }
        if (Input.IsKeyPressed((int)KeyList.A))
        {
            this.Position += new Vector2(-amount, 0);
        }
        else if (Input.IsKeyPressed((int)KeyList.D))
        {
            this.Position += new Vector2(amount, 0);
        }
    }
}
