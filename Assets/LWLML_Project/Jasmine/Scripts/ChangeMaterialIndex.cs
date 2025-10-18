using UnityEngine;

public class ChangeMaterialIndex : MonoBehaviour
{
    //public reference to the paper logic script 
    public PaperLogic paperLogic;
    //public reference to the material index to change to
    public int materialIndex;
    // public method to change the paperlogic integer to the material index
    public void ChangeMaterial()
    {
        //debug log to confirm method is called
        Debug.Log("ChangeMaterial called, changing to material index: " + materialIndex);
        
        paperLogic.SetDrawingType(materialIndex);
    }
  
}
