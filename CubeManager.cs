using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class CubeManager : MonoBehaviour
{
    private Cube myCube;

    public Slider heightSlider;
    public Slider widthSlider;
    public Slider lengthSlider;

    public GameObject heightTextObject;
    public GameObject widthTextObject;
    public GameObject lengthTextObject;
    public GameObject surfaceareaTextObject;
    public GameObject volumeTextObject;

    private TextMeshProUGUI heightText { get; set; }
    private TextMeshProUGUI widthText { get; set; }
    private TextMeshProUGUI lengthText { get; set; }
    private TextMeshProUGUI surfaceareaText { get; set; }
    private TextMeshProUGUI volumeText { get; set; }

    // Start is called before the first frame update
    void Start()
    {
        heightText = heightTextObject.GetComponent<TextMeshProUGUI>();
        widthText = widthTextObject.GetComponent<TextMeshProUGUI>();
        lengthText = lengthTextObject.GetComponent<TextMeshProUGUI>();
        surfaceareaText = surfaceareaTextObject.GetComponent<TextMeshProUGUI>();
        volumeText = volumeTextObject.GetComponent<TextMeshProUGUI>();
        // Calls basic constructor, but sets height and width to 0
        myCube = new Cube();

        GetValuesFromSliders();
    }

    // Update is called once per frame
    void Update()
    {
        heightText.text = "Cube Height: " + myCube.GetHeight().ToString();
        widthText.text = "Cube Width: " + myCube.GetWidth().ToString();
        lengthText.text = "Cube Length: " + myCube.GetLength().ToString();
        surfaceareaText.text = "Cube Surface Area: " + myCube.GetSurfaceArea().ToString();
        volumeText.text = "Cube Volume: " + myCube.GetVolume().ToString();
    }

    public void SliderChanged(float newValue)
    {
        GetValuesFromSliders();
    }

    private void GetValuesFromSliders()
    {
        myCube.SetHeight(heightSlider.value);
        myCube.SetLength(lengthSlider.value);
        myCube.SetWidth(widthSlider.value);
    }

}
