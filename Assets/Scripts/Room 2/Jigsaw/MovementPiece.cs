using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPiece : MonoBehaviour
{
    Vector3 screenPoint, offset, scanPos, curPositionx, curPositiony, curScreenPoint;
    public float gridSize = 1;

    public string pieceStatus = "idle";

    public string checkPlacement = "";

    public KeyCode placePiece;
    public KeyCode dropPiece;

    void Awake()
    {
        scanPos = gameObject.transform.position;
        screenPoint = Camera.main.WorldToScreenPoint(scanPos);
        offset = scanPos - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));

    }

    void Update()
    {
        if (pieceStatus == "pickedup")
        {
            curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
            curPositionx = Camera.main.ScreenToWorldPoint(curScreenPoint);
            curPositiony = Camera.main.ScreenToWorldPoint(curScreenPoint);


            curPositionx.x = (float)(Mathf.Round(curPositionx.x) / gridSize);
            curPositiony.y = (float)(Mathf.Round(curPositiony.y) / gridSize);


            transform.position = curPositionx;
            transform.position = curPositiony;
        }
        if (Input.GetKeyDown(placePiece))
        {
            checkPlacement = "y";
        }
        if (Input.GetKeyDown(dropPiece))
        {
            pieceStatus = "idle";
        }

    }
    void OnTriggerStay2D(Collider2D other)
    {
        if ((other.gameObject.name == gameObject.name) && (checkPlacement == "y"))
        {
            other.GetComponent<BoxCollider2D>().enabled = false;
            GetComponent<BoxCollider2D>().enabled = false;
            transform.position = other.gameObject.transform.position;
            pieceStatus = "locked";
            checkPlacement = "n";
        }
    }
    void OnMouseDown()
    {
        pieceStatus = "pickedup";
        checkPlacement = "n";
    }
}
