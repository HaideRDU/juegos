using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class brillo : MonoBehaviour
{
    public Slider slider;
    private Image imgComponent;

    // Variable estática para almacenar el valor del Slider
    public static float sliderValue = 0.5f; // Valor por defecto

    void Start()
    {
        // Encuentra el primer objeto con la etiqueta "Luz"
        GameObject luzObject = GameObject.FindWithTag("Luz");

        // Verifica si se encontró un objeto con la etiqueta "Luz"
        if (luzObject != null)
        {
            // Obtén el componente Image del objeto con la etiqueta "Luz"
            imgComponent = luzObject.GetComponent<Image>();

            // Asegúrate de que el slider esté inicializado correctamente
            if (imgComponent != null && slider != null)
            {
                // Configura el valor inicial del slider según el valor estático
                slider.value = sliderValue;

                // Aplica el valor inicial de la transparencia
                Color currentColor = imgComponent.color;
                currentColor.a = sliderValue;
                imgComponent.color = currentColor;

                // Añade un listener para llamar a la función OnSliderValueChanged cada vez que el valor del slider cambie
                slider.onValueChanged.AddListener(OnSliderValueChanged);
            }
            else if (imgComponent == null)
            {
                Debug.LogError("No se encontró un componente Image en el objeto con la etiqueta 'Luz'.");
            }
            else
            {
                Debug.LogError("No se encontró el componente Slider.");
            }
        }
        else
        {
            Debug.LogError("No se encontró un objeto con la etiqueta 'Luz'.");
        }
    }

    // Función para manejar el cambio de valor del slider
    public void OnSliderValueChanged(float value)
    {
        // Actualiza el valor estático
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
        // Si necesitas hacer algo en cada frame, agrégalo aquí
    }
}
