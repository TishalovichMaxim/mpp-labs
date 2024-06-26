﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestsGeneratorLib;

public struct MethodDeclarationInfo
{
    public string ReturnType;
    
    public string Name;

    public IList<ParameterInfo> Parameters;

    public MethodDeclarationInfo(string name, IList<ParameterInfo> parameters, string returnType)
    {
        Name = name;
        Parameters = parameters;
        ReturnType = returnType;
    }
}
