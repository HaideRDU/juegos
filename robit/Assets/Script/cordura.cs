using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class cordura : MonoBehaviour
{
    public static float coordura;
    public Image imagen; // Referencia a la imagen cuya opacidad queremos cambiar

    public GameObject coso;

    public bool delcoso;

    public GameObject muertetiempo;

    public GameObject canwa;


    void Start()
    {
        coordura = 100;
    }
    

    void Update()
    {
        // Reducir la cordura con el tiempo
        coordura -= Time.deltaTime;

        // Asegurarse de que la cordura no baje de 0
        if (coordura < 0)
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;


            coordura = 0;
            canwa.SetActive(false);
            muertetiempo.SetActive(true);

            if (Input.GetKeyDown(KeyCode.R))
            {

                SceneManager.LoadScene(1);
                coordura = 100;
                vida.vidaActual = 100;
            }
        }

        // Actualizar la opacidad de la imagen
        UpdateImageOpacity();

       // Debug.Log(coordura);

        if(coordura < 25)
        {
            delcoso = !delcoso;

            coso.SetActive(delcoso);
        }
    }

    void UpdateImageOpacity()
    {
        // Asumiendo que la opacidad máxima es 1 (cordura = 100) y la mínima es 0 (cordura = 0)
        float alpha = coordura / 100f;

        // Obtener el color actual de la imagen
        Color color = imagen.color;

        // Ajustar la opacidad (canal alfa)
        color.a = alpha;

        // Aplicar el nuevo color a la imagen
        imagen.color = color;
    }
}