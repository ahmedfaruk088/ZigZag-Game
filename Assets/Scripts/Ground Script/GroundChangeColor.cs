using UnityEngine;

public class GroundChangeColor : MonoBehaviour
{
    [SerializeField] private Color[] colors;
    [SerializeField] private Material groundMaterial;
    [SerializeField] private float time;
    [SerializeField] private float lerpValue;
    private int index = 0;
    private float currentTime;

    private void Update()
    {
        SetColorTime();
        SetColorChange();


    }
    private void SetColorTime()
    {
        if (currentTime <= 0)
        {
            colorIndex();
            currentTime = time;
        }
        else
        {
            currentTime -= Time.deltaTime;
        }
    }
    private void colorIndex()
    {
        index++;
        if (index >= colors.Length)
        {
            index = 0;
        }
    }
    private void SetColorChange()
    {
        groundMaterial.color = Color.Lerp(groundMaterial.color, colors[index], lerpValue * Time.deltaTime);
    }
    private void OnDestroy()
    {
        groundMaterial.color = colors[1];
    }


}

