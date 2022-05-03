using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

[RequireComponent(typeof(ARRaycastManager))]

public class ARTapToPlaceObject : MonoBehaviour
{
    public Camera ARCamera;
    public GameObject UIGuide;
    public Button UIButton;
    public GameObject[] objectsToPlace;
    public GameObject objectsPlaced; // parent for instantiated gameobjects
    private GameObject objectToPlace;
    private ARRaycastManager arRaycastManager;
    private string[] objectNames;
    private Text UIButtonText;
    private int objectNumber = 0;
    static List<ARRaycastHit> s_Hits = new List<ARRaycastHit>();

    // Start is called before the first frame update
    void Awake()
    {
        // Disable screen dimming
        Screen.sleepTimeout = SleepTimeout.NeverSleep;

        arRaycastManager = GetComponent<ARRaycastManager>();

        Invoke("DisableUIGuide", 5f);

        objectNames = new string[5] { "Extinguisher", "Trash Bin", "Lady", "House Plant", "First Aid Kit" };

        UIButtonText = UIButton.transform.GetChild(0).GetComponent<Text>();
        UIButtonText.text = objectNames[objectNumber];
        UIButton.onClick.AddListener(SwitchObjectToPlace);

        objectToPlace = objectsToPlace[objectNumber];
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount == 0 || Input.GetTouch(0).phase != TouchPhase.Began || EventSystem.current.currentSelectedGameObject != null)
            return;

        var touch = Input.GetTouch(0);

        if (arRaycastManager.Raycast(touch.position, s_Hits, TrackableType.PlaneWithinPolygon))
        {
            // Raycast hits are sorted by distance, so the first one
            // will be the closest hit.
            var hitPose = s_Hits[0].pose;

            GameObject go = Instantiate(objectToPlace, hitPose.position, hitPose.rotation);
            go.transform.SetParent(objectsPlaced.transform);

        }

    }


    private void SwitchObjectToPlace()
    {
        objectNumber++;
        if (objectNumber >= objectsToPlace.Length)
        {
            objectNumber = 0;
        }
        UIButtonText.text = objectNames[objectNumber];
        objectToPlace = objectsToPlace[objectNumber];
    }

    public void ClearObjects()
    {
        foreach (Transform child in objectsPlaced.transform)
        {
            Destroy(child.gameObject);
        }

    }


    private void DisableUIGuide()
    {
        UIGuide.SetActive(false);
    }



}