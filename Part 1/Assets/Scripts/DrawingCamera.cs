using UnityEngine;
using UnityEngine.UI;

public class DrawingCamera : MonoBehaviour
{

    public Camera drawingCamera;
    public RawImage overlayImage;
    
    void Start()
    {
        drawingCamera.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
        overlayImage.texture = drawingCamera.targetTexture;
    }
}