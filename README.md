# Задача

### Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

#Решение:
    
    1. задала список из строк 'array'
    2. задала пустой список из строк 'array_2'
    3. при помощи цикла for перебрала array_2
    4. если длина строки меньше или равна трем знакам увеличила длинну array_2 на один и внесла эту строку в array_2
    5.вывела содержимое array_2 при помощи foreach