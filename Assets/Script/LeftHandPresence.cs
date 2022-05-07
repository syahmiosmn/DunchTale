using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class LeftHandPresence : MonoBehaviour
{
    private XRNode left;
    private XRRig rig;
    private GameObject spawnedModel;
    public GameObject handModel;
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<XRRig>(); 

        left = XRNode.LeftHand;
        spawnedModel = Instantiate(handModel, this.transform);
    }

    // Update is called once per frame
    void Update()
    {
        InputDevice lefty = InputDevices.GetDeviceAtXRNode(left);
        spawnedModel.SetActive(true);
         
                   
    }
}
