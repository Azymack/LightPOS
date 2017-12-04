﻿//
// Copyright (c) NickAc. All rights reserved.
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
//
using System;
using static NickAc.LightPOS.Backend.Utils.EnumUtils;

namespace NickAc.LightPOS.Backend.Objects
{
    public class UserAction
    {
        public enum Action
        {
            [Description("Login")]
            Login,
            [Description("Log Out")]
            LogOut,
            [Description("Perform Sale")]
            UserSale,
            [Description("Create User")]
            CreateUser,
            [Description("Modify User")]
            ModifyUser,
            [Description("Delete User")]
            DeleteUser

        }

        public virtual int ID { get; set; }
        public virtual Action Event { get; set; }
        public virtual String Description { get; set; }
        public virtual User User { get; set; }
        public virtual DateTime Time { get; set; }
    }
}