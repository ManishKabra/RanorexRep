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

namespace STSAndTouchControl.TC
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The VerifyTheAdvancedSettings recording.
    /// </summary>
    [TestModule("35773338-f9ed-4576-9877-6387f581709e", ModuleType.Recording, 1)]
    public partial class VerifyTheAdvancedSettings : ITestModule
    {
        /// <summary>
        /// Holds an instance of the STSAndTouchControl.STSAndTouchControlRepository repository.
        /// </summary>
        public static STSAndTouchControl.STSAndTouchControlRepository repo = STSAndTouchControl.STSAndTouchControlRepository.Instance;

        static VerifyTheAdvancedSettings instance = new VerifyTheAdvancedSettings();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public VerifyTheAdvancedSettings()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static VerifyTheAdvancedSettings Instance
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

            // Step## Open touch control App and Click on Advanced settings in More screen
            Report.Log(ReportLevel.Info, "Section", "Step## Open touch control App and Click on Advanced settings in More screen", new RecordItemIndex(0));
            
            TapOnSettings();
            Delay.Milliseconds(0);
            
            TapOn("Advanced Setup");
            Delay.Milliseconds(0);
            
            // Validation## Three options should be displayed -- 7 Performance Level,  5 Performance Level, Others
            Report.Log(ReportLevel.Info, "Section", "Validation## Three options should be displayed -- 7 Performance Level,  5 Performance Level, Others", new RecordItemIndex(3));
            
            ValidateContents("Performance Level 5;Performance Level 7;Other");
            Delay.Milliseconds(0);
            
            // Step## Verify the default selection
            Report.Log(ReportLevel.Info, "Section", "Step## Verify the default selection", new RecordItemIndex(5));
            
            // Validation## Others should be selected by default
            Report.Log(ReportLevel.Info, "Section", "Validation## Others should be selected by default", new RecordItemIndex(6));
            
            ValidateTextSelected("Other");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
