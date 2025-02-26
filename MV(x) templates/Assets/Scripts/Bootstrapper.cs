using UnityEngine;

public class Bootstrapper : MonoBehaviour
{
    [SerializeField] private PlayerCombat playerCombat;
    [SerializeField] private PlayerInput playerInput;

    private StateMachine stateMachine;

    void Start()
    {
        stateMachine = new StateMachine();
        stateMachine.Initialize(new GameState(playerInput));
    }

    void Update()
    {
        stateMachine.Update();

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            stateMachine.ChangeState(new FinalState(playerCombat));
        }
    }
}