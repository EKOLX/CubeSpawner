using UnityEngine;
using UnityEngine.UI;

public class MainView : MonoBehaviour
{
    [SerializeField] private InputField inputField;
    [SerializeField] private Button buttonClick;

    private MainController mainController;

    private void Awake()
    {
        mainController = new MainController(); // Can be resolved via DI
        buttonClick.onClick.AddListener(buttonClicked);
    }

    private void buttonClicked()
    {
        inputField.text = mainController.HandleClck();
    }

}
