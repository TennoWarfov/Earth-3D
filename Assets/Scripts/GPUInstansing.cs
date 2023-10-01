using TMPro;
using UnityEngine;

public class GPUInstansing : MonoBehaviour
{
    [SerializeField] private TextMeshPro[] _text;

    private void OnValidate()
    {
        if(_text == null)
            return;

        for (int i = 0; i < _text.Length; i++)
        {
            _text[i].text = (30 + i * 6).ToString(); 
        }
    }
}
