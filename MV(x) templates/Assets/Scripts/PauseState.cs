using UnityEngine;

public class PauseState : State
{
    private PlayerInput playerInput;

    public PauseState(PlayerInput input)
    {
        playerInput = input;
    }

    public override void Enter()
    {
        Debug.Log("Entered Pause State");
        Time.timeScale = 0;
    }

    public override void Exit()
    {
        Debug.Log("Exited Pause State");
        Time.timeScale = 1;
    }

    public override void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StateMachine.Instance.ChangeState(new GameState(playerInput));
        }
    }
}