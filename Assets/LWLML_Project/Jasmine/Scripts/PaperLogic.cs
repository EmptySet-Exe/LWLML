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
    //reference to 5 materials for the 5 drawings
    public Material drawing1;
    public Material drawing2;
    public Material drawing3;
    public Material drawing4;
    public Material drawing5;
    //reference to the right drawing type 
    public int correctDrawingType;

    //method to turn on the paper UI
    //calls a public unity event when the correct drawing type is true 
    //calls a public unity event when the wrong drawing is done 
    public bool isCorrectDrawing;
    //public unity event for the paper puzzle manager to listen to
    public UnityEvent onDrawingChange; 

    public void CheckDrawing()
    {
        if (currentDrawingType == correctDrawingType)
        {
            Debug.Log("Correct drawing!");
            isCorrectDrawing = true;
        }
        else
        {
            Debug.Log("Wrong drawing!");
            isCorrectDrawing = false;
        }
    }
    public void ShowPaperUI()
    {
        paperUI.SetActive(true);
    }
    //Method to change the current drawing type
    public void SetDrawingType(int drawingType)
    {
        //debug log to confirm method is called
        Debug.Log("SetDrawingType called, changing to drawing type: " + drawingType);

        currentDrawingType = drawingType;
        CheckDrawing();
        UpdateDrawing();
         onDrawingChange.Invoke();
    }

    //Method to change the drawing based on the currentDrawingType
    public void UpdateDrawing()
    {
        //debug log to confirm method is called
        Debug.Log("UpdateDrawing called, current drawing type: " + currentDrawingType);
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
            case 5:
                drawingRenderer.material = drawing5;
                break;
            default:
                Debug.LogWarning("Invalid drawing type");
                break;
        }
    }

    



}
