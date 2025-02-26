using UnityEngine;

public class GameState : State
{
    private PlayerInput playerInput;

    public GameState(PlayerInput input)
    {
        playerInput = input;
    }

    public override void Enter()
    {
        Debug.Log("Entered Game State");
        playerInput.EnableInput(true);
    }

    public override void Exit()
    {
        Debug.Log("Exited Game State");
        playerInput.EnableInput(false);
    }

    public override void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StateMachine.Instance.ChangeState(new PauseState(playerInput));
        }
    }
}