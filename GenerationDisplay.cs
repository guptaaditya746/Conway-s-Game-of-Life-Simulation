using UnityEngine;
using UnityEngine.UI;

public class GenerationDisplay : MonoBehaviour
{
    public Text generationText; 

    public void UpdateGeneration(int generation)
    {
        if (generationText != null)
        {
            generationText.text = "Generation: " + generation;
        }
    }
}
