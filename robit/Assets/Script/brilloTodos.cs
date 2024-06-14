using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class brilloTodos : MonoBehaviour
{
    private Image imgComponent;

    void Start()
    {
        // Encuentra el primer objeto con la etiqueta "Luz"
        GameObject luzObject = GameObject.FindWithTag("Luz");

        // Verifica si se encontr� un objeto con la etiqueta "Luz"   sliderValue
        if (luzObject != null)
        {
            // Obt�n el componente Image del objeto con la etiqueta "Luz"
            imgComponent = luzObject.GetComponent<Image>();

            if (imgComponent != null)
            {
                // Aplica la transparencia usando el valor est�tico del script brillo
                Color currentColor = imgComponent.color;
                currentColor.a = brillo.sliderValue;
                imgComponent.color = currentColor;
            }
            else
            {
                Debug.LogError("No se encontr� un componente Image en el objeto con la etiqueta 'Luz'.");
            }
        }
        else
        {
            Debug.LogError("No se encontr� un objeto con la etiqueta 'Luz'.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Si necesitas hacer algo en cada frame, agr�galo aqu�
    }
}