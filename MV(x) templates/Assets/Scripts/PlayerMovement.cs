using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    private PlayerInput playerInput;

    void Start()
    {
        playerInput = GetComponent<PlayerInput>();
    }

    void Update()
    {
        Vector2 movement = playerInput.GetMovementInput();
        transform.Translate(movement * speed * Time.deltaTime);
    }
}