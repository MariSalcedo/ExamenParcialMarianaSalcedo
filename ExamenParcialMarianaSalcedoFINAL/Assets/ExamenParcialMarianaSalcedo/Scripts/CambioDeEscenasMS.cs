using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioDeEscenasMS : MonoBehaviour
{
    public void LoadScene(string NombreEscena)
    {
        SceneManager.LoadScene("Escena1");
    }
}