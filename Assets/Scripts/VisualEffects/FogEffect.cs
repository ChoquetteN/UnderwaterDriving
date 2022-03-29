using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ImageEffectAllowedInSceneView]
public class FogEffect : MonoBehaviour
{
    public Material _mat;
    // Start is called before the first frame update
    public Color _fogColor;
    public float _depthStart;
    public float _depthDistance;

    void Start()
    {
        GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
    }

    // Update is called once per frame
    void Update()
    {
        _mat.SetColor("_FogColor", _fogColor);
        _mat.SetFloat("_DepthStart", _depthStart);
        _mat.SetFloat("_DepthDistance", _depthDistance);
    }

    private void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        Graphics.Blit(source, destination, _mat);
    }
}
