Теория:
1. Просмотрите презентацию и проект по сборкам.
2. Просмотрите презентацию и проект по многопоточности.
3. Если интересно, почитайте про маршалинг: https://ru.stackoverflow.com/questions/588442/%D0%A7%D1%82%D0%BE-%D1%82%D0%B0%D0%BA%D0%BE%D0%B5-%D0%BC%D0%B0%D1%80%D1%88%D0%B0%D0%BB%D0%B8%D0%BD%D0%B3
4. Прочитайте про ассинхронность и многопоточность: https://habr.com/ru/post/337528/

Практика:
1. Создайте проект WinForms, добавьте контрол для отображения таблиц. Источником данных для контрола задайте коллекцию объектов Character. Добавьте текстовое поле для каждого свойства персонажа и кнопку, при нажатии на которою в коллекцию будет добавлен персонаж с указаными свойствами. Сделайте так, чтоб при закрытии формы коллекция сериализовалась в текстовый файл Characters. При запуске приложения в коллекцию должны быть десереализованые данные из файла Characters.
2. Сделайте так чтоб запись в файл из предыдущего задания происходила ассинхронно.
3. Создайте новый поток с помощью Thread, поместите в него метод который будет вычислять число Фибоначчи n-го порядка (в зависимости от входящего аргумента). Саму реализацию вычисления числа Фибоначчи можете загуглить. Запустите метод одновременно в двух потоках и выведите результаты выполнения в основном потоке.
4. Созайте свой тип делегата и с помощью его экземпляра запустите ассинхронно метод который будет записывать произвольный текст в файл.