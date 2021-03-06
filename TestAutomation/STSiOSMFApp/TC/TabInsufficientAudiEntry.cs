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

namespace STSiOSMFApp.TC
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The TabInsufficientAudiEntry recording.
    /// </summary>
    [TestModule("1d766694-13c0-4d30-a68b-cbb633c1da30", ModuleType.Recording, 1)]
    public partial class TabInsufficientAudiEntry : ITestModule
    {
        /// <summary>
        /// Holds an instance of the STSiOSMFApp.STSiOSMFAppRepository repository.
        /// </summary>
        public static STSiOSMFApp.STSiOSMFAppRepository repo = STSiOSMFApp.STSiOSMFAppRepository.Instance;

        static TabInsufficientAudiEntry instance = new TabInsufficientAudiEntry();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public TabInsufficientAudiEntry()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static TabInsufficientAudiEntry Instance
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

            // Step## Select an existing customer configured with audiogram
            Report.Log(ReportLevel.Info, "Section", "Step## Select an existing customer configured with audiogram", new RecordItemIndex(0));
            
            CreatePatient("AudiogramEntry", "Insufficient");
            Delay.Milliseconds(0);
            
            SelectCustomerContinue();
            Delay.Milliseconds(0);
            
            // Step## Select Enter Audiogram
            Report.Log(ReportLevel.Info, "Section", "Step## Select Enter Audiogram", new RecordItemIndex(3));
            
            TapOn("Enter Audiogram");
            Delay.Milliseconds(0);
            
            // Validation## Audigram entry screen is displayed.
            Report.Log(ReportLevel.Info, "Section", "Validation## Audigram entry screen is displayed.", new RecordItemIndex(5));
            
            VerifyActionBarTitle("Audiogram");
            Delay.Milliseconds(0);
            
            // Step## Right Audiogram - Plot values for 2kHz, 4kHz only and Hit Done
            Report.Log(ReportLevel.Info, "Section", "Step## Right Audiogram - Plot values for 2kHz, 4kHz only and Hit Done", new RecordItemIndex(7));
            
            DrawAudiogramPoints("Right", "2000,40;4000,40");
            Delay.Milliseconds(0);
            
            TabTapOnDetailNavBarRight("Click on 'Done'");
            Delay.Milliseconds(0);
            
            // Validation## Pop-up displayed -"Please enter values at 0.5, 1, 2, 4kHz" with an OK button
            Report.Log(ReportLevel.Info, "Section", "Validation## Pop-up displayed -\"Please enter values at 0.5, 1, 2, 4kHz\" with an OK button", new RecordItemIndex(10));
            
            ValidateALertMessage("Please enter values at 0.5, 1, 2 and 4 kHz.");
            Delay.Milliseconds(0);
            
            // Step## Tap OK
            Report.Log(ReportLevel.Info, "Section", "Step## Tap OK", new RecordItemIndex(12));
            
            ClickOnAlertMessage("OK");
            Delay.Milliseconds(0);
            
            // Validation## Remains in the audiogram entry screen
            Report.Log(ReportLevel.Info, "Section", "Validation## Remains in the audiogram entry screen", new RecordItemIndex(14));
            
            ValidateContentLabels("Cancel;Audiogram");
            Delay.Milliseconds(0);
            
            // Step## Enter Audiogram points for 500Hz and 1kHz and click on done
            Report.Log(ReportLevel.Info, "Section", "Step## Enter Audiogram points for 500Hz and 1kHz and click on done", new RecordItemIndex(16));
            
            DrawAudiogramPoints("Right", "500,40;1000,40");
            Delay.Milliseconds(0);
            
            TabTapOnDetailNavBarRight("Click on 'Done'");
            Delay.Milliseconds(0);
            
            // Validation## Pop-up appears-Do you want to enter values for the "left" ear side too? with yes and no option
            Report.Log(ReportLevel.Info, "Section", "Validation## Pop-up appears-Do you want to enter values for the \"left\" ear side too? with yes and no option", new RecordItemIndex(19));
            
            ValidateALertMessage("Do you want to enter values for the \"left\" ear side too?");
            Delay.Milliseconds(0);
            
            // Step## Click No
            Report.Log(ReportLevel.Info, "Section", "Step## Click No", new RecordItemIndex(21));
            
            ClickOnAlertMessage("No");
            Delay.Milliseconds(0);
            
            // Validation## Audigram is saved and Overview screen is displayed
            Report.Log(ReportLevel.Info, "Section", "Validation## Audigram is saved and Overview screen is displayed", new RecordItemIndex(23));
            
            ValidateInfoPage("AudiogramEntry, Insufficient");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
