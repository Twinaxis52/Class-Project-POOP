using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragger : MonoBehaviour
{
    private Vector3 _dragOffset;
    private Camera _cam;
    public bool Active;

    void Awake(){
        _cam = Camera.main;
    }

    public void ChangeState()
    {
        Active = false;
    }
    void OnMouseDown(){
        if (Active)
        {
            _dragOffset = transform.position - GetMousePos();
        }
    }

    void OnMouseDrag(){
        if (Active)
            transform.position = GetMousePos() + _dragOffset;
    }

    Vector3 GetMousePos(){
        var mousePos = _cam.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;
        return mousePos;
    }
}

/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragger : MonoBehaviour
{
	private Vector3 _dragOffset;
	private Camera _cam;

	void Awake(){
		_cam = Camera.main;
	}

	void OnMouseDown(){
		_dragOffset = transform.position - GetMousePos();
	}

	void OnMouseDrag(){
		transform.position = GetMousePos() + _dragOffset;
	}

	Vector3 GetMousePos(){
		var mousePos = _cam.ScreenToWorldPoint(Input.mousePosition);
		mousePos.z = 0;
		return mousePos;
	}
}*/
