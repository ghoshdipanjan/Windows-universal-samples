//*********************************************************
//
// Copyright (c) Microsoft. All rights reserved.
// This code is licensed under the MIT License (MIT).
// THIS CODE IS PROVIDED *AS IS* WITHOUT WARRANTY OF
// ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING ANY
// IMPLIED WARRANTIES OF FITNESS FOR A PARTICULAR
// PURPOSE, MERCHANTABILITY, OR NON-INFRINGEMENT.
//
//*********************************************************

using System;
using System.Collections.Generic;
using Windows.UI.Xaml.Controls;

namespace SDKTemplate
{
    public partial class MainPage : Page
    {
        public const string FEATURE_NAME = "Proxy and stub generation for Windows Runtime components";

        List<Scenario> scenarios = new List<Scenario>
        {
            new Scenario() { Title="Using Custom Components", ClassType=typeof(ProxyStubsForWinRTComponents.OvenClient)},
            new Scenario() { Title="Handling Windows Runtime Exceptions", ClassType=typeof(ProxyStubsForWinRTComponents.CustomException)},
        };
    }

    public class Scenario
    {
        public string Title { get; set; }
        public Type ClassType { get; set; }
    }
}