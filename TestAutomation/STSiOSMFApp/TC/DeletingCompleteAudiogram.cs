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
    ///The DeletingCompleteAudiogram recording.
    /// </summary>
    [TestModule("42b77784-6b27-4560-ba1c-0cb92265887e", ModuleType.Recording, 1)]
    public partial class DeletingCompleteAudiogram : ITestModule
    {
        /// <summary>
        /// Holds an instance of the STSiOSMFApp.STSiOSMFAppRepository repository.
        /// </summary>
        public static STSiOSMFApp.STSiOSMFAppRepository repo = STSiOSMFApp.STSiOSMFAppRepository.Instance;

        static DeletingCompleteAudiogram instance = new DeletingCompleteAudiogram();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public DeletingCompleteAudiogram()
        {
            H4 = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static DeletingCompleteAudiogram Instance
        {
            get { return instance; }
        }

#region Variables

        string _H4;

        /// <summary>
        /// Gets or sets the value of variable H4.
        /// </summary>
        [TestVariable("0bcd209d-97ff-466e-ad4e-52b482399487")]
        public string H4
        {
            get { return _H4; }
            set { _H4 = value; }
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

            // Step## Pre-condition - Initial setup and Access code setup is done.
            Report.Log(ReportLevel.Info, "Section", "Step## Pre-condition - Initial setup and Access code setup is done.", new RecordItemIndex(0));
            
            // Step## Customer created with audiogram configured and Binaural Flow Complete
            Report.Log(ReportLevel.Info, "Section", "Step## Customer created with audiogram configured and Binaural Flow Complete", new RecordItemIndex(1));
            
            CreatePatient("Deleting", "CompleteAudi");
            Delay.Milliseconds(0);
            
            SelectCustomerContinue();
            Delay.Milliseconds(0);
            
            TapOn("Enter Audiogram");
            Delay.Milliseconds(0);
            
            DrawAudiogramPoints("Right", "500,40;1000,45;2000,50;4000,55");
            Delay.Milliseconds(0);
            
            DrawAudiogramPoints("Left", "500,40;1000,45;2000,50;4000,55");
            Delay.Milliseconds(0);
            
            TapOnRightButton("Click on 'Done'");
            Delay.Milliseconds(0);
            
            TapOn("Send Data to Hearing Aid");
            Delay.Milliseconds(0);
            
            //ValidateALertMessage(" Selected Sound Profile has high amplification output.");
            //Delay.Milliseconds(0);
            
            //TapOn("OK");
            //Delay.Milliseconds(0);
            
            ConnectHI();
            Delay.Milliseconds(0);
            
            //ConfirmationToneYes();
            //Delay.Milliseconds(0);
            
            TapOn("Check Sound Comfort");
            Delay.Milliseconds(0);
            
            TapOn("OK");
            Delay.Milliseconds(0);
            
            ContinueWithLeftEar();
            Delay.Milliseconds(0);
            
            SendDataToHearingAid("Left");
            Delay.Milliseconds(0);
            
            //TapOn("OK");
            //Delay.Milliseconds(0);
            
            ConnectHI();
            Delay.Milliseconds(0);
            
            //ConfirmationToneYes();
            //Delay.Milliseconds(0);
            
            TapOn("Check Sound Comfort");
            Delay.Milliseconds(0);
            
            TapOn("OK");
            Delay.Milliseconds(0);
            
            TapOn("OK");
            Delay.Milliseconds(0);
            
            CloseSession();
            Delay.Milliseconds(0);
            
            CloseApp();
            Delay.Milliseconds(0);
            
            // Step## Open the app, goto List and select the existing customer
            Report.Log(ReportLevel.Info, "Section", "Step## Open the app, goto List and select the existing customer", new RecordItemIndex(25));
            
            StartApp();
            Delay.Milliseconds(0);
            
            SearchCustomer("CompleteAudi");
            Delay.Milliseconds(0);
            
            SelectCustomer("Deleting", "CompleteAudi");
            Delay.Milliseconds(0);
            
            // Validation## Overview screen is displayed
            Report.Log(ReportLevel.Info, "Section", "Validation## Overview screen is displayed", new RecordItemIndex(29));
            
            VerifyActionBarTitle("Deleting, CompleteAudi");
            Delay.Milliseconds(0);
            
            // Validation## Verify Both Left and Right side prefilled - all steps completed
            Report.Log(ReportLevel.Info, "Section", "Validation## Verify Both Left and Right side prefilled - all steps completed", new RecordItemIndex(31));
            
            ValidateAudiogramPointsOnCustomerOverviewScreen("Right", "500,40;1000,45;2000,50;4000,55", ValueConverter.ArgumentFromString<bool>("isExist", "True"));
            Delay.Milliseconds(0);
            
            ValidateBinauralHISelected(H4, "Right");
            Delay.Milliseconds(0);
            
            ValidateBinauralCouplingSelected("Click Sleeve", "Right");
            Delay.Milliseconds(0);
            
            ValidateBinauralClusterSelected("P5", "Right");
            Delay.Milliseconds(0);
            
            ValidateAudiogramPointsOnCustomerOverviewScreen("Left", "500,40;1000,45;2000,50;4000,55", ValueConverter.ArgumentFromString<bool>("isExist", "True"));
            Delay.Milliseconds(0);
            
            ValidateBinauralHISelected(H4, "Left");
            Delay.Milliseconds(0);
            
            ValidateBinauralCouplingSelected("Click Sleeve", "Left");
            Delay.Milliseconds(0);
            
            ValidateBinauralClusterSelected("P5", "Left");
            Delay.Milliseconds(0);
            
            // Step## Tap on the Right audiogram and press Edit
            Report.Log(ReportLevel.Info, "Section", "Step## Tap on the Right audiogram and press Edit", new RecordItemIndex(40));
            
            TapOnOverviewScreen();
            Delay.Milliseconds(0);
            
            TapOnRightButton("Tap on 'Edit'");
            Delay.Milliseconds(0);
            
            // Validation## Enters the Audiogram re-entry screen
            Report.Log(ReportLevel.Info, "Section", "Validation## Enters the Audiogram re-entry screen", new RecordItemIndex(43));
            
            ValidateContents("Audiogram;Done");
            Delay.Milliseconds(0);
            
            // Step## Delete all the plotted points and press Done
            Report.Log(ReportLevel.Info, "Section", "Step## Delete all the plotted points and press Done", new RecordItemIndex(45));
            
            DrawAudiogramPoints("Right", "500,40");
            Delay.Milliseconds(0);
            
            TapOnTrashToolTip();
            Delay.Milliseconds(0);
            
            DrawAudiogramPoints("Right", "1000,45");
            Delay.Milliseconds(0);
            
            TapOnTrashToolTip();
            Delay.Milliseconds(0);
            
            DrawAudiogramPoints("Right", "2000,50");
            Delay.Milliseconds(0);
            
            TapOnTrashToolTip();
            Delay.Milliseconds(0);
            
            DrawAudiogramPoints("Right", "4000,55");
            Delay.Milliseconds(0);
            
            TapOnTrashToolTip();
            Delay.Milliseconds(0);
            
            TapOnRightButton("Tap on 'Done'");
            Delay.Milliseconds(0);
            
            // Validation## Popup appears displaying do you want to enter values for "right" ear side too?
            Report.Log(ReportLevel.Info, "Section", "Validation## Popup appears displaying do you want to enter values for \"right\" ear side too?", new RecordItemIndex(55));
            
            ValidateALertMessage("Do you want to enter values for the \"right\" ear side too?");
            Delay.Milliseconds(0);
            
            // Step## Press No for the popup displayed
            Report.Log(ReportLevel.Info, "Section", "Step## Press No for the popup displayed", new RecordItemIndex(57));
            
            ClickOnAlertMessage("No");
            Delay.Milliseconds(0);
            
            // Validation## Only the Left side details appear in customer overview screen,as the right audiogram is deleted.
            Report.Log(ReportLevel.Info, "Section", "Validation## Only the Left side details appear in customer overview screen,as the right audiogram is deleted.", new RecordItemIndex(59));
            
            ValidateAudiogramPointsOnCustomerOverviewScreen("Left", "500,40;1000,45;2000,50;4000,55", ValueConverter.ArgumentFromString<bool>("isExist", "True"));
            Delay.Milliseconds(0);
            
            ValidateAudiogramPointsOnCustomerOverviewScreen("Right", "500,40;1000,45;2000,50;4000,55", ValueConverter.ArgumentFromString<bool>("isExist", "False"));
            Delay.Milliseconds(0);
            
            // Step## Tap on the Left audiogram and press Edit
            Report.Log(ReportLevel.Info, "Section", "Step## Tap on the Left audiogram and press Edit", new RecordItemIndex(62));
            
            TapOnOverviewScreen();
            Delay.Milliseconds(0);
            
            TapOnRightButton("Tap on 'Edit'");
            Delay.Milliseconds(0);
            
            // Validation## Enters the Audiogram re-entry screen
            Report.Log(ReportLevel.Info, "Section", "Validation## Enters the Audiogram re-entry screen", new RecordItemIndex(65));
            
            ValidateContents("Audiogram;Done");
            Delay.Milliseconds(0);
            
            // Step## Delete all the plotted points and press Done
            Report.Log(ReportLevel.Info, "Section", "Step## Delete all the plotted points and press Done", new RecordItemIndex(67));
            
            DrawAudiogramPoints("Left", "500,40");
            Delay.Milliseconds(0);
            
            TapOnTrashToolTip();
            Delay.Milliseconds(0);
            
            DrawAudiogramPoints("Left", "1000,45");
            Delay.Milliseconds(0);
            
            TapOnTrashToolTip();
            Delay.Milliseconds(0);
            
            DrawAudiogramPoints("Left", "2000,50");
            Delay.Milliseconds(0);
            
            TapOnTrashToolTip();
            Delay.Milliseconds(0);
            
            DrawAudiogramPoints("Left", "4000,55");
            Delay.Milliseconds(0);
            
            TapOnTrashToolTip();
            Delay.Milliseconds(0);
            
            TapOnRightButton("Tap on 'Done'");
            Delay.Milliseconds(0);
            
            // Validation## Returns to the overview screen -pending state. First step Enter Audiogram highlighted
            Report.Log(ReportLevel.Info, "Section", "Validation## Returns to the overview screen -pending state. First step Enter Audiogram highlighted", new RecordItemIndex(77));
            
            VerifyActionBarTitle("Deleting, CompleteAudi");
            Delay.Milliseconds(0);
            
            VerifyTextHighlighted("Enter Audiogram");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
