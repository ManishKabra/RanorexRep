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
    ///The FAQ recording.
    /// </summary>
    [TestModule("57c3635b-d6f2-436a-9a0b-31a9a2a2aab2", ModuleType.Recording, 1)]
    public partial class FAQ : ITestModule
    {
        /// <summary>
        /// Holds an instance of the STSAndBasic.STSAndBasicRepository repository.
        /// </summary>
        public static STSAndBasic.STSAndBasicRepository repo = STSAndBasic.STSAndBasicRepository.Instance;

        static FAQ instance = new FAQ();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public FAQ()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static FAQ Instance
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

            // Step## Open the app and tap the info icon
            Report.Log(ReportLevel.Info, "Section", "Step## Open the app and tap the info icon", new RecordItemIndex(0));
            
            ClickInfoButton();
            Delay.Milliseconds(0);
            
            // Validation## Info menu opens up
            Report.Log(ReportLevel.Info, "Section", "Validation## Info menu opens up", new RecordItemIndex(2));
            
            ValidateInfoPage();
            Delay.Milliseconds(0);
            
            // Step## Select the FAQ's button
            Report.Log(ReportLevel.Info, "Section", "Step## Select the FAQ's button", new RecordItemIndex(4));
            
            SelectPageFromInfo("FAQs");
            Delay.Milliseconds(0);
            
            // Validation## Directs to a screen with a list of questions
            Report.Log(ReportLevel.Info, "Section", "Validation## Directs to a screen with a list of questions", new RecordItemIndex(6));
            
            VerifyActionBarTitle("FAQs");
            Delay.Milliseconds(0);
            
            ValidateContents("Why do I need an access code?;What do I do in case I lose my access code?;Why do I need to tell the app whether I generally use custom ear molds or not?");
            Delay.Milliseconds(0);
            
            // Step## Select a specific question
            Report.Log(ReportLevel.Info, "Section", "Step## Select a specific question", new RecordItemIndex(9));
            
            SelectPageFromFAQ("Why do I need an access code?");
            Delay.Milliseconds(0);
            
            // Validation## Tapping on a specific question takes to another screen with selected question and answer
            Report.Log(ReportLevel.Info, "Section", "Validation## Tapping on a specific question takes to another screen with selected question and answer", new RecordItemIndex(11));
            
            ValidateContents("Why do I need an access code?;The app is intended for hearing care professionals only.");
            Delay.Milliseconds(0);
            
            // Step## Tap back
            Report.Log(ReportLevel.Info, "Section", "Step## Tap back", new RecordItemIndex(13));
            
            BackAction();
            Delay.Milliseconds(0);
            
            // Validation## Tapping back takes to the FAQs screen
            Report.Log(ReportLevel.Info, "Section", "Validation## Tapping back takes to the FAQs screen", new RecordItemIndex(15));
            
            ValidateContents("Why do I need an access code?;What do I do in case I lose my access code?;Why do I need to tell the app whether I generally use custom ear molds or not?");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
