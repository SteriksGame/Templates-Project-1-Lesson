using UnityEngine;

public class MiniGameEntryPoint : MonoBehaviour
{
    [SerializeField] private Picker _picker;

    private void Awake()
    {
        MiniGameInputController miniGameInputController = new MiniGameInputController();
        _picker.Initialized(miniGameInputController);
    }
}
