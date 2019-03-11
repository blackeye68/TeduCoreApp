using System;

namespace TeduCoreApp.Data.Interfaces
{
    internal interface IDateTracking
    {
        DateTime DateCreated { get; set; }
        DateTime DateModified { get; set; }
    }
}