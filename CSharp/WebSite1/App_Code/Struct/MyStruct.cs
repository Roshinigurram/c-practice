﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for MyStruct
/// </summary>
public struct MyStruct
{
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string GetName()
    {
        return FirstName + ' ' + LastName;
    }
}