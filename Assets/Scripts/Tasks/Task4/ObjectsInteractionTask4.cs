using System;
using UnityEngine;

public class ObjectsInteractionTask4 : MonoBehaviour
{
    // TODO: Подпишитесь на событие TimerIsUp класса Toaster созданием объекта Waffle в точке WaffleRoot (из папки Prefabs) 

    [SerializeField] private Transform _waffleRoot;  // Координаты появления вафли
    [SerializeField] private GameObject _wafflePrefab; // Объект вафля из префаба
    [SerializeField] private Toaster _toaster; // Объект тостер

    private void Awake()
    {
        _toaster.TimerIsUp += OnTimerIsUp;  // Подписываемся на событие таймер закончен или нет
    }

    private void OnTimerIsUp()  // Метод проверки таймера
    {
        Instantiate(_wafflePrefab,_waffleRoot);  // Создаем объект вафлю,по координатам
    }

    private void OnDestroy()
    {
        _toaster.TimerIsUp -= OnTimerIsUp;  // Отписываемся от события таймер
    }
}