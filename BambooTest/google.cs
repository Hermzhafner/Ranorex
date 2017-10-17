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

namespace BambooTest
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The google recording.
    /// </summary>
    [TestModule("64aabc9e-117d-435b-9f8a-2dc0760d2675", ModuleType.Recording, 1)]
    public partial class google : ITestModule
    {
        /// <summary>
        /// Holds an instance of the BambooTestRepository repository.
        /// </summary>
        public static BambooTestRepository repo = BambooTestRepository.Instance;

        static google instance = new google();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public google()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static google Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.2")]
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
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.2")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Website", "Opening web site 'google.com' with browser 'IE' in normal mode.", new RecordItemIndex(0));
            Host.Current.OpenBrowser("google.com", "IE", "", false, false, false, false, false);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Google.LstIb' at 22;15.", repo.Google.LstIbInfo, new RecordItemIndex(1));
            repo.Google.LstIb.Click("22;15");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'hallo{Space}ranorex{Return}' with focus on 'Google.LstIb'.", repo.Google.LstIbInfo, new RecordItemIndex(2));
            repo.Google.LstIb.PressKeys("hallo{Space}ranorex{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Application", "Closing application containing item 'Google'.", repo.Google.SelfInfo, new RecordItemIndex(3));
            Host.Current.CloseApplication(repo.Google.Self, new Duration(0));
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
