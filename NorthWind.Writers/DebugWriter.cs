﻿using NorthWind.Entities.Interfaces;
using NorthWind.Entities.ValueObjects;
using System.Diagnostics;

namespace NorthWind.Writers
{
    internal class DebugWriter : IUserActionWriter
    {
        public void Write(UserAction action)
        {
            Debug.WriteLine("Console Writer: {0}, {1}, {2}",
                action.CreatedDateTime, action.User, action.Description);
        }
    }
}
