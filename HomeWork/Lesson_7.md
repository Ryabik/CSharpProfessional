 Теория:
 1. Почитайте про комманды SQL:
    1.1. DDL: https://www.tutorialspoint.com/sql_certificate/using_ddl_statements.htm
    1.2. SELECT: https://www.tutorialspoint.com/sql/sql-select-query.htm
    1.3. INSERT: https://www.tutorialspoint.com/sql/sql-insert-query.htm
    1.4. UPDATE: https://www.tutorialspoint.com/sql/sql-update-query.htm
    1.5. DELETE: https://www.tutorialspoint.com/sql/sql-delete-query.htm
    или можете прочитатьвсе это на Metanit.com: https://metanit.com/sql/sqlserver/3.1.php
2. Почитайте определение ADO.NET, чтоб уложилось в голове, то это такое: https://docs.microsoft.com/en-us/dotnet/framework/data/adonet/.
3. Просмотрите примеры подкючения к базе, отметьте для себя с помощью каких классов производится подключение.
4. Прочитайте про using: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/using

Практика:
1. Доделайте, кто не доделал Update LastName Arven из С# проекта. При этом используя app.config для хранения строки подключения (в дальнейшем используйте только этот способ для хранения строки подключения), обращайтесь к ней спомощью ConfigurationManager. 
2. Создайте метод в котором будет производится поключение к БД и создание таблицы Movies с полями Name, Genre, Year (укажите типы которые логически подходят для этих полей).
3. Создайте метод в котором будет происходить заполнение таблицы Movies. Заполните таблицу минимум 3мя значениями.
4. Создайте метод, который будет выводить содержимое таблицы Movies в консоль. 

Во время или по завершению курса можете тренироваться в написании команд SQL на сайте http://sql-ex.ru/.