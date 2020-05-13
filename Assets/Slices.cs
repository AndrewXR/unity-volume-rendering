using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slices : MonoBehaviour 
{
    [SerializeField]
    public Transform SliceX, SliceY, SliceZ;
    public Slider sliderXMin, sliderXMax, sliderYMin, sliderYMax, sliderZMin, sliderZMax;

    Vector3 tempxSlice, tempySlice, tempzSlice;

    void Update()
    {
        // TODO fix Y and Z naming
        sliderXMin.value = (SliceX.position.x + 2.07f) / 4f;
        //sliderZMin.value = (SliceY.position.z + 2.07f) / -4f;
        //sliderYMin.value = (SliceZ.position.x + -3.42f) / -7f;
    }
}
