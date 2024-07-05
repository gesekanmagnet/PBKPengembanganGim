using UnityEngine;
using UnityEngine.EventSystems;

public class UIButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField] private Transform maze;
    [SerializeField] private float x;

    private bool held;

    public void OnPointerDown(PointerEventData eventData)
    {
        held = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        held = false;
    }

    private void Update()
    {
        if (held == false) return;
        maze.Rotate(Vector3.forward * x * 20 * Time.deltaTime);
    }
}