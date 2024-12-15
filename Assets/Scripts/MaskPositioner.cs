using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class MaskPositioner : MonoBehaviour
{
    ARFaceManager faceManager;

    private void Awake()
    {
        faceManager = GetComponent<ARFaceManager>();
    }
    // Start is called before the first frame update
    void Start()
    {
        var manager = Object.FindAnyObjectByType<ARFaceManager>();
        faceManager.facesChanged += OnFacesChanged;
        //manager.trackablesChanged.AddListener(OnTrackablesChanged);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnFacesChanged(ARFacesChangedEventArgs changes)
    {
        foreach (var face in changes.added)
        {
            // handle added faces
        }

        foreach (var face in changes.updated)
        {
            // handle updated faces
        }

        foreach (var face in changes.removed)
        {
            // handle removed faces
        }
    }
}
