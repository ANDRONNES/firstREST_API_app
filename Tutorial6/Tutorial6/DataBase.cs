﻿namespace Tutorial6.Models;

public class DataBase
{
    public static List<Test> Tests = new List<Test>()
    {
        new Test() { Id = 1,Name = "Test1"},
        new Test() { Id = 2,Name = "Test2"},
        new Test() { Id = 3,Name = "Test3"}
    };
}