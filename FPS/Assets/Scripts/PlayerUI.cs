using TMPro;
using UnityEngine;

public class PlayerUI : MonoBehaviour
{
    public TextMeshProUGUI prompText;

    public void UpdateText(string promptMessage)
    {
        prompText.text = promptMessage;
    }
}
