using System;
using UnityEngine;

public class ObjectsInteractionTask5 : MonoBehaviour
{
    // TODO: Подпишитесь на событие ItemSpawned класса Shelf
    // TODO: Если на полке станет более трех предметов - вызовите у объекта Shelf метод Fall
    // TODO: Логика должна работать для обоих полок сцены

    // Сериализуем полки
    [SerializeField] private Shelf _shelfOne;

    [SerializeField] private Shelf _shelfTwo;

    private void OnEnable()
    {
        _shelfOne.ItemSpawned += DestroyShelf;
        _shelfTwo.ItemSpawned += DestroyShelf;
    }

    private void OnDisable()
    {
        _shelfOne.ItemSpawned -= DestroyShelf;
        _shelfTwo.ItemSpawned -= DestroyShelf;
    }

    private void DestroyShelf()
    {
        if (_shelfOne.ItemsCount > 3)
        {
            _shelfOne.Fall();
        }

        if (_shelfTwo.ItemsCount > 3)
        {
            _shelfTwo.Fall();
        }
    }
}