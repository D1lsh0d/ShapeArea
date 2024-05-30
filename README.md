# ShapeArea
## Задание 2:
C# библиотека для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам. 
- [x] Юнит-тесты
- [x] Легкость добавления других фигур (реализован интерфейс IShape)
- [x] Вычисление площади фигуры без знания типа фигуры в compile-time ([/ShapeArea/ShapeAreaCalculator.cs](https://github.com/D1lsh0d/ShapeArea/blob/master/ShapeArea/ShapeAreaCalculator.cs))
- [x] Проверку на то, является ли треугольник прямоугольным 
## Задание 3:
В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.
1. Запрос, если есть смежная таблица продуктов и категорий:
  ```sql
    SELECT 
        p.ProductName,
        c.CategoryName
    FROM 
        Products p
    LEFT JOIN 
        ProductCategories pc ON p.ProductID = pc.ProductID
    LEFT JOIN 
        Categories c ON pc.CategoryID = c.CategoryID
    ORDER BY 
        p.ProductName, c.CategoryName;
  ```
2. Запрос, если смежной таблицы нет
```sql
SELECT 
    p.ProductName,
    c.CategoryName
FROM 
    Products p
LEFT JOIN 
    Categories c ON p.CategoryID = c.CategoryID
ORDER BY 
    p.ProductName, c.CategoryName;
```
