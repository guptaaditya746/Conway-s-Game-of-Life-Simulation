using UnityEngine;

public class Cell : MonoBehaviour
{
    public bool isAlive = false;


    void Start()
    {
        UpdateCellVisuals();
    }

    void Update()
    {
    }

    public void Initialize(int x, int y)
    {
    }

   public void UpdateCellVisuals()
{
    Renderer renderer = GetComponentInChildren<Renderer>();

    if (isAlive)
    {
        renderer.material.color = Color.green; // Change to your desired alive color.
        renderer.material.shader = Shader.Find("Standard"); // Reset to the standard shader.
        renderer.material.SetColor("_OutlineColor", Color.black); // Set the outline color to black.
        renderer.material.SetFloat("_Outline", 0.02f); // Adjust the outline width as needed.
    }
    else
    {
        renderer.material.color = Color.white; // Change to your desired dead color.
    }
}


}
