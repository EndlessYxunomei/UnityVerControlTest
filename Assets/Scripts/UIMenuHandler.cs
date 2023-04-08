using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class UIMenuHandler : MonoBehaviour
{
    public TMP_InputField inputField;

    public void StartButtonPressed()
    {
        GameController.Instance.PlayerName = inputField.text;
        SceneManager.LoadScene(1);
    }

}
