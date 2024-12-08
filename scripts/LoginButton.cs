using Godot;
using System;

public partial class LoginButton : Button
{
    private Button loginButton;
    private VBoxContainer loginContainer;
    private VBoxContainer startContainer;

    public override void _Ready()
    {
        loginButton = this;
        
        var grandparent = GetParent().GetParent().GetParent();

        loginContainer = grandparent.GetNode<VBoxContainer>("LoginContainer");
        startContainer = grandparent.GetNode<VBoxContainer>("StartContainer");

        loginButton.Connect("pressed", new Callable(this, nameof(LoginButtonPressed)));
    }

    private void LoginButtonPressed()
    {
        startContainer.Visible = false;
        loginContainer.Visible = true;
    }
}
