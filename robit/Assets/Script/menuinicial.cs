using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void PlayGame()
    {
        // Cargar la escena del juego
        SceneManager.LoadScene(5);
    }

    public void QuitGame()
    {
        // Salir de la aplicación
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }

    public void OpenSettings()
    {
        // Implementa la lógica para abrir la pantalla de configuración aquí
        SceneManager.LoadScene(2);
    }

    public void OpenCredits()
    {
        // Implementa la lógica para abrir la pantalla de créditos aquí
        SceneManager.LoadScene(3);
    }
        public void OpenManual()
    {
        // Implementa la lógica para abrir la pantalla de créditos aquí
        SceneManager.LoadScene(4);
    }
}
