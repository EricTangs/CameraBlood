using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blood : MonoBehaviour {
    public Material graphicMat;
    float rangeValue;
    float tempCount;
    public float speed = 100;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        tempCount += Time.deltaTime * speed;
        rangeValue = Mathf.Sin(Time.time);
        rangeValue=1+(rangeValue+1)*0.25f;
	}

    private void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        graphicMat.SetFloat("_BloodLength", rangeValue);
        Graphics.Blit(source,destination,graphicMat);
    }
}
