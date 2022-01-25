using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileScript : MonoBehaviour
{
    public Vector3 targetPosition;
    private Vector3 correctPosition;
    private SpriteRenderer _sprite;
    public int number;
    public bool inRightPlace;


    void Awake()
    {
        targetPosition = transform.position;
        correctPosition = transform.position;
        _sprite = GetComponent<SpriteRenderer>();


    }


    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, targetPosition, 0.65f);
        if (targetPosition == correctPosition)
        {
            _sprite.color = Color.white;
            inRightPlace = true;

        }
        else
        {
            _sprite.color = Color.gray;
            inRightPlace = false;


        }
    }
}