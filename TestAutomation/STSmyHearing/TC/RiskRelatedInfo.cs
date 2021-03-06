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

namespace STSmyHearing.TC
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The RiskRelatedInfo recording.
    /// </summary>
    [TestModule("9359b0ee-b628-4584-85b1-63e5fcfa1125", ModuleType.Recording, 1)]
    public partial class RiskRelatedInfo : ITestModule
    {
        /// <summary>
        /// Holds an instance of the STSmyHearing.STSmyHearingRepository repository.
        /// </summary>
        public static STSmyHearing.STSmyHearingRepository repo = STSmyHearing.STSmyHearingRepository.Instance;

        static RiskRelatedInfo instance = new RiskRelatedInfo();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public RiskRelatedInfo()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static RiskRelatedInfo Instance
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

            // Step## Open the app. Click on Hearing aid. Click on user guide.
            Report.Log(ReportLevel.Info, "Section", "Step## Open the app. Click on Hearing aid. Click on user guide.", new RecordItemIndex(0));
            
            TapOnHome();
            Delay.Milliseconds(0);
            
            TapOn("My Hearing Aid");
            Delay.Milliseconds(0);
            
            TapOn("User Guide");
            Delay.Milliseconds(0);
            
            // Validation## User guide page should open and it should have Imprint link.'. Please attach a screenshot.
            Report.Log(ReportLevel.Info, "Section", "Validation## User guide page should open and it should have Imprint link.'. Please attach a screenshot.", new RecordItemIndex(4));
            
            ValidateActionBarTitle("User Guide");
            Delay.Milliseconds(0);
            
            // Step## Click on imprint .
            Report.Log(ReportLevel.Info, "Section", "Step## Click on imprint .", new RecordItemIndex(6));
            
            TapOn("Imprint");
            Delay.Milliseconds(0);
            
            // Step## Again click on imprint
            Report.Log(ReportLevel.Info, "Section", "Step## Again click on imprint", new RecordItemIndex(8));
            
            TapOn("Imprint");
            Delay.Milliseconds(0);
            
            // Validation##Imprint page should open. Please attach a screenshot.
            Report.Log(ReportLevel.Info, "Section", "Validation##Imprint page should open. Please attach a screenshot.", new RecordItemIndex(10));
            
            ValidateActionBarTitle("Imprint");
            Delay.Milliseconds(0);
            
            SwipePageVerticle(ValueConverter.ArgumentFromString<int>("count", "3"), ValueConverter.ArgumentFromString<double>("startY", "0.6"), ValueConverter.ArgumentFromString<double>("endY", "0.2"), ValueConverter.ArgumentFromString<bool>("takeScreenshot", "True"));
            Delay.Milliseconds(0);
            
            // Step## Verify Legal Manufacturer
            Report.Log(ReportLevel.Info, "Section", "Step## Verify Legal Manufacturer", new RecordItemIndex(13));
            
            // Validation## Manufactured by Sivantos GmbH Henri-Dunant-Str. 100  D-91058 Erlangen  Germany. Attach a screenshot.
            Report.Log(ReportLevel.Info, "Section", "Validation## Manufactured by Sivantos GmbH Henri-Dunant-Str. 100  D-91058 Erlangen  Germany. Attach a screenshot.", new RecordItemIndex(14));
            
            ValidateContentsWithDesc("Legal Manufacturer of the app;Sivantos GmbH;Henri-Dunant-Str. 100;D-91058 Erlangen;Germany", ValueConverter.ArgumentFromString<bool>("takeScreenshot", "False"));
            Delay.Milliseconds(0);
            
            // Step## Verify Brand Name
            Report.Log(ReportLevel.Info, "Section", "Step## Verify Brand Name", new RecordItemIndex(16));
            
            // Validation## Should be Signia. Attach a screenshot.
            Report.Log(ReportLevel.Info, "Section", "Validation## Should be Signia. Attach a screenshot.", new RecordItemIndex(17));
            
            ValidateContentsWithDesc("Signia", ValueConverter.ArgumentFromString<bool>("takeScreenshot", "False"));
            Delay.Milliseconds(0);
            
            // Step## Verify product name
            Report.Log(ReportLevel.Info, "Section", "Step## Verify product name", new RecordItemIndex(19));
            
            // Validation## Should be Signia myHearing. Attach a screenshot.
            Report.Log(ReportLevel.Info, "Section", "Validation## Should be Signia myHearing. Attach a screenshot.", new RecordItemIndex(20));
            
            ValidateContentsWithDesc("Signia myHearing", ValueConverter.ArgumentFromString<bool>("takeScreenshot", "False"));
            Delay.Milliseconds(0);
            
            // Step## Click back twice.
            Report.Log(ReportLevel.Info, "Section", "Step## Click back twice.", new RecordItemIndex(22));
            
            BackAction();
            Delay.Milliseconds(0);
            
            BackAction();
            Delay.Milliseconds(0);
            
            // Step## Click on App Version
            Report.Log(ReportLevel.Info, "Section", "Step## Click on App Version", new RecordItemIndex(25));
            
            // Validation## The Version no. should be displayed in the Format x.x.x.x Attach a screenshot.
            Report.Log(ReportLevel.Info, "Section", "Validation## The Version no. should be displayed in the Format x.x.x.x Attach a screenshot.", new RecordItemIndex(26));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
