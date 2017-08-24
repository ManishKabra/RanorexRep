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
    ///The SwipeToDeleteCustomer recording.
    /// </summary>
    [TestModule("7a00cf2f-95e9-44d1-805d-401f6ae25c07", ModuleType.Recording, 1)]
    public partial class SwipeToDeleteCustomer : ITestModule
    {
        /// <summary>
        /// Holds an instance of the STSAndBasic.STSAndBasicRepository repository.
        /// </summary>
        public static STSAndBasic.STSAndBasicRepository repo = STSAndBasic.STSAndBasicRepository.Instance;

        static SwipeToDeleteCustomer instance = new SwipeToDeleteCustomer();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SwipeToDeleteCustomer()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static SwipeToDeleteCustomer Instance
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

            // Step## Create the patient
            Report.Log(ReportLevel.Info, "Section", "Step## Create the patient", new RecordItemIndex(0));
            
            CreatePatient("CustomerSwipe", "Delete");
            Delay.Milliseconds(0);
            
            SelectCustomerContinue();
            Delay.Milliseconds(0);
            
            BackAction();
            Delay.Milliseconds(0);
            
            // Step## Open the app and select list in the Customer screen
            Report.Log(ReportLevel.Info, "Section", "Step## Open the app and select list in the Customer screen", new RecordItemIndex(4));
            
            SearchCustomer("Delete");
            Delay.Milliseconds(0);
            
            // Step## Swipe left to an existing customer
            Report.Log(ReportLevel.Info, "Section", "Step## Swipe left to an existing customer", new RecordItemIndex(6));
            
            SwipePatientLeft("CustomerSwipe", "Delete");
            Delay.Milliseconds(0);
            
            // Validation## Delete option will be provided.
            Report.Log(ReportLevel.Info, "Section", "Validation## Delete option will be provided.", new RecordItemIndex(8));
            
            ValidateButtonExist("delete");
            Delay.Milliseconds(0);
            
            // Step## Click on delete button
            Report.Log(ReportLevel.Info, "Section", "Step## Click on delete button", new RecordItemIndex(10));
            
            TapOn("delete");
            Delay.Milliseconds(0);
            
            // Validation## Popup appears with options to delete the selected client with ok and cancel button.
            Report.Log(ReportLevel.Info, "Section", "Validation## Popup appears with options to delete the selected client with ok and cancel button.", new RecordItemIndex(12));
            
            ValidateALertMessage("Are you sure that you want to permanently delete the selected client?");
            Delay.Milliseconds(0);
            
            ValidateButtonExist("Cancel");
            Delay.Milliseconds(0);
            
            ValidateButtonExist("OK");
            Delay.Milliseconds(0);
            
            // Step## Click on ok button
            Report.Log(ReportLevel.Info, "Section", "Step## Click on ok button", new RecordItemIndex(16));
            
            ClickOnAlertMessage("OK");
            Delay.Milliseconds(0);
            
            // Validation##  Client should be deleted successfully and customer list screen is displayed.
            Report.Log(ReportLevel.Info, "Section", "Validation##  Client should be deleted successfully and customer list screen is displayed.", new RecordItemIndex(18));
            
            SearchCustomer("Delete");
            Delay.Milliseconds(0);
            
            ValidateContentsContains("Customer, Delete", ValueConverter.ArgumentFromString<bool>("isFound", "False"));
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
