﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System;
using System.Configuration;

namespace Microsoft.Practices.EnterpriseLibrary.Common.Tests.Configuration.TestObjects
{
    public class TestLeafConfigurationElement : ConfigurationElement
    {
        private const string idProperty = "id";
        private const string otherKeyPartProperty = "otherKeyPart";
        private const string randomOtherProperty = "randomOther";
        private const string anIntProperty = "anInt";

        [ConfigurationProperty(idProperty, IsKey=true)]
        public Guid ID
        {
            get{return (Guid) base[idProperty];}
            set{base[idProperty] = value;}
        }

        [ConfigurationProperty(otherKeyPartProperty, IsKey = true)]
        public string OtherKeyPart
        {
            get { return (string) base[otherKeyPartProperty]; }
            set { base[otherKeyPartProperty] = value; }
        }

        [ConfigurationProperty(randomOtherProperty)]
        public string SomeOtherValue
        {
            get { return (string)base[randomOtherProperty]; }
            set { base[randomOtherProperty] = value; }
        }

        [ConfigurationProperty(anIntProperty)]
        public int AnInt
        {
            get { return (int)base[anIntProperty]; }
            set { base[anIntProperty] = value; }
        }
    }
}
