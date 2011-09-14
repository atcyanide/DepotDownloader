﻿/*
 * This file is subject to the terms and conditions defined in
 * file 'license.txt', which is part of this source code package.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SteamKit3
{
    [AttributeUsage( AttributeTargets.Class, Inherited = false, AllowMultiple = false )]
    public sealed class HandlerAttribute : Attribute
    {
    }

    public abstract class ClientHandler
    {
        protected SteamClient Client { get; private set; }
        protected JobMgr JobMgr { get { return Client.JobMgr; } }


        public ClientHandler()
        {
        }


        internal void Setup( SteamClient client )
        {
            Client = client;
        }
    }
}