Теория:
1. Просмотрите презентацию по Git. 
2. Просмотрите информацию по веткам их слиянию, если пока еще не представляете как сливать все ваши ветки в одну: 
https://git-scm.com/book/en/v2/Git-Branching-Basic-Branching-and-Merging
3. Просмотрите еще раз по порядку примеры в проектах по делегатам и событиям. Убедитесь что полностью понимаете как задаються параметрыв в лямбда выражения и анонимные методы и понимаете что означает каждая составляющая этих структур.

Практика:
1. Приведите ваш репозиторий в порядок. Для этого все ваши изменения должны находится в одной векте используйте команду git merge для слияния веток.
2. Обьявите обобщенный тип делегата с одним входящим параметром, возвращаемый тип и тип параметра должны опеределятся во время создания делегата РАЗНЫМИ PLACEHOLDER`ами. Задайте действия делегата лямбда выражением и вызовите делегат.
3. Обьявите тип делегата, который не будет ничего возвращать или принимать. Создайте событие на основе этого делегата. Используйте базовый синтаксис для всего этого (т.е. должен быть создан экземпляр делегата, должен быть метод который будет передан в экземпяр делегата и потом созданый экземпляр делегата должен подписаться на событие)
4. По шагам упростите синтаксис 3го задания. После каждого шага проверяйте что все работает без изменений:
    1) Вместо передачи ссылки на метод в конструктор делегата просто присвойте переменной делегата ссылку на метод. 
    2) Уберите метод - задайте действия анонимным методом.
    3) Уберите создание экземпляра делегата, на событие подписывайтесь сразу анонимным методом.
    4) Замените анонимный метод на лямбда выражение.
В этом задании не нужно предоствлять копию задания на каждом шаге, я буду проверять только окончательный результат. Упрощения синтаксиса вы делаете для себя, чтоб точно уловить разницу между разными типами синтаксиса.