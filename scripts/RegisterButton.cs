using Godot;
using System;

public partial class RegisterButton : Button
{
    private Button registerButton;
    private VBoxContainer registerContainer;
    private VBoxContainer startContainer;

    public override void _Ready()
    {
        registerButton = this;
        
        var grandparent = GetParent().GetParent().GetParent();

        registerContainer = grandparent.GetNode<VBoxContainer>("RegisterContainer");
        startContainer = grandparent.GetNode<VBoxContainer>("StartContainer");

        registerButton.Connect("pressed", new Callable(this, nameof(RegisterButtonPressed)));
    }

    private void RegisterButtonPressed()
    {
        startContainer.Visible = false;
        registerContainer.Visible = true;
    }
}
