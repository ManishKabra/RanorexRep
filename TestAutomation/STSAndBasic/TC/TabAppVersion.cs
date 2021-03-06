﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace STSAndBasic.TC
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The TabAppVersion recording.
    /// </summary>
    [TestModule("22c84203-d5a9-48ff-b74c-e45c59f380cb", ModuleType.Recording, 1)]
    public partial class TabAppVersion : ITestModule
    {
        /// <summary>
        /// Holds an instance of the STSAndBasic.STSAndBasicRepository repository.
        /// </summary>
        public static STSAndBasic.STSAndBasicRepository repo = STSAndBasic.STSAndBasicRepository.Instance;

        static TabAppVersion instance = new TabAppVersion();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public TabAppVersion()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static TabAppVersion Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "6.2")]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "6.2")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            // Step## Open the app, tap on the info icon
            Report.Log(ReportLevel.Info, "Section", "Step## Open the app, tap on the info icon", new RecordItemIndex(0));
            
            ClickInfoButton();
            Delay.Milliseconds(0);
            
            // Validation## Info menu opens up
            Report.Log(ReportLevel.Info, "Section", "Validation## Info menu opens up", new RecordItemIndex(2));
            
            VerifyActionBarTitle("Info");
            Delay.Milliseconds(0);
            
            // Step## Check the app version number displayed
            Report.Log(ReportLevel.Info, "Section", "Step## Check the app version number displayed", new RecordItemIndex(4));
            
            // Validation## Application version information is displayed and it's same as installed version number.(Android 1.x.x.xx)
            Report.Log(ReportLevel.Info, "Section", "Validation## Application version information is displayed and it's same as installed version number.(Android 1.x.x.xx)", new RecordItemIndex(5));
            
            ValidateAppVersion();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
