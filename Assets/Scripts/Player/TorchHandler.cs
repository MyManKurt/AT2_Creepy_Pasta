using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorchHandler : MonoBehaviour
{
    public GameObject torch;
    public Light bright;
    public float power = 1;
    public bool isOn;
    private void Awake()
    {
        torch.SetActive(false);
    }
    public void Pickup()
    {
        torch.SetActive(true);
        isOn = true;
    }
    private void Update()
    {
        if (isOn && power > 0)
        {
            power -= 0.02f * Time.deltaTime;
            bright.intensity = Mathf.Clamp01(power);
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            isOn = !isOn;
            bright.enabled = isOn;
        }
    }



}
