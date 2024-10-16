using DevelopAuxiliaryTool.Utility;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevelopAuxiliaryTool.AddDatabase
{
    public interface IEntityBuild
    {
        ICreateEntityFile EntityBuild(EntityBuildModel options);
    }
}
