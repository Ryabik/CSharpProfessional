Теория:
1. (Из 7 ДЗ) Прочитайте про первичный и внешний ключ: http://informatic.ugatu.ac.ru/lib/office/Proekt.htm
2. Прочитайте про joins: https://shra.ru/2017/09/sql-join-v-primerakh-s-opisaniem/
3. Прочитатйте про WinForms: https://metanit.com/sharp/windowsforms/1.1.php.

Практика:
1. Создайте проект, подключите Linq to Sql, задайте строку подключения к ранее созданной вами базе данных Cinema, создайте в базе таблицу Directors c полями Id, FirstName, LastName, BirthDate. Заполните таблицу неколькими режисерам с помощью методов Linq To Sql. 
2. Реализуйте добавление персонажей с использованием WinForms по моему примеру EntityFrameworkNavigationProperties
2. Попробуйте удалить из таблицы несколько записей за раз одним методом.


3*. (Прим. задание относится больше к БД, однако будет полезно, прочитайте про первичные и внешние ключи). Добавьте новое поле в таблице Movies, которое будет называться DirectorId, сделайте его внешним ключом, который будет ссылаться на поле Id таблицы Directors (эти действия проведите в SSMS). 
4*. (Прим. вам понадобиться теория про joins) Напишите запрос SELECT к таблице Movies в котором будут отображаться поля таблицы Movies а также имя и фамилия режисера картины.