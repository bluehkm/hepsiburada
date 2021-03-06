///////////////////////////////////////////////////////////////////////////////
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

namespace hepsiburada
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The signout recording.
    /// </summary>
    [TestModule("f1b4f4b0-e7ef-4521-857a-8a73acbc0164", ModuleType.Recording, 1)]
    public partial class Signout : ITestModule
    {
        /// <summary>
        /// Holds an instance of the hepsiburadaRepository repository.
        /// </summary>
        public static hepsiburadaRepository repo = hepsiburadaRepository.Instance;

        static Signout instance = new Signout();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Signout()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Signout Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
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
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Hkm Blue') on item 'ApplicationUnderTest.MyAccount1.HkmBlue'.", repo.ApplicationUnderTest.MyAccount1.HkmBlueInfo, new RecordItemIndex(0));
            Validate.AttributeEqual(repo.ApplicationUnderTest.MyAccount1.HkmBlueInfo, "InnerText", "Hkm Blue");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.MyAccount1.CıkışYap' at 62;-2.", repo.ApplicationUnderTest.MyAccount1.CıkışYapInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.MyAccount1.CıkışYap.Click("62;-2");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'ApplicationUnderTest.MyAccount1.MyAccount'.", repo.ApplicationUnderTest.MyAccount1.MyAccountInfo, new RecordItemIndex(2));
            Validate.Exists(repo.ApplicationUnderTest.MyAccount1.MyAccountInfo);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Giriş Yap') on item 'ApplicationUnderTest.GirişYap'.", repo.ApplicationUnderTest.GirişYapInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.ApplicationUnderTest.GirişYapInfo, "InnerText", "Giriş Yap");
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
