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
    ///The StartTheAppAfterInitialSetupDone recording.
    /// </summary>
    [TestModule("776cd93f-d3dc-433e-8555-77391b44372c", ModuleType.Recording, 1)]
    public partial class StartTheAppAfterInitialSetupDone : ITestModule
    {
        /// <summary>
        /// Holds an instance of the STSAndBasic.STSAndBasicRepository repository.
        /// </summary>
        public static STSAndBasic.STSAndBasicRepository repo = STSAndBasic.STSAndBasicRepository.Instance;

        static StartTheAppAfterInitialSetupDone instance = new StartTheAppAfterInitialSetupDone();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public StartTheAppAfterInitialSetupDone()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static StartTheAppAfterInitialSetupDone Instance
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

            // Validation## Immediately after the splash screen, customer mangement screen is opened
            Report.Log(ReportLevel.Info, "Section", "Validation## Immediately after the splash screen, customer mangement screen is opened", new RecordItemIndex(0));
            
            ValidateCustomerScreen();
            Delay.Milliseconds(0);
            
            // Step## Kill the app and launch again
            Report.Log(ReportLevel.Info, "Section", "Step## Kill the app and launch again", new RecordItemIndex(2));
            
            CloseApp();
            Delay.Milliseconds(0);
            
            StartApp();
            Delay.Milliseconds(0);
            
            // Validation## Customer list screen is displayed
            Report.Log(ReportLevel.Info, "Section", "Validation## Customer list screen is displayed", new RecordItemIndex(5));
            
            ValidateCustomerScreen();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
