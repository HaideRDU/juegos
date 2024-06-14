using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class brillo : MonoBehaviour
{
    public Slider slider;
    private Image imgComponent;

    // Variable est�tica para almacenar el valor del Slider
    public static float sliderValue = 0.5f; // Valor por defecto

    void Start()
    {
        // Encuentra el primer objeto con la etiqueta "Luz"
        GameObject luzObject = GameObject.FindWithTag("Luz");

        // Verifica si se encontr� un objeto con la etiqueta "Luz"
        if (luzObject != null)
        {
            // Obt�n el componente Image del objeto con la etiqueta "Luz"
            imgComponent = luzObject.GetComponent<Image>();

            // Aseg�rate de que el slider est� inicializado correctamente
            if (imgComponent != null && slider != null)
            {
                // Configura el valor inicial del slider seg�n el valor est�tico
                slider.value = sliderValue;

                // Aplica el valor inicial de la transparencia
                Color currentColor = imgComponent.color;
                currentColor.a = sliderValue;
                imgComponent.color = currentColor;

                // A�ade un listener para llamar a la funci�n OnSliderValueChanged cada vez que el valor del slider cambie
                slider.onValueChanged.AddListener(OnSliderValueChanged);
            }
            else if (imgComponent == null)
            {
                Debug.LogError("No se encontr� un componente Image en el objeto con la etiqueta 'Luz'.");
            }
            else
            {
                Debug.LogError("No se encontr� el componente Slider.");
            }
        }
        else
        {
            Debug.LogError("No se encontr� un objeto con la etiqueta 'Luz'.");
        }
    }

    // Funci�n para manejar el cambio de valor del slider
    public void OnSliderValueChanged(float value)
    {
        // Actualiza el valor est�tico
        sliderValue = value;

        if (imgComponent != null)
        {
            // Cambia el valor alfa del color del componente Image
            Color currentColor = imgComponent.color;
            currentColor.a = value;
            imgComponent.color = currentColor;
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Si necesitas hacer algo en cada frame, agr�galo aqu�
    }
}
