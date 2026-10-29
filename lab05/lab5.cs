using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

var catalog = new Category("Каталог", 0, new List<Category>
{
    new Category("Одяг", 0, new List<Category>
    {
        new Category("Верхній одяг", 0, new List<Category>
        {
            new Category("Куртки", 12, new List<Category>()),
            new Category("Пальта", 7, new List<Category>())
        }),
        new Category("Светри", 15, new List<Category>())
    }),
    new Category("Взуття", 4, new List<Category>
    {
        new Category("Кросівки", 23, new List<Category>()),
        new Category("Чоботи", 9, new List<Category>())
    }),
    new Category("Аксесуари", 0, new List<Category>
    {
        new Category("Сумки", 18, new List<Category>()),
        new Category("Ремені", 5, new List<Category>())
    })
});

int callCount = 0;

void printTree(Category node, int level)
{
    callCount++;
    Console.WriteLine(new string(' ', level * 2) + node.Name);
    foreach (var child in node.Children)
        printTree(child, level + 1);
}

callCount = 0;
printTree(catalog, 0);
Console.WriteLine($"printTree calls: {callCount}");

record Category(string Name, int Products, List<Category> Children);