
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButton : MonoBehaviour
{
    // Esta función se llama cuando se presiona el botón
    public void GoBack()
    {
        // Carga la escena anterior en el historial
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);

    }
        public void GoBackToStart()
    {
        // Carga la primera escena en el Build Settings
        SceneManager.LoadScene(1);
    }
}