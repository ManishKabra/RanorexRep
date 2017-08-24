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
    ///The ClusterInstantRunSP recording.
    /// </summary>
    [TestModule("fa6b3c1e-87e3-47f1-ac82-4c826b97dff2", ModuleType.Recording, 1)]
    public partial class ClusterInstantRunSP : ITestModule
    {
        /// <summary>
        /// Holds an instance of the STSAndBasic.STSAndBasicRepository repository.
        /// </summary>
        public static STSAndBasic.STSAndBasicRepository repo = STSAndBasic.STSAndBasicRepository.Instance;

        static ClusterInstantRunSP instance = new ClusterInstantRunSP();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ClusterInstantRunSP()
        {
            H2 = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ClusterInstantRunSP Instance
        {
            get { return instance; }
        }

#region Variables

        string _H2;

        /// <summary>
        /// Gets or sets the value of variable H2.
        /// </summary>
        [TestVariable("c076d5b1-f7bc-4e38-b9c6-dcf9d6c8c11c")]
        public string H2
        {
            get { return _H2; }
            set { _H2 = value; }
        }

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

            // Step## Pre-condition: Initial setup is done. Customer configured with audiogram exists. Enable Custom molds
            Report.Log(ReportLevel.Info, "Section", "Step## Pre-condition: Initial setup is done. Customer configured with audiogram exists. Enable Custom molds", new RecordItemIndex(0));
            
            TapOnRightButton("Tap on 'Settings'");
            Delay.Milliseconds(0);
            
            SwitchSettingUseMold(ValueConverter.ArgumentFromString<bool>("YesNo", "True"));
            Delay.Milliseconds(0);
            
            TapOnLeftButton("Press Back key");
            Delay.Milliseconds(0);
            
            CreatePatient("RunSP_Mold", "Cluster");
            Delay.Milliseconds(0);
            
            SelectCustomerContinue();
            Delay.Milliseconds(0);
            
            CloseApp();
            Delay.Milliseconds(0);
            
            // Step## Open the app and select the customer from the list
            Report.Log(ReportLevel.Info, "Section", "Step## Open the app and select the customer from the list", new RecordItemIndex(7));
            
            StartApp();
            Delay.Milliseconds(0);
            
            SearchCustomer("Cluster");
            Delay.Milliseconds(0);
            
            SelectCustomer("RunSP_Mold", "Cluster");
            Delay.Milliseconds(0);
            
            // Step## Enter audiogram - Right 80 dB, 80 dB, 80dB, 80dB for the required frequencies
            Report.Log(ReportLevel.Info, "Section", "Step## Enter audiogram - Right 80 dB, 80 dB, 80dB, 80dB for the required frequencies", new RecordItemIndex(11));
            
            TapEnterAudiogram();
            Delay.Milliseconds(0);
            
            DrawAudiogramPoints("Right", "500,80;1000,80;2000,80;4000,80");
            Delay.Milliseconds(0);
            
            TapOnRightButton("Click on 'Done'");
            Delay.Milliseconds(0);
            
            // Validation## Pop up appears to enter values for Left ear.
            Report.Log(ReportLevel.Info, "Section", "Validation## Pop up appears to enter values for Left ear.", new RecordItemIndex(15));
            
            ValidateALertMessage("Do you want to enter values for the \"left\" ear side too?");
            Delay.Milliseconds(0);
            
            // Step## Press No for the popup appeared
            Report.Log(ReportLevel.Info, "Section", "Step## Press No for the popup appeared", new RecordItemIndex(17));
            
            ClickOnAlertMessage("No");
            Delay.Milliseconds(0);
            
            // Step## Check for the HI recommended & Coupling recommended
            Report.Log(ReportLevel.Info, "Section", "Step## Check for the HI recommended & Coupling recommended", new RecordItemIndex(19));
            
            // Validation## Run SP  & Custom Mold & P3 cluster is recommended
            Report.Log(ReportLevel.Info, "Section", "Validation## Run SP  & Custom Mold & P3 cluster is recommended", new RecordItemIndex(20));
            
            ValidateMonauralHISelected(H2, "Right");
            Delay.Milliseconds(0);
            
            ValidateMonauralCouplingSelected("Custom Mold", "Right");
            Delay.Milliseconds(0);
            
            ValidateMonauralClusterSelected("P3", "Right");
            Delay.Milliseconds(0);
            
            // Step## Reselect HI and Verify Coupling screen is available for selection
            Report.Log(ReportLevel.Info, "Section", "Step## Reselect HI and Verify Coupling screen is available for selection", new RecordItemIndex(24));
            
            // Validation## HI can be selected and Coupling screen should be available for selection
            Report.Log(ReportLevel.Info, "Section", "Validation## HI can be selected and Coupling screen should be available for selection", new RecordItemIndex(25));
            
            TapOn(H2);
            Delay.Milliseconds(0);
            
            VerifyActionBarTitle("Select Side");
            Delay.Milliseconds(0);
            
            TapOn("Fit right ear with hearing aid");
            Delay.Milliseconds(0);
            
            VerifyActionBarTitle("Select Hearing Aid");
            Delay.Milliseconds(0);
            
            TapOnWithContentDesc(H2);
            Delay.Milliseconds(0);
            
            VerifyActionBarTitle("Select Coupling");
            Delay.Milliseconds(0);
            
            TapOn("Recommended when the low frequency part of a hearing loss is moderate or worse.");
            Delay.Milliseconds(0);
            
            // Step## Reselect Cluster to P6
            Report.Log(ReportLevel.Info, "Section", "Step## Reselect Cluster to P6", new RecordItemIndex(33));
            
            // Validation## Reselection of higher cluster should be possible.
            Report.Log(ReportLevel.Info, "Section", "Validation## Reselection of higher cluster should be possible.", new RecordItemIndex(34));
            
            TapOn("P3");
            Delay.Milliseconds(0);
            
            TapOn("P6");
            Delay.Milliseconds(0);
            
            ValidateMonauralClusterSelected("P6", "Right");
            Delay.Milliseconds(0);
            
            // Step## Goto settings and Disable Custom Molds
            Report.Log(ReportLevel.Info, "Section", "Step## Goto settings and Disable Custom Molds", new RecordItemIndex(38));
            
            TapOnLeftButton("Press Back key");
            Delay.Milliseconds(0);
            
            TapOnRightButton("Tap on 'Settings'");
            Delay.Milliseconds(0);
            
            SwitchSettingUseMold(ValueConverter.ArgumentFromString<bool>("YesNo", "False"));
            Delay.Milliseconds(0);
            
            // Step## Create a new customer with audiogram configured
            Report.Log(ReportLevel.Info, "Section", "Step## Create a new customer with audiogram configured", new RecordItemIndex(42));
            
            TapOnLeftButton("Press Back key");
            Delay.Milliseconds(0);
            
            CreatePatient("RunSP", "Cluster");
            Delay.Milliseconds(0);
            
            SelectCustomerContinue();
            Delay.Milliseconds(0);
            
            // Step## Enter audiogram - Right 80 dB, 80 dB, 80dB, 80dB for the required frequencies
            Report.Log(ReportLevel.Info, "Section", "Step## Enter audiogram - Right 80 dB, 80 dB, 80dB, 80dB for the required frequencies", new RecordItemIndex(46));
            
            TapEnterAudiogram();
            Delay.Milliseconds(0);
            
            DrawAudiogramPoints("Right", "500,80;1000,80;2000,80;4000,80");
            Delay.Milliseconds(0);
            
            TapOnRightButton("Click on 'Done'");
            Delay.Milliseconds(0);
            
            ValidateALertMessage("Do you want to enter values for the \"left\" ear side too?");
            Delay.Milliseconds(0);
            
            ClickOnAlertMessage("No");
            Delay.Milliseconds(0);
            
            // Step## Check for the HI recommended & Coupling Recommended
            Report.Log(ReportLevel.Info, "Section", "Step## Check for the HI recommended & Coupling Recommended", new RecordItemIndex(52));
            
            // Validation## Run P  & Tip & P1 is recommended
            Report.Log(ReportLevel.Info, "Section", "Validation## Run P  & Tip & P1 is recommended", new RecordItemIndex(53));
            
            ValidateMonauralHISelected(H2, "Right");
            Delay.Milliseconds(0);
            
            ValidateMonauralCouplingSelected("Tip", "Right");
            Delay.Milliseconds(0);
            
            ValidateMonauralClusterSelected("P1", "Right");
            Delay.Milliseconds(0);
            
            // Step## Reselect HI and Verify Coupling screen is available for selection
            Report.Log(ReportLevel.Info, "Section", "Step## Reselect HI and Verify Coupling screen is available for selection", new RecordItemIndex(57));
            
            // Validation## HI can be selected and Coupling screen should not be available for selection
            Report.Log(ReportLevel.Info, "Section", "Validation## HI can be selected and Coupling screen should not be available for selection", new RecordItemIndex(58));
            
            TapOn(H2);
            Delay.Milliseconds(0);
            
            VerifyActionBarTitle("Select Side");
            Delay.Milliseconds(0);
            
            TapOn("Fit right ear with hearing aid");
            Delay.Milliseconds(0);
            
            VerifyActionBarTitle("Select Hearing Aid");
            Delay.Milliseconds(0);
            
            TapOnWithContentDesc(H2);
            Delay.Milliseconds(0);
            
            VerifyActionBarTitle("RunSP, Cluster");
            Delay.Milliseconds(0);
            
            CloseApp();
            Delay.Milliseconds(0);
            
            StartApp();
            Delay.Milliseconds(0);
            
            TapOnRightButton("Tap on 'Settings'");
            Delay.Milliseconds(0);
            
            SwitchSettingUseMold(ValueConverter.ArgumentFromString<bool>("YesNo", "False"));
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}