using UnityEngine;
using UnityEngine.UI;
using uOSC;

[RequireComponent(typeof(uOscClient))]
public class OSCManager : MonoBehaviour
{
    public InputField inputField;

    public void Send()
    {
        string inputText = inputField.text;
        var client = GetComponent<uOscClient>();
        client.Send("/dollars/generate", inputText);
    }
}
