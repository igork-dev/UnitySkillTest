---------------------------------------------------------------------------------------
Тестовое задание.



Быстрый запуск:
* Запустите приложение. Лучше в формате Windowed.
* Нажмите "Load Sample", для загрузки тестового ролика
* Нажмите "Play" для просмотра ролика



----------------------------------------------------------------------------------------
Инструкция.
Работа с редактором происходит наглядно. Но для полноты картины - создана эта инструкция.

----------------------------------------------------------------------------------------
Создание врешин:
* Выберите инструмент "Create/Move"
* Нажмите на путом месте рабочей области. Вершина будет создана. После этого нажмите еще раз на эту вершину, чтобы снять выделение и завершить её создание.
(Как правило вершины в редакторе создаются как части ломанной линии см. соответствующий раздел, поэтому создание одиночной вершины может показаться немного неочевидным )

Выделение вершин
* Чтобы выделить вершину - нажмите на неё, не перемещая
* Чтобы убрать выделение с вершины - нажмите на неё еще раз.
* Выделенная вершина обозначена анимацией и из неё рисуется подсказывающая линия.

Перемещение вершин
* Уберите выделение с вершин, если оно есть.
* Перетяните мышкой вершину в нужное место.

Создание линии
* Выделите одну вершину
* Нажмите на другую. Между ними появится линия.

Создание ломанной линии
* Создайте новую, или выделите существующую вершину
* Нажимайте на новые места в рабочей области, создавая вершины соединенные линиями.

--------------------------------------------------------------------------------------------------
Удаление
* Выберите инструмент "Delete"
* Наведите мышкой на нужный элемент. Анимация подскажет какие элементы будут удалены
* Произведите удаление кликом

--------------------------------------------------------------------------------------------------
Переключение между кадрами
* Внизу в разделе "Frame:" есть стрелки для перелючения кадра и отображается номер текущего. ( Хоткеи "A, D", или стрелки. )

---------------------------------------------------------------------------------------------------
Копирование кадра
* Для удобства работы с редактором в можете копировать кадр, для вставки его в другое место ролика. Для копирования нажмите кнопку "Copy frame", или CTRL + C ( Примечание: хоткеи с CTRL не работают в среде Unity)

Вставка кадра
* Вы можете вставить ранее скопированный кадр нажатием кнопки "Paste frame", или CTRL + V. Если кадр не пустой, вы увидите предупреждение об этом.( Примечание: хоткеи с CTRL не работают в среде Unity)

---------------------------------------------------------------------------------------------------
Работа с сохранением
* "Load Sample" - загружает пример анимации созданной заранее в редакторе. Для быстрого просмотра возможностей.
* "New" - Создание новой анимации.
* "Save" - Сохранение анимации в файл. Сверху появится сообщение и путь куда сохранился файл.
* "Load" - Загрузка анимации из файла, сохранённого пользователем ранее.

---------------------------------------------------------------------------------------------------
Запуск анимации
* "Play" - Запускает анимацию с частотой 10 фпс. ( Хоткей Space Bar )

---------------------------------------------------------------------------------------------------

Внутренние особенности
* При сохранении и при воспроизведении пустые кадры в конце клипа удаляются, если они есть.
* Сохранение и загрузка - самые базовые, т.к. в Юнити для этого стандартных иснтрументов нет, а написание таких инструментов не входит в задачу теста.

----------------------------------------------------------------------------------------------------
Формат файла с клипом:
* Клип сохраняется в простом формате в XML-файл. 
* Вершина сохраняется в виде своих координат
* Линия сохраняется в виде индексов двух вершин через которые она проходит
