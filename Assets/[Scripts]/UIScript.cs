using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine;

public class UIScript : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI m_text;

    // Start is called before the first frame update
    void Start()
    {
        m_text.enabled = false;
    }
    public void TextButtonPressed()
    {
        m_text.enabled = !m_text.enabled;
    }
    public void OnStartPressed()
    {
        SceneManager.LoadScene("Main");
    }
    public void OnMainPressed()
    {
        SceneManager.LoadScene("End");
    }
    public void OnEndScenePressed()
    {
        SceneManager.LoadScene("Start");
    }
}
