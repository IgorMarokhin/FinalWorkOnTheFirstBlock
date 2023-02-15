Данный репозиторий состоит из Блок-схемы (файлы "Flowchart.drawio" и "Flowchart.pdf"), Решения задачи (файл "Program.cs), а также настояшего описания решения (файл "README.md").

# Задача.
*Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше или равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.*

# Примеры.
["hello", "2", "world", ":-)"] -> ["2", ":-)"]

["1234", "1567", "-2", "computer science"] -> ["-2"]

["Russia", "Denmark", "Kazan"] -> []

# Описание решения задачи.

* Первым этапом является создание массива строк
*В блок-схеме (файл "Flowchart") указан вариант создаваемого на старте массива строк, в решении (файл "Program") указаны варианты создания массива строк путем указания элементов с клавиатуры и создаваемого на старте.*

* Вторым этапом является создание массива строк, из элементов, длина которых меньше или равна 3 символа
*В данном этапе программа проверяет каждый элемент заданного массива на соответствие критерию отбора (длина элемента меньше или равна 3 символа), и в случае его соответствия, записывает такой элемент как элемент нового массива*

* Третьим этапом является вывод результата в консоль, в формате, установленном в примерах к Задаче