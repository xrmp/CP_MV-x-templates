using UnityEngine;
using UnityEngine.UI;

public class HUDManager : MonoBehaviour
{
    [SerializeField] private Text stateText;

    public void UpdateStateText(string state)
    {
        stateText.text = state;
    }
}