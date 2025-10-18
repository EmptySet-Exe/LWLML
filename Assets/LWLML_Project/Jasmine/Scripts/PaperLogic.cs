using UnityEngine;
using UnityEngine.Events;
public class PaperLogic : MonoBehaviour
{
    //reference to the paper WorldSpace UI , it is a child of the paper object- get it privately 
    [SerializeField] private GameObject paperUI;

    //reference to the mesh renderer to change the drawing private
    [SerializeField] private MeshRenderer drawingRenderer;

    //correct drawing type represented as an integer
    public int currentDrawingType;
    //is correct drawing 
    //reference to 4 materials for the 4 drawings
    public Material drawing1;
    public Material drawing2;
    public Material drawing3;
    public Material drawing4;

    //method to turn on the paper UI
    public void ShowPaperUI()
    {
        paperUI.SetActive(true);
    }
    //Method to change the current drawing type
    public void SetDrawingType(int drawingType)
    {
        currentDrawingType = drawingType;
        UpdateDrawing();
    }

    //Method to change the drawing based on the currentDrawingType
    public void UpdateDrawing()
    {
        switch (currentDrawingType)
        {
            case 1:
                drawingRenderer.material = drawing1;
                break;
            case 2:
                drawingRenderer.material = drawing2;
                break;
            case 3:
                drawingRenderer.material = drawing3;
                break;
            case 4:
                drawingRenderer.material = drawing4;
                break;
            default:
                Debug.LogWarning("Invalid drawing type");
                break;
        }
    }

    



}
