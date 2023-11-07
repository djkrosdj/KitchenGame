using System;
using UnityEngine;

public class ObjectsInteractionTask3 : MonoBehaviour
{
    // TODO: Получите доступ ко всем объектам сцены со скриптом Lamp
    // TODO: При нажатии на кнопку 2 на клавиатуре вызывайте у всех полученных объектов метод Interact
    [SerializeField] private GameObject _lamproot;
    private Lamp[] _lamps;

    private void Start()
    {
        _lamps = _lamproot.GetComponentsInChildren<Lamp>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha2))
        foreach (var lamp in _lamps)
        {
            lamp.Interact();
        }
    }
}