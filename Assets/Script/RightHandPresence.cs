using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class RightHandPresence : MonoBehaviour
{
    private XRNode right;
    private XRRig rig;
    private GameObject spawnedModel;
    public GameObject handModel;
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<XRRig>();

        right = XRNode.RightHand;
        spawnedModel = Instantiate(handModel, this.transform);
    }

    // Update is called once per frame
    void Update()
    {
        InputDevice righty = InputDevices.GetDeviceAtXRNode(right);
        spawnedModel.SetActive(true);


    }
}
